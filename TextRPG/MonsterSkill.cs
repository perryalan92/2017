using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class MonsterSkill
    {


        // Handles  monsters skill's implementation
        public static void monsterSkillImp(string skill)
        {
            int itemAtkAverage = (Fight.weapon1.getATK() + Fight.weapon2.getATK() + Fight.weapon3.getATK() + Fight.weapon4.getATK()) / 4;
            int damage = MonsterGenerator.monster.getATK() / 2 + itemAtkAverage;
            CreateMainCharacter.MainCharacter.setHP(CreateMainCharacter.MainCharacter.getHP() - damage);
            switch (skill)
            {

                case "Fire Ball":
                    if (!Fight.effectsMainCharacter.ContainsKey("Burning"))
                    {
                        Fight.effectsMainCharacter.Add("Burning", 2);
                    }
                    break;
                case "Blood Song":
                    if (!Fight.effectsMainCharacter.ContainsKey("Stealing"))
                    {
                        Fight.effectsMainCharacter.Add("Stealing", 6);
                    }
                    break;
                case "Lightning Strike":
                    if (!Fight.effectsMainCharacter.ContainsKey("Lightning Strike"))
                    {
                        Fight.effectsMainCharacter.Add("Lightning Strike", 1);
                    }
                    break;
                case "Flaming Sphere":
                    if (!Fight.effectsMainCharacter.ContainsKey("Flaming Sphere"))
                    {
                        Fight.effectsMainCharacter.Add("Flaming Sphere", 5);
                    }
                    break;
                case "Sacrifice":
                    if (!Fight.effectsMainCharacter.ContainsKey("Sacrifice"))
                    {
                        Fight.effectsMainCharacter.Add("Sacrifice", 1);
                    }
                    break;
                case "Meteor Shower":
                    if (!Fight.effectsMainCharacter.ContainsKey("Meteor Shower"))
                    {
                        Fight.effectsMainCharacter.Add("Meteor Shower", 4);
                    }
                    break;

                default: break;
            }

        }

    }
}
