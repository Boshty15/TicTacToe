using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictacRom
{
    class Utils
    {
        static private int[,] PosibleMoves = new int[,]
        {
            {0,1,2},
            {3,4,5},
            {6,7,8},
            {0,3,6},
            {1,4,7},
            {2,5,8},
            {0,4,8},
            {2,4,6}
        };

        public static bool TicTacToeCheckForWinner(Button[] button)
        {
            for (int i = 0; i < 8; i++)
            {
                int a = PosibleMoves[i, 0];
                int b = PosibleMoves[i, 1];
                int c = PosibleMoves[i, 2];

                Button b1 = button[a];
                Button b2 = button[b];
                Button b3 = button[c];

                if (b1.Text == "" || b2.Text == "" || b3.Text == "") 
                    continue;

                if (b1.Text == b2.Text && b2.Text == b3.Text)
                {
                    b1.BackColor = b2.BackColor = b3.BackColor = Color.Yellow;

                    return true;
                }
            }
            return false;
        }

    }
}
