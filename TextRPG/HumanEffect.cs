using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class HumanEffect
    {

        // Handle humans effects's implementation
        public static void humanEffectImp(string effect)
        {
            int damage = 0;

            switch (effect)
            {
                case "Burning":


                    damage = CreateMainCharacter.MainCharacter.getATK() / 5 + 1;
                    MonsterGenerator.monster.setHP(MonsterGenerator.monster.getHP() - damage);


                    break;
                case "Stealing":
                    damage = CreateMainCharacter.MainCharacter.getATK() / 6;

                    MonsterGenerator.monster.setHP(MonsterGenerator.monster.getHP() - damage);



                    break;
                case "Lightning Strike":
                    damage = CreateMainCharacter.MainCharacter.getATK() / 5 + CreateMainCharacter.MainCharacter.getATK() % 5;



                    MonsterGenerator.monster.setHP(MonsterGenerator.monster.getHP() - damage);



                    break;
                case "Flaming Sphere":
                    int k;
                    Fight.effectsMainCharacter.TryGetValue("Flaming Sphere", out k);
                    damage = (MonsterGenerator.monster.getATK() / 20) * (6 - k);


                    MonsterGenerator.monster.setHP(MonsterGenerator.monster.getHP() - damage);

                    break;
                case "Sacrifice":

                    int damage_monster = MonsterGenerator.monster.getHP() / 5;
                    int damage_character = CreateMainCharacter.MainCharacter.getHP() / 10;


                    CreateMainCharacter.MainCharacter.setHP(CreateMainCharacter.MainCharacter.getHP() - damage_character);
                    MonsterGenerator.monster.setHP(MonsterGenerator.monster.getHP() - damage_monster);

                    break;
                case "Meteor Shower":
                    Random rand = new Random();
                    bool hit = Convert.ToBoolean(rand.Next(4) / 3);
                    if (hit)
                    {
                        damage = CreateMainCharacter.MainCharacter.getATK() / 2;
                    }
                    else
                    {
                        damage = 0;
                    }


                    MonsterGenerator.monster.setHP(MonsterGenerator.monster.getHP() - damage);

                    break;

                default: break;
            }



        }
    }
}
