using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
   public class Item
    {

        private  string Name;
        private  int ATK = 0;
        private  int Level;
        private  KeyValuePair<string,string> Effect;
        public  Dictionary<string, string> moveList()
        {


            Dictionary<string, string> moveDict1 = new Dictionary<string, string>();
            moveDict1.Add("Fire Ball", "When " + CreateMainCharacter.MainCharacter.getName() + " uses Fire Ball, it does " + CreateMainCharacter.MainCharacter.getATK() + 1 + " damage. In addition it applies burning for 2 turns (which does " + CreateMainCharacter.MainCharacter.getATK() / 20 + 1 + "damage per turn).");
            moveDict1.Add("Blood Song", "When " + CreateMainCharacter.MainCharacter.getName() + " uses Blood Song, blood is drawn from " + MonsterGenerator.monster.getname() + " stealing " + CreateMainCharacter.MainCharacter.getATK() / 5 + " HP for six turns.");
            moveDict1.Add("Lightning Strike", "When " + CreateMainCharacter.MainCharacter.getName() + " uses Lightning Strike, it does " + MonsterGenerator.monster.getATK() / 5 + CreateMainCharacter.MainCharacter.getATK() % 5 + " damage.");
            moveDict1.Add("Flaming Sphere", "When " + CreateMainCharacter.MainCharacter.getName() + " uses Flaming Sphere, it does " + CreateMainCharacter.MainCharacter.getATK() / 5 + 1 + " damage for five turns.");
            moveDict1.Add("Sacrifice", "When " + CreateMainCharacter.MainCharacter.getName() + " uses Sacrifice, it reduces it's HP by 10 and " + CreateMainCharacter.MainCharacter.getName() + "'s by 20.");
            moveDict1.Add("Meteor Shower", "When " + CreateMainCharacter.MainCharacter.getName() + " uses Meteor Shower, there is a 25 % chance it does " + CreateMainCharacter.MainCharacter.getATK() / 2 + " damage for 4 turns.");

            return moveDict1;

        }
        string[] itemNames =
        {
            "Excalibur",
            "Agnarr",
            "Aila",
            "Alf",
            "Arnborg",
            "Asger",
            "Asta",
            "Baard",
            "Baldur",
            "Bo",
            "Bosse",
            "Brant",
            "Dagfinner",
            "Dusty",
            "Eerik",
            "Eir",
            "Embla",
            "Erlendr",
            "Erling",
            "Even",
            "Freya",
            "Frida",
            "Gerd",
            "Githa",
            "Gittan",
            "Gostav",
            "Grid",
            "Groa",
            "Gull",
            "Gunn",
            "Halldor",
            "Halle",
            "Hallvar",
            "Hel",
            "Hemming",
            "Herta",
            "Hildur",
            "Huld",
            "Idun",
            "Inka",
            "Idunn",
            "Jari",
            "Jerk",
            "Magni",
            "Noll",
            "Odd",
            "Ola",
            "Olha",
            "Olle",
            "Osbourne",
            "Oskar",
            "Osmund",
            "Ragna",
            "Ragnhild",
            "Ralf",
            "Roald",
            "Roar",
            "Rune",
            "Saga",
            "Signy",
            "Siri",
            "Skuld",
            "Steen",
            "Storm",
            "Svana",
            "Tofi",
            "Tore",
            "Torger",
            "Tue",
            "Vidar",
            "Vivi"
        };



        private void setLevel()
        {
            Level =CreateMainCharacter.MainCharacter.getLevel();
        }
        public  int getLevel()
        {
            return Level;
        }

        public void setRandomEffect()
        {
            Random rand = new Random();
          Effect=MonsterGenerator.monster.moves.moveList().ElementAt(rand.Next(0, MonsterGenerator.monster.moves.moveList().Count));
            while (Fight.itemsMainCharacter.Values.Contains(Effect.Key))
            {
                Effect = MonsterGenerator.monster.moves.moveList().ElementAt(rand.Next()% MonsterGenerator.monster.moves.moveList().Count);
            }
        }
        public void setKnownEffect(string name, string description)
        {

            Effect = new KeyValuePair<string, string>(name, description);
        }
        public KeyValuePair<string, string> getEffect()
        {
            return Effect;
        }
        public string getname()
        {
            return Name;
        }

        private void setName()
        {
            Random rand = new Random();
            
            Name = itemNames[rand.Next(itemNames.Length)];
            while (Fight.itemsMainCharacter.ContainsKey(Name))
                {
                Name = itemNames[rand.Next() % itemNames.Length];
                }
          
        }
        public void setName(string a)
        {

            Name = a;
        }
        public  int getATK()
        {
            return ATK;
        }
        private void setATK()
        {
            ATK = CreateMainCharacter.MainCharacter.getLevel();
        }

        public void setATK(int x)
        {
            ATK = x;
        }
        public  void createItem()
        {
           
            setATK();
            setLevel();
            setName();
            setRandomEffect();

            
        }

    }
}
