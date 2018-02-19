using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace tictacRom
{
    [Serializable]
    public class Protocol
    {
        public short index_poteza { get; set; }

        public char control_char { get; set; }

        public char player_char { get; set; }

        public short position_index_x { get; set; }

        public short position_index_y { get; set; }

        public override string ToString()
        {
            return "Poteza: " + index_poteza + ", Control char: " + control_char + ", Char: " + player_char + ", Position: " + position_index_x + ", " + position_index_y + ";";
        }

        public static byte[] ToByteArray(Protocol source)
        {
            var formatter = new BinaryFormatter();
            using (var stream = new MemoryStream())
            {
                formatter.Serialize(stream, source);
                Console.WriteLine("Vel: " + stream.ToArray().Length);
                return stream.ToArray();
            }
        }

        public static Protocol ToProtocol(byte[] source)
        {
            var formatter = new BinaryFormatter();
            using (var stream = new MemoryStream(source))
            {
                object tmp = formatter.Deserialize(stream);
                return (Protocol) tmp;
            }
        }

        #region CREATE_PROTOCOLS
        public static Protocol NewGame(char play_chr)
        {
            return new Protocol { control_char = 'N', player_char = play_chr };
        }

        public static Protocol NextMove(Protocol prev, short x, short y)
        {
            if (prev.player_char == 'X')
                return new Protocol { index_poteza = prev.index_poteza++, control_char = '#', player_char = 'O', position_index_x = x, position_index_y = y };
            return new Protocol { index_poteza = prev.index_poteza++, control_char = '#', player_char = 'X', position_index_x = x, position_index_y = y };
        }

        public static Protocol StartMove(char yourPlayerChar, short x, short y)
        {
            return new Protocol { index_poteza = 1, control_char = '#', player_char = yourPlayerChar, position_index_x = x, position_index_y = y };
        }
        #endregion

        public bool NovaIgra
        {
            get
            {
                if (control_char == 'N')
                    return true;
                return false;
            }
        }

    }
}
