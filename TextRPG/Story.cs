using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class story
    {
        public static void storyimp()
        {
            Console.Clear();
            Random rand = new Random();
            int diceRoll = rand.Next(5);
            if (diceRoll == 0)
            {
                storyGenerator();
                //start a fight and return nothing
                //   start a fight 
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 2);
                Console.Write("Press any key to continue:");
                Console.ReadKey();
                fightMethod();


            }
            else
            {
                fightstoryGenerator();
            }


            //Generate random list of locations

            List<string> locationRand = new List<string>();
            while (locationRand.Count <= 3)
            {
                string toAddLocation = Location.locations[RandomString.newRandom(Location.locations.Length)];
                if (!locationRand.Contains(toAddLocation))
                {
                    locationRand.Add(toAddLocation);
                }
            }
            locationRand.Sort();


            //Print locations you can go to
            for (int iterator = 1; iterator <= 3; iterator++)
            {
                Console.SetCursorPosition(Console.LargestWindowWidth / 3, Console.CursorTop + 1);

                Console.Write(iterator + ": " + locationRand.ElementAt(iterator));

            }

            int n = 0;
            while (!int.TryParse(Console.ReadKey().KeyChar.ToString(), out n) || n >= 4)
            {

                Console.SetCursorPosition(0, 7);
                Console.Write("Invalid Selection.");
                Console.SetCursorPosition(0, 6);

            }

            string nextLocation = locationRand[n];



            storyimp(nextLocation);




        }
        public static void storyimp(string i)
        {
            Console.Clear();
            Random rand = new Random();
            int diceRoll = rand.Next(5);
            if (diceRoll == 0)
            {

                storyGenerator(i);
                //   start a fight 
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 2);
                Console.Write("Press any key to continue:");
                Console.ReadKey();
                fightMethod();
            }
            else
            {
                fightstoryGenerator(i);
            }



            //Generate random list of locations
            List<string> locationRand = new List<string>();
            while (locationRand.Count <= 3)
            {
                string toAddLocation = Location.locations[RandomString.newRandom(Location.locations.Length)];
                if (!locationRand.Contains(toAddLocation))
                {
                    locationRand.Add(toAddLocation);
                }
            }
            locationRand.Sort();

            //Print locations you can go to
            for (int iterator = 1; iterator <= 3; iterator++)
            {
                Console.SetCursorPosition(Console.LargestWindowWidth / 3, Console.CursorTop + 1);

                Console.Write(iterator + ": " + locationRand.ElementAt(iterator));

            }
            int n = 0;
            while (!int.TryParse(Console.ReadKey().KeyChar.ToString(), out n) || n >= 4)
            {

                Console.SetCursorPosition(0, 7);
                Console.Write("Invalid Selection.");
                Console.SetCursorPosition(0, 6);

            }

            string nextLocation = locationRand[n];

            storyimp(nextLocation);






        }


        public static void storyGenerator()
        {
            Console.Clear();
            Console.SetCursorPosition(Console.LargestWindowWidth / 3, Console.LargestWindowHeight / 3);

            Console.Write("You see a " +
               story.Story.curiousItems[RandomString.newRandom(story.Story.curiousItems.Length)] +
               ", curious you pick it up.");

            Console.SetCursorPosition(Console.LargestWindowWidth / 3, Console.LargestWindowHeight / 3 + 1);

            Console.Write("It " + story.Story.curiousVerbs[RandomString.newRandom(story.Story.curiousVerbs.Length)] + " in your hands!");

            Console.SetCursorPosition(Console.LargestWindowWidth / 3, Console.LargestWindowHeight / 3 + 3);

            Console.Write("The commotion attracts an unwelcome guest, prepare to fight!");


        }

        public static void storyGenerator(string i)
        {
            Console.Clear();

            Console.SetCursorPosition(Console.LargestWindowWidth / 3, Console.LargestWindowHeight / 3);

            Console.Write("On your way to the " + i + " you see a " +
                story.Story.curiousItems[RandomString.newRandom(story.Story.curiousItems.Length)] +
                ", curious you pick it up.");

            Console.SetCursorPosition(Console.LargestWindowWidth / 3, Console.LargestWindowHeight / 3 + 1);

            Console.Write("It " + story.Story.curiousVerbs[RandomString.newRandom(story.Story.curiousVerbs.Length)] + " in your hands!");

            Console.SetCursorPosition(Console.LargestWindowWidth / 3, Console.LargestWindowHeight / 3 + 3);

            Console.Write("The commotion attracts an unwelcome guest, prepare to fight!");


        }
        public static string fightstoryGenerator(string i)
        {
            Console.Clear();

            Console.SetCursorPosition(Console.LargestWindowWidth / 3, Console.LargestWindowHeight / 3);

            string current_story = "";
            Console.Write("On your way to the " + i + " you see a " +
                story.Story.curiousItems[RandomString.newRandom(story.Story.curiousItems.Length)] +
                ", curious you pick it up.");

            Console.SetCursorPosition(Console.LargestWindowWidth / 3, Console.LargestWindowHeight / 3 + 1);

            Console.Write("It " + story.Story.curiousVerbs[RandomString.newRandom(story.Story.curiousVerbs.Length)] + " in your hands!");

            Console.SetCursorPosition(Console.LargestWindowWidth / 3, Console.LargestWindowHeight / 3 + 2);

            Console.Write("Where would you like to explore next?(1,2,3)");
            Console.SetCursorPosition(Console.LargestWindowWidth / 3, Console.LargestWindowHeight / 3 + 3);
            return current_story;

        }
        public static string fightstoryGenerator()
        {
            Console.Clear();
            Console.SetCursorPosition(Console.LargestWindowWidth / 3, Console.LargestWindowHeight / 3);
            string current_story = "";
            Console.Write("On your way to the " + Location.locations[RandomString.newRandom(Location.locations.Length)] + " you see a " +
                          story.Story.curiousItems[RandomString.newRandom(story.Story.curiousItems.Length)] +
                          ", curious you pick it up.");

            Console.SetCursorPosition(Console.LargestWindowWidth / 3, Console.LargestWindowHeight / 3 + 1);

            Console.Write("It " + story.Story.curiousVerbs[RandomString.newRandom(story.Story.curiousVerbs.Length)] + " in your hands!");

            Console.SetCursorPosition(Console.LargestWindowWidth / 3, Console.LargestWindowHeight / 3 + 3);


            Console.Write("Where would you like to explore next?(1,2,3)");
            Console.SetCursorPosition(Console.LargestWindowWidth / 3, Console.LargestWindowHeight / 3 + 4);
            return current_story;

        }
        static string[] curiousItems =
        {
            "hatchet",
            "magnifying glass",
            "complete ham",
            "lecturn",
            "x-ray machine",
            "dirty magazine",
            "chemtrail",
            "Spectacles",
            "Lamp",
            "cell key",
            "large bread",
            "laughing fungus",
            "Cloak of invisibility",
            "sword",
            "Elven chain",
            "Fridge",
            "Universal solvent",
            "book of jokes",
            "toy",
            "bottle of perfume",
            "hair clip",
            "bottle of nail polish",
            "bottle of oil",
            "bottle of sunscreen",
            "ice pick",
            "locket",
            "bandana",
           "packet of seeds"

        };
        static string[] curiousVerbs =
        {
            "explodes",
            "corrodes",
            "coagulates",
            "metastasized",
            "transposes",
            "vacillates",
            "transmogrifies",
            "mutates",
            "transubstantiates",
            "reorganizes",

            "implodes",
            "transforms",
            "disintegrates"

        };

        public class Story
        {
            public static string[] curiousItems =
             {
            "hatchet",
            "magnifying glass",
            "complete ham",
            "lecturn",
            "x-ray machine",
            "dirty magazine",
            "chemtrail",
            "Spectacles",
            "Lamp",
            "Fridge",
            "book of jokes",
            "toy",
            "bottle of perfume",
            "hair clip",
            "bottle of nail polish",
            "bottle of oil",
            "bottle of sunscreen",
            "ice pick",
            "locket",
            "bandana",
           "packet of seeds"

        };
            public static string[] curiousVerbs =
            {
            "explodes",
            "corrodes",
            "implodes",
            "transforms",
            "disintegrates"

        };



        }

    }

}
