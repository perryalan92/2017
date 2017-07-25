using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Location
    {
        public static string[] locations = {"Forrest",
                                  "Castle",
                                  "Mine",
                                  "Dungeon",
                                  "Temple",
                                  "Library",
                                  "Shrine",
                                  "Cloister",
                                  "Cliff",
                                  "Hallway",
                                  "Sepulture",
                                  "Graveyard",
                                  "Shipyard",
                                  "Balcony"
                                   };



    }
    public class RandomString
    {
        public static int newRandom(int c)
        {
            Random r = new Random();

            return r.Next(c);
        }

    }

    
}
