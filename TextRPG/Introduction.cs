using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class Introduction
    {
        public static void intro()
        {
            Console.SetCursorPosition((Console.WindowWidth / 2)-4, 0);
            Console.WriteLine("Tutorial\n");

            string hello = "\tThis is an RPG, you will explore the world, customize your character, and fight foes.\n";
            string fortune = "\tAt the end(level 100) you will fight an unknown boss, will you be prepared?\n";
            string transition = "\tFirst let's customize your character.";

            Console.WriteLine(hello);
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine(fortune);
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine(transition);
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
        }


    }
}
