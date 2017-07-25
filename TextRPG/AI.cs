using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class AI
    {
        public static int determineSkill()
        {

            int[] record = new int[4];
            int priority = 0;
            int skillPriority = 0;

            for (int i = 0; i < 4; i++)
            {

                string move = Fight.Current_Monster.getMoveName(i);
              
                switch (move)
                {
                    case "Fire Ball":
                        
                        if (!Fight.effectsMainCharacter.Keys.Contains("Burning"))
                        {
                            skillPriority += 2 * (MonsterGenerator.monster.getATK() / 5 + 1);
                        }
                            
                        break;
                    case "Blood Song":
                        
                        if (!Fight.effectsMainCharacter.Keys.Contains("Stealing"))
                        {
                            skillPriority += 6 * (MonsterGenerator.monster.getATK() / 6);
                        }
                        break;
                    case "Lightning Strike":
                     
                        if (!Fight.effectsMainCharacter.Keys.Contains("Lightning Strike"))
                        {
                            skillPriority += (MonsterGenerator.monster.getATK() / 5 + MonsterGenerator.monster.getATK() % 5); ;
                        }
                        break;
                    case "Flaming Sphere":
                        
                        if (!Fight.effectsMainCharacter.Keys.Contains("Flaming Sphere"))
                        {
                            skillPriority += 14 * (MonsterGenerator.monster.getATK() / 20);
                        }
                        break;
                    case "Sacrifice":
                        if (!Fight.effectsMainCharacter.Keys.Contains("Sacrifice"))
                        {
                            skillPriority += (CreateMainCharacter.MainCharacter.getHP() / 5) + (MonsterGenerator.monster.getHP() / 10);
                        }
                        break;
                    case "Meteor Shower":
                        if (!Fight.effectsMainCharacter.Keys.Contains("Meteor Shower"))
                        {
                            skillPriority =   (MonsterGenerator.monster.getATK() / 2);
                        }

                        break;

                    default:
                        skillPriority = 0;
                        break;
                }
                priority = Math.Max(priority, skillPriority);
                
                record[i] = priority;
            }
            for (int i = 0; i < 4; i++)
            {
                if (record[i] == record.Max()) return i; 
            }
            return -1;
        }

    }
}
