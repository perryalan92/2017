using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextRPG
{
    class Fight
    {
        //monster currently being fought
        public static MonsterGenerator.monster Current_Monster = new MonsterGenerator.monster();
        //way to track monster effect status
        public static Dictionary<string, int> effectsMonsterCharacter = new Dictionary<string, int>();
        //way to track main characters effect status
        public static Dictionary<string, int> effectsMainCharacter = new Dictionary<string, int>();
        //way to track items
        public static Dictionary<string, string> itemsMainCharacter = new Dictionary<string, string>();
        public static int[] itemAtk = new int[4];
        public static Item weapon1 = new Item();
        public static Item weapon2 = new Item();
        public static Item weapon3 = new Item();
        public static Item weapon4 = new Item();


        public static void fightMethod()
        {

            Current_Monster.create();
            effectsMonsterCharacter.Clear();
            effectsMainCharacter.Clear();
            CreateMainCharacter.MainCharacter.setHP(100);
            while (CreateMainCharacter.MainCharacter.getHP() > 0

                && MonsterGenerator.monster.getHP() > 0)
            {
                Console.Clear();

                displayFightScreen();
                Console.SetCursorPosition(0, 0);

                //handle input
                ConsoleKeyInfo command = Console.ReadKey();
                string comChar = command.KeyChar.ToString();
                Console.WriteLine(comChar);
                switch (comChar)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine(MonsterGenerator.monster.getMoveDescription(0));
                        Console.WriteLine();
                        Console.Write("Press any key to return to fight");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine(MonsterGenerator.monster.getMoveDescription(1));
                        Console.WriteLine();
                        Console.Write("Press any key to return to fight");

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine(MonsterGenerator.monster.getMoveDescription(2));
                        Console.WriteLine();
                        Console.Write("Press any key to return to fight");

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine(MonsterGenerator.monster.getMoveDescription(3));
                        Console.WriteLine();
                        Console.Write("Press any key to return to fight");

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "q":
                        Console.SetCursorPosition(0, 0);
                        HumanSkill.humanSkillImp(itemsMainCharacter.ElementAt(0).Value, 0);
                        Console.Clear();
                        break;
                    case "w":
                        if (itemsMainCharacter.Count >= 2)
                        {
                            HumanSkill.humanSkillImp(itemsMainCharacter.ElementAt(1).Value, 1);
                            Console.Clear();
                        }
                        break;
                    case "e":
                        if (itemsMainCharacter.Count >= 3)
                        {
                            HumanSkill.humanSkillImp(itemsMainCharacter.ElementAt(2).Value, 2);
                            Console.Clear();
                        }
                        break;
                    case "r":
                        if (itemsMainCharacter.Count >= 4)
                        {

                            HumanSkill.humanSkillImp(itemsMainCharacter.ElementAt(3).Value, 3);
                            Console.Clear();
                        }
                        break;
                    default:
                        Console.Clear();
                        break;
                }

                //monster uses skill
                MonsterSkill.monsterSkillImp(Current_Monster.getMoveName(AI.determineSkill()));


                //implement conditions
                foreach (KeyValuePair<string, int> s in effectsMonsterCharacter)
                {

                    HumanEffect.humanEffectImp(s.Key);

                }
                foreach (KeyValuePair<string, int> s in effectsMainCharacter)
                {
                    MonsterEffect.monsterEffectImp(s.Key);
                }

                string[] monsterKeys = effectsMonsterCharacter.Keys.ToArray<string>();
                for (int i = 0; i < monsterKeys.Length; i++)
                {
                    effectsMonsterCharacter[monsterKeys[i]] = effectsMonsterCharacter[monsterKeys[i]] - 1;

                }
                string[] characterKeys = effectsMainCharacter.Keys.ToArray<string>();
                for (int i = 0; i < characterKeys.Length; i++)
                {
                    effectsMainCharacter[characterKeys[i]] = effectsMainCharacter[characterKeys[i]] - 1;
                }

                for (int i = 0; i < effectsMonsterCharacter.Count; i++)
                {
                    if (effectsMonsterCharacter.ElementAt(i).Value == 0)
                    {
                        effectsMonsterCharacter.Remove(effectsMonsterCharacter.ElementAt(i).Key);
                    }
                }
                for (int i = 0; i < effectsMainCharacter.Count; i++)
                {
                    if (effectsMainCharacter.ElementAt(i).Value == 0)
                    {
                        effectsMainCharacter.Remove(effectsMainCharacter.ElementAt(i).Key);
                    }
                }





            }
            if (MonsterGenerator.monster.getHP() <= 0)
            {
                Reward.reward();
                story.storyimp();
            }
            if (CreateMainCharacter.MainCharacter.getHP() <= 0)
            {
                CreateMainCharacter.getPreference();
            }



        }



        public static void displayFightScreen()
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);


            //Monster LVL
            Console.SetCursorPosition(0, 0);
            Console.Write("LVL : " + MonsterGenerator.monster.getLevel());

            //Monster HP
            Console.SetCursorPosition(10, 0);
            Console.Write("HP : " + MonsterGenerator.monster.getHP());

            //Monster ATK
            Console.SetCursorPosition(20, 0);
            Console.Write("ATK : " + MonsterGenerator.monster.getATK());

            //Monster DEF
            Console.SetCursorPosition(30, 0);
            Console.Write("DEF : " + MonsterGenerator.monster.getDEF());

            //Monster SPC
            Console.SetCursorPosition(40, 0);
            Console.Write("SPC : " + MonsterGenerator.monster.getSPC());

            //Draw Monster's face
            Console.SetCursorPosition(0, 1);
            foreach (string s in Current_Monster.getface())
            {
                Console.WriteLine(s);
            }

            //Write monster skills
            for (int i = 0; i < 4; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(i + 1 + ": ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(Current_Monster.getMoveName(i) + "\t");
            }

            //draw items
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.White;



            Console.SetCursorPosition(90, 5);
            Console.Write("Items");

            Console.SetCursorPosition(82, 7);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Q");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(84, 7);
            if (itemsMainCharacter.Count == 0)
            {

                weapon1.createItem();
                weapon1.setRandomEffect();
                itemAtk[0] = CreateMainCharacter.MainCharacter.getLevel();
                weapon1.setATK(itemAtk[0]);
                itemsMainCharacter.Add(weapon1.getname(), weapon1.getEffect().Key);
                Console.Write(itemsMainCharacter.First().Key + ": " + itemsMainCharacter.First().Value);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(109, 7);
                Console.Write(weapon1.getATK());
                Console.ForegroundColor = ConsoleColor.White;





            }
            else
            {
                Console.Write(itemsMainCharacter.First().Key + ": " + itemsMainCharacter.First().Value);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(109, 7);
                Console.Write(itemAtk[0]);
                Console.ForegroundColor = ConsoleColor.White;
            }


            Console.SetCursorPosition(82, 9);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("W");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(84, 9);
            if (itemsMainCharacter.Count >= 2)
            {
                Console.Write(itemsMainCharacter.ElementAt(1).Key + ": " + itemsMainCharacter.ElementAt(1).Value);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(109, 9);
                Console.Write(itemAtk[1]);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                weapon2.createItem();
                weapon2.setRandomEffect();
                itemAtk[1] = CreateMainCharacter.MainCharacter.getLevel();
                weapon2.setATK(itemAtk[1]);
                itemsMainCharacter.Add(weapon2.getname(), weapon2.getEffect().Key);
                Console.Write(itemsMainCharacter.ElementAt(1).Key + ": " + itemsMainCharacter.ElementAt(1).Value);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(109, 9);
                Console.Write(weapon2.getATK());
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.SetCursorPosition(82, 11);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("E");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(84, 11);
            if (itemsMainCharacter.Count >= 3)
            {
                Console.Write(itemsMainCharacter.ElementAt(2).Key + ": " + itemsMainCharacter.ElementAt(2).Value);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(109, 11);
                Console.Write(itemAtk[2]);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                weapon3.createItem();
                weapon3.setRandomEffect();
                itemAtk[2] = CreateMainCharacter.MainCharacter.getLevel();
                weapon3.setATK(itemAtk[2]);
                itemsMainCharacter.Add(weapon3.getname(), weapon3.getEffect().Key);
                Console.Write(itemsMainCharacter.ElementAt(2).Key + ": " + itemsMainCharacter.ElementAt(2).Value);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(109, 11);
                Console.Write(weapon3.getATK());
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.SetCursorPosition(82, 13);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("R");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(84, 13);
            if (itemsMainCharacter.Count >= 4)
            {
                Console.Write(itemsMainCharacter.ElementAt(3).Key + ": " + itemsMainCharacter.ElementAt(3).Value);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(109, 13);
                Console.Write(itemAtk[3]);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                weapon4.createItem();
                weapon4.setRandomEffect();
                itemAtk[3] = CreateMainCharacter.MainCharacter.getLevel();
                weapon4.setATK(itemAtk[3]);
                itemsMainCharacter.Add(weapon4.getname(), weapon4.getEffect().Key);
                Console.Write(itemsMainCharacter.ElementAt(3).Key + ": " + itemsMainCharacter.ElementAt(3).Value);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(109, 13);
                Console.Write(weapon4.getATK());
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            //Draw Effects

            drawBox(80, 17, 32, 1 + effectsMainCharacter.Count, '\uccb8');
            Console.SetCursorPosition(82, 18);
            Console.Write("Cond.");
            Console.SetCursorPosition(90, 18);
            Console.Write("Dam./Turn");
            Console.SetCursorPosition(102, 18);
            Console.Write("Turns Left");
            for (int i = 1; i <= effectsMainCharacter.Count; i++)
            {
                Console.SetCursorPosition(82, 18 + i);
                Console.Write(effectsMainCharacter.ElementAt(i - 1).Key);
                Console.SetCursorPosition(98, 18 + i);
                switch (effectsMainCharacter.ElementAt(i - 1).Key)
                {
                    case "Burning":
                        Console.Write(CreateMainCharacter.MainCharacter.getATK() + 1);
                        break;
                    case "Stealing":
                        Console.Write(CreateMainCharacter.MainCharacter.getATK() / 5);

                        break;
                    case "Lightning Strike":
                        Console.Write(CreateMainCharacter.MainCharacter.getATK() + CreateMainCharacter.MainCharacter.getATK() % 5);
                        break;
                    case "Flaming Sphere":
                        int k;
                        effectsMainCharacter.TryGetValue("Flaming Sphere", out k);
                        Console.Write((MonsterGenerator.monster.getATK() / 20) * (6 - k));
                        break;
                    case "Sacrifice":
                        Console.Write("10%");

                        break;
                    case "Meteor Shower":

                        Console.Write(CreateMainCharacter.MainCharacter.getATK() / 2);
                        break;
                    default: break;
                }
                Console.SetCursorPosition(102, 18 + i);
                Console.Write(effectsMainCharacter.ElementAt(i - 1).Value);
            }

            //Draw Monster effects
            drawBox(4, 40, 64, 1 + effectsMonsterCharacter.Count, '\uccb8');
            Console.SetCursorPosition(6, 41);
            Console.Write("Condition");
            Console.SetCursorPosition(30, 41);
            Console.Write("Damage Per Turn");
            Console.SetCursorPosition(57, 41);
            Console.Write("Turns Left");
            for (int i = 1; i <= effectsMonsterCharacter.Count; i++)
            {
                Console.SetCursorPosition(6, 41 + i);
                Console.Write(effectsMonsterCharacter.ElementAt(i - 1).Key);
                Console.SetCursorPosition(30, 41 + i);
                switch (effectsMonsterCharacter.ElementAt(i - 1).Key)
                {
                    case "Burning":
                        Console.Write(CreateMainCharacter.MainCharacter.getATK() + 1);
                        break;
                    case "Stealing":
                        Console.Write(CreateMainCharacter.MainCharacter.getATK() / 5);

                        break;
                    case "Lightning Strike":
                        Console.Write(CreateMainCharacter.MainCharacter.getATK() + CreateMainCharacter.MainCharacter.getATK() % 5);
                        break;
                    case "Flaming Sphere":
                        Console.Write(CreateMainCharacter.MainCharacter.getATK() / 5 + 1);
                        break;
                    case "Sacrifice":
                        Console.Write("20%");

                        break;
                    case "Meteor Shower":

                        Console.Write(CreateMainCharacter.MainCharacter.getATK() / 2);
                        break;
                    default: break;
                }
                Console.SetCursorPosition(57, 41 + i);
                Console.Write(effectsMonsterCharacter.ElementAt(i - 1).Value);
            }
            drawBox(80, 6, 31, 1, '\uccb8');
            drawBox(80, 8, 31, 1, '\uccb8');
            drawBox(80, 10, 31, 1, '\uccb8');
            drawBox(80, 12, 31, 1, '\uccb8');


            //draw character stats

            Console.SetCursorPosition(80, 1);
            Console.Write("Name:" + CreateMainCharacter.MainCharacter.getName());
            Console.SetCursorPosition(86 + CreateMainCharacter.MainCharacter.getName().Length, 1);
            Console.Write("LVL:" + CreateMainCharacter.MainCharacter.getLevel());
            Console.SetCursorPosition(92 + CreateMainCharacter.MainCharacter.getName().Length + CreateMainCharacter.MainCharacter.getLevel().ToString().Length, 1);
            Console.Write("HP:" + CreateMainCharacter.MainCharacter.getHP());
            Console.SetCursorPosition(90 + CreateMainCharacter.MainCharacter.getATK().ToString().Length + CreateMainCharacter.MainCharacter.getSPC().ToString().Length, 3);
            Console.Write("SPC:" + CreateMainCharacter.MainCharacter.getSPC());
            Console.SetCursorPosition(85 + CreateMainCharacter.MainCharacter.getATK().ToString().Length, 3);
            Console.Write("DEF:" + CreateMainCharacter.MainCharacter.getDEF());
            Console.SetCursorPosition(80, 3);
            Console.Write("ATK:" + CreateMainCharacter.MainCharacter.getATK());
        }


        // Draw a Box in Console
        public static void drawBox(int x, int y, int width, int height, char border)
        {

            Console.SetCursorPosition(x, y);
            for (int i = 0; i <= height + 1; i++)
            {
                if (i == 0 || i == height + 1)
                {
                    for (int j = 0; j <= width; j++)
                    {
                        Console.Write(border);
                    }
                }
                else
                {
                    Console.Write(border);
                    Console.SetCursorPosition(x + width + 1, y + i);
                    Console.Write(border);
                }
                Console.SetCursorPosition(x, y + i + 1);
            }
        }

    }
    }

    



