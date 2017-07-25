using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TextRPG
{
   public class Reward
    {
        public static void reward()
        {
            CreateMainCharacter.MainCharacter.setLevel(CreateMainCharacter.MainCharacter.getLevel() + 1);
            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth / 2) - 5, 1);
            Console.Write("Congratulations!");



            //item
            Item newItem = new Item();
            newItem.createItem();
            newItem.setATK(CreateMainCharacter.MainCharacter.getLevel());
            Console.SetCursorPosition((Console.WindowWidth / 4) - 5, 3);
            Console.Write("The Monster dropped ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(newItem.getname());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("! Which skill");
            Console.SetCursorPosition((Console.WindowWidth / 4) - 5, 4);
            Console.Write("would you like to imbue it with?");


            Fight.drawBox((Console.WindowWidth / 4) - 5, 6, 31, 4, '\uccb8');
            for (int i = 0; i < 4; i++) {
                Console.SetCursorPosition((Console.WindowWidth / 4) - 4, 7 + i);
                if (i < MonsterGenerator.monster.MonsterMoveList.Count)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write((i + 1) + ": ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(MonsterGenerator.monster.MonsterMoveList.ElementAt(i).Key);
                }
                 }
            ConsoleKeyInfo input = Console.ReadKey();

            int x=0 ;

            while(!char.IsDigit(input.KeyChar))
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("Invalid Selection, Please 1, 2, 3, or 4.");

                input = Console.ReadKey();

            }

            x = int.Parse(input.KeyChar.ToString());
    
                switch (x)
                {
                    case 1:
                    newItem.setKnownEffect(MonsterGenerator.monster.MonsterMoveList.ElementAt(0).Key,
                 newItem.moveList()[MonsterGenerator.monster.MonsterMoveList.ElementAt(0).Key]
                     );

                    break;
                    case 2:
                        newItem.setKnownEffect(MonsterGenerator.monster.MonsterMoveList.ElementAt(1).Key,
                     newItem.moveList()[MonsterGenerator.monster.MonsterMoveList.ElementAt(1).Key]
                     );
                    break;
                    case 3:
                        newItem.setKnownEffect(MonsterGenerator.monster.MonsterMoveList.ElementAt(2).Key,
                     newItem.moveList()[MonsterGenerator.monster.MonsterMoveList.ElementAt(2).Key]
                     );
                    break;
                    case 4:
                        newItem.setKnownEffect(MonsterGenerator.monster.MonsterMoveList.ElementAt(3).Key,
                     newItem.moveList()[MonsterGenerator.monster.MonsterMoveList.ElementAt(3).Key]
                     );
                    break;
                    default:
                    x = int.Parse(Console.ReadKey().ToString());
                        break;
                }
            
            if (Fight.itemsMainCharacter.Count < 4)
            {
                Fight.itemsMainCharacter.Add(newItem.getname(), newItem.getEffect().Key);

                if (Fight.itemsMainCharacter.Count == 2) { Fight.itemAtk[1] = CreateMainCharacter.MainCharacter.getLevel(); }
                else if (Fight.itemsMainCharacter.Count == 3) { Fight.itemAtk[2] = CreateMainCharacter.MainCharacter.getLevel(); }
                else if (Fight.itemsMainCharacter.Count == 4) { Fight.itemAtk[3] = CreateMainCharacter.MainCharacter.getLevel(); }
            }
            else
            {
                Console.SetCursorPosition((Console.WindowWidth / 4) + 35, 4);
                Console.Write("Replace which Weapon?");
                Fight.drawBox((Console.WindowWidth / 4) + 31, 6, 31, 4, '\uccb8');
                for(int i = 0; i < 4; i++)
                {
                    Console.SetCursorPosition((Console.WindowWidth / 4) + 32, 7 + i);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(i + 1 + " ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(Fight.itemsMainCharacter.ElementAt(i).Key +": "+ Fight.itemsMainCharacter.ElementAt(i).Value);

                }
  

                int y = 0;

                while (!int.TryParse(Console.ReadKey().KeyChar.ToString(), out y))
                {
                    Console.SetCursorPosition(0, 0);
                    Console.Write("Invalid Selection, Please 1, 2, 3, or 4.");
                    

                }

                y = y -1;

              Fight.itemAtk[y]=CreateMainCharacter.MainCharacter.getLevel(); 

                Fight.itemsMainCharacter.Remove(Fight.itemsMainCharacter.ElementAt(y).Key);
                Fight.itemsMainCharacter.Add(newItem.getname(),newItem.getEffect().Key );
            }

            //attributes

            Console.SetCursorPosition((Console.WindowWidth / 4) + 67, 4);
            Console.Write("You also get 3 Attribute points!");
            Fight.drawBox((Console.WindowWidth / 4) + 63, 6, 31, 4, '\uccb8');

            Console.SetCursorPosition((Console.WindowWidth / 4) + 64, 7);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("1: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("ATK " + CreateMainCharacter.MainCharacter.getATK());

            Console.SetCursorPosition((Console.WindowWidth / 4) + 64, 8);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("2: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("DEF " + CreateMainCharacter.MainCharacter.getDEF());

            Console.SetCursorPosition((Console.WindowWidth / 4) + 64, 9);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("3: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("SPC " + CreateMainCharacter.MainCharacter.getSPC());

            int t;
            
            for(int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition((Console.WindowWidth / 4) + 71 + 2 * i, 10);
                while (!int.TryParse(Console.ReadKey().KeyChar.ToString(), out t))
                {
                    Console.SetCursorPosition(0, 0);
                    Console.Write("Invalid Selection, Please 1, 2, 3, or 4.");
                }

                switch (t) {
                    case 1:
                        CreateMainCharacter.MainCharacter.setATK(CreateMainCharacter.MainCharacter.getATK() + 1);
                        Console.SetCursorPosition((Console.WindowWidth / 4) + 71, 7);
                        Console.Write("    ");
                        Console.SetCursorPosition((Console.WindowWidth / 4) + 71, 7);
                        Console.Write(CreateMainCharacter.MainCharacter.getATK());
                    break;
                    case 2:
                        CreateMainCharacter.MainCharacter.setDEF(CreateMainCharacter.MainCharacter.getDEF() + 1);
                        Console.SetCursorPosition((Console.WindowWidth / 4) + 71, 8);
                        Console.Write("    ");
                        Console.SetCursorPosition((Console.WindowWidth / 4) + 71, 8);
                        Console.Write(CreateMainCharacter.MainCharacter.getDEF());
                        break;
                    case 3:
                        CreateMainCharacter.MainCharacter.setSPC(CreateMainCharacter.MainCharacter.getSPC() + 1);
                        Console.SetCursorPosition((Console.WindowWidth / 4) + 71, 9);
                        Console.Write("    ");
                        Console.SetCursorPosition((Console.WindowWidth / 4) + 71, 9);
                        Console.Write(CreateMainCharacter.MainCharacter.getSPC());
                        break;
                    default:
                        break;
                }

            }
            System.Threading.Thread.Sleep(200);

            Fight.story.storyimp();
        }




    }
}
