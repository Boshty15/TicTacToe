using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictacRom
{
    public partial class Form1 : Form
    {
        public const int IGRALNO_POLJE = 3;

        private Button[] tictacPolje;
        private Network _network;

        private char player_char;
        private short gameIndex = 0;
        private bool naVrsti;

        public Form1()
        {
            InitializeComponent();

            tictacPolje = new Button[] {
                pbt_1_1, pbt_1_2, pbt_1_3,
                pbt_2_1, pbt_2_2, pbt_2_3,
                pbt_3_1, pbt_3_2, pbt_3_3
            };
            for (short i = 0; i < IGRALNO_POLJE; i++)
                for (short j = 0; j < IGRALNO_POLJE; j++)
                {
                    tictacPolje[ToOneDim(i,j)].Click += ButtonTicTac_Click;
                    tictacPolje[ToOneDim(i, j)].Tag = new Coordinates { x = i, y = j };
                }
            naVrsti = false;
            AddToHistory("Zgodovina ==>");
        }

        #region gui.textHandle
        private void statusStripEdit(bool povezan, string ip, string port)
        {
            if (povezan)
            {
                slbl_povezava.Text = "Povezan";
                statusStrip1.BackColor = Color.Green;
            }
            else
            {
                slbl_povezava.Text = "Ni povezave";
                statusStrip1.BackColor = Color.Red;
            }

            slbl_ip.Text = ip;
            slbl_port.Text = port;
        }
        private void buttonEnabling(bool novaIgra, bool zazeniSer, bool ustaviSer, bool pridruziOdj, bool zapustiOdj)
        {
            btn_novaigra.Enabled = novaIgra;
            btn_zazeniserver.Enabled = zazeniSer;
            btn_ustaviserver.Enabled = ustaviSer;
            btn_pridruziseigri.Enabled = pridruziOdj;
            btn_zapritrenutnoigro.Enabled = zapustiOdj;
        }
        public void AddToHistory(string txt)
        {
            if (rtxt_history.InvokeRequired)
                rtxt_history.Invoke(new Action(() => rtxt_history.AppendText(txt + Environment.NewLine)));
            else
                rtxt_history.AppendText(txt + Environment.NewLine);
        }

        void buttonPoljeHandle(string text, int index, bool enabled)
        {
            Console.WriteLine(index);
            tictacPolje[index].Text = text;
            tictacPolje[index].Enabled = enabled;
        }
        #endregion

        #region BUTTUN_HANDLERS
        private void btn_zazeniserver_Click(object sender, EventArgs e)
        {
            connect(NetworkType.Server);
            AddToHistory("Ustvaril server: " + txt_ip.Text + ":" + txt_port.Text);

            if (_network.Connected)
            {
                buttonEnabling(true, false, true, false, false);
            }
        }

        private void btn_ustaviserver_Click(object sender, EventArgs e)
        {
            ustavi();
            AddToHistory("Server ugasnjen");
        }

        private void btn_pridruziseigri_Click(object sender, EventArgs e)
        {
            connect(NetworkType.Client);
            AddToHistory("Povezujem se na server: " + txt_ip.Text + ":" + txt_port.Text);
        }

        private void btn_zapritrenutnoigro_Click(object sender, EventArgs e)
        {
            ustavi();
            //AddToHistory("Prekinil povezavo s serverjem");
        }

        private void btn_novaigra_Click(object sender, EventArgs e)
        {
            resetGame();
            player_char = 'X';
            _network.Send(Protocol.NewGame('O'));
            AddToHistory("Nova igra");
        }
#endregion

        /// <summary>
        /// init the connection
        /// </summary>
        /// <param name="type"></param>
        private void connect(NetworkType type)
        {
            try
            {
                _network = new Network(type, txt_ip.Text, int.Parse(txt_port.Text));
                _network.recivedMsg += recivedMsg;
                _network.statusText += networkStatus_event;

                if (type == NetworkType.Server)
                    buttonEnabling(true, false, true, false, false);
                else
                    buttonEnabling(true, false, false, false, true);
                statusStripEdit(true, txt_ip.Text, txt_port.Text);
            }
            catch
            {
                buttonEnabling(false, true, false, true, false);
                statusStripEdit(false, "", "");

                AddToHistory("Napaka pri povezovanju");
                //MessageBox.Show("Napaka pri povezovanju");
            }

        }

        /// <summary>
        /// status messages from client/server
        /// </summary>
        /// <param name="type"></param>
        void networkStatus_event(NetworkType nType, StatusType sType, string status)
        {
            if (nType == NetworkType.Server)
            {
                switch (sType)
                {
                    case StatusType.Error:
                        AddToHistory(sType.ToString() + ": " + status);
                        break;
                    case StatusType.Warning:
                        AddToHistory(sType.ToString() + ": " + status);
                        break;
                    case StatusType.Info:
                        AddToHistory(sType.ToString() + ": " + status);
                        break;
                }
            }
            else
            {
                switch (sType)
                {
                    case StatusType.Error:
                        ustavi();
                        AddToHistory(sType.ToString() + ": " + status);
                        break;
                    case StatusType.Warning:
                        AddToHistory(sType.ToString() + ": " + status);
                        break;
                    case StatusType.Info:
                        AddToHistory(sType.ToString() + ": " + status);
                        break;
                }
            }
        }

        /// <summary>
        /// Send to other player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonTicTac_Click(object sender, EventArgs e)
        {
            if (_network == null || !naVrsti)
                return;

            Button btn = sender as Button;
            Coordinates cord = btn.Tag as Coordinates;

            Protocol proto = Protocol.StartMove(player_char, cord.x, cord.y);
            gameIndex = proto.index_poteza = ++gameIndex;
            //btn.Enabled = false;
            //btn.Text = proto.player_char.ToString();

            buttonPoljeHandle(player_char.ToString(), ToOneDim(cord.x, cord.y), false);
            _network.Send(proto);
            naVrsti = false;

            if (Utils.TicTacToeCheckForWinner(tictacPolje))
            {
                EndGame();
                AddToHistory("Zmagal si igro !");
            }
            else if (gameIndex >= 9)
            {
                EndGame();
                AddToHistory("Neodločeno");
            }
        }

        /// <summary>
        /// Gets all the messages from client/server
        /// </summary>
        /// <param name="rezultat"></param>
        void recivedMsg(Protocol rezultat)
        {
            //Console.WriteLine(rezultat.ToString());
            AddToHistory("MSG: " + rezultat.ToString());

            if (rezultat.NovaIgra)
            {
                resetGame();
                player_char = rezultat.player_char;
            }
            else if (naVrsti)
            {
                return;
            }
            else
            {
                buttonPoljeHandle(rezultat.player_char.ToString(), ToOneDim(rezultat.position_index_x, rezultat.position_index_y), false);
                gameIndex++;
            }

            naVrsti = true;

            if (Utils.TicTacToeCheckForWinner(tictacPolje))
            {
                EndGame();
                AddToHistory("Izgubil si igro !");
            }
            else if (gameIndex >= 9)
            {
                EndGame();
                AddToHistory("Neodločeno");
            }
        }

        void EndGame()
        {
            for (short i = 0; i < tictacPolje.Length; i++)
                tictacPolje[i].Enabled = false;
        }

        /// <summary>
        /// Reset the game
        /// </summary>
        void resetGame()
        {
            gameIndex = 0;
            for (short i = 0; i < tictacPolje.Length; i++)
            {
                buttonPoljeHandle("", i, true);
                tictacPolje[i].BackColor = Color.FromArgb(192, 255, 192);
            }
        }

        /// <summary>
        /// Preslika to one dimension polje tictactoe
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        int ToOneDim(int x, int y)
        {
            return y + x * IGRALNO_POLJE;
        }

        /// <summary>
        /// close connection
        /// </summary>
        private void ustavi()
        {
            if (_network != null)
            {
                _network.Stop();
                buttonEnabling(false, true, false, true, false);
                statusStripEdit(false, "", "");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ustavi();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pbt_1_1_Click(object sender, EventArgs e)
        {

        }
    }
}
