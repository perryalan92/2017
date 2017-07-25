using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class GameInfo
    {
        public class settings
        {
            private static int difficulty = 0;

            public static void setdifficulty(int c)
            {
                difficulty = c;
            }

            public static int getdifficulty()
            {
                return difficulty;
            }


        }
    }
}
