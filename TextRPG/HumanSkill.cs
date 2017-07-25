using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class HumanSkill
    {

        // Handles  Humans skill's implementation
        public static void humanSkillImp(string skill, int weaponInt)
        {
            //damage dealing            
            int damage = 0;
            switch (weaponInt)
            {
                case 0:
                    damage = Fight.weapon1.getATK() + CreateMainCharacter.MainCharacter.getATK() / 2;
                    break;
                case 1:
                    damage = Fight.weapon2.getATK() + CreateMainCharacter.MainCharacter.getATK() / 2;
                    break;
                case 2:
                    damage = Fight.weapon3.getATK() + CreateMainCharacter.MainCharacter.getATK() / 2;
                    break;
                case 3:
                    damage = Fight.weapon4.getATK() + CreateMainCharacter.MainCharacter.getATK() / 2;
                    break;
                default:
                    break;
            }
            MonsterGenerator.monster.setHP(MonsterGenerator.monster.getHP() - damage);


            switch (skill)
            {

                case "Fire Ball":

                    if (!Fight.effectsMonsterCharacter.ContainsKey("Burning"))
                    {
                        Fight.effectsMonsterCharacter.Add("Burning", 2);
                    }
                    break;
                case "Blood Song":


                    if (!Fight.effectsMonsterCharacter.ContainsKey("Stealing"))
                    {
                        Fight.effectsMonsterCharacter.Add("Stealing", 6);
                    }
                    break;
                case "Lightning Strike":

                    if (!Fight.effectsMonsterCharacter.ContainsKey("Lightning Strike"))
                    {
                        Fight.effectsMonsterCharacter.Add("Lightning Strike", 1);
                    }
                    break;
                case "Flaming Sphere":
                    if (!Fight.effectsMonsterCharacter.ContainsKey("Flaming Sphere"))
                    {
                        Fight.effectsMonsterCharacter.Add("Flaming Sphere", 5);
                    }
                    break;
                case "Sacrifice":
                    if (!Fight.effectsMonsterCharacter.ContainsKey("Sacrifice"))
                    {
                        Fight.effectsMonsterCharacter.Add("Sacrifice", 1);
                    }
                    break;
                case "Meteor Shower":
                    if (!Fight.effectsMonsterCharacter.ContainsKey("Meteor Shower"))
                    {
                        Fight.effectsMonsterCharacter.Add("Meteor Shower", 4);
                    }
                    break;

                default: break;
            }

        }

    }
}
