using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace TextRPG
{
    public class CreateMainCharacter
    {

       public static void getPreference()
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.Clear();
            Console.SetWindowSize(Console.LargestWindowWidth - 10, Console.LargestWindowHeight - 10);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            HumanFaceGenerator.man.printFace();

            string hello = "Welcome, paperwork for being an adventurer is worse these days, ";
            string info = "I'm going to need your information";
            string difficultyString = "How difficult do you want the game to be?(1,2,3): 1 = easy, 3 = hard";
            string genderPromptString = "What sex would you like to be?(m/f)";
            string namePromptString = "What would you like your name to be?";

            string myNameIs = "..., my name is ";

            Console.SetCursorPosition(81, 1);
            Console.Write(hello);
            Console.SetCursorPosition(81, 2);
            Console.Write(info);
            Console.SetCursorPosition(81, 3);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(difficultyString);
            Console.ForegroundColor = ConsoleColor.White;
            int n = 0;
            
            while (!int.TryParse(Console.ReadKey().KeyChar.ToString(), out n) || n > 3 || n < 1 ) {
                    Console.SetCursorPosition(81, 4);
                    Console.Write("Please Reenter your selection (1,2,3):");
            }

                   
                    Console.SetCursorPosition(81, 4);
                    Console.Write("Difficulty scales ATK, DEF, and SPC (not HP)");

            GameInfo.settings.setdifficulty(n);
            

            Console.SetCursorPosition(81, 5);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(genderPromptString);
            Console.ForegroundColor = ConsoleColor.White;
            
            string genderKey = Console.ReadKey().KeyChar.ToString();
            while (genderKey != "m" &&
                genderKey != "M" &&
                genderKey != "f" &&
                genderKey != "F")
            {
                Console.SetCursorPosition(81, 6);
                Console.Write("Please Reenter your selection");
                Console.SetCursorPosition(81+ genderPromptString.Length, 5);
                genderKey = Console.ReadKey().KeyChar.ToString();
            }
            Console.SetCursorPosition(81, 6);
            Console.Write("                             ");
            MainCharacter.setGender(genderKey);


            Console.SetCursorPosition(81, 7);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(namePromptString);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(81, 8);
            Console.Write("Press enter when finished");

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(81 + namePromptString.Length, 7);
            string name = Console.ReadLine();
            MainCharacter.setName(name);

            Console.Clear();
            Console.SetCursorPosition(0, 0);
            MainCharacter.displayCharacter();

            Console.SetCursorPosition(81, 1);
            Console.WriteLine(myNameIs + MainCharacter.getName());
           

            System.Threading.Thread.Sleep(2000);

            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, 5);
            Console.Title = MainCharacter.getName() + "'s Adventure";
            Console.Write("The Adventure Begins");

            System.Threading.Thread.Sleep(5000);
            
            Console.Clear();

            MainCharacter.setATK(20);
            MainCharacter.setSPC(20);
            MainCharacter.setDEF(0);
            MainCharacter.setHP(100);
            MainCharacter.setLevel(1);

            Fight.story.storyimp();
        }





    public class MainCharacter
        {
          private static string Gender = "";
            private static string Name = "";
            private static int Level;
            private static int HP;
            private static int ATK;
            private static int SPC;
            private static int DEF;
            public static void setGender(string c) {
                Gender = c;
            }
            public static void setName(string c)
            {
                Name = c;
            }
            public static void setATK(int c)
            {
                ATK = c;
            }
            public static int getHP()
            {
                return HP;
            }
            public static void setDEF(int c)
            {
                DEF = c;
            }
            public static int getDEF()
            {
                return DEF;
            }
            public static void setSPC(int c)
            {
                SPC = c;
            }
            public static int getSPC()
            {
                return SPC;
            }
            public static void setHP(int c)
            {
                HP = c;
            }

            public static string getGender()
            {
                return Gender;
            }
            public static string getName()
            {
                return Name;
            }
            public static int getLevel()
            {
                return Level;
            }
            public static int getATK()
            {
                return ATK;
            }

            public static void setLevel(int c)
            {
                Level = c;
            }


            public static void displayCharacter()
            {
                if (Gender.Equals("m", StringComparison.OrdinalIgnoreCase)) { HumanFaceGenerator.man.printFace(); }
                else if (Gender.Equals("f", StringComparison.OrdinalIgnoreCase))
                {
                    HumanFaceGenerator.woman.printFace();
                }
                else

                    HumanFaceGenerator.man.printFace();
            }

            
        }

    }





}

