using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class MonsterEffect
    {






        // Handle monsters effects's implementation
        public static void monsterEffectImp(string effect)
        {
            int damage = 0;

            switch (effect)
            {
                case "Burning":


                    damage = (MonsterGenerator.monster.getATK() / 5) + 1;
                    CreateMainCharacter.MainCharacter.setHP(CreateMainCharacter.MainCharacter.getHP() - damage);


                    break;
                case "Stealing":
                    damage = MonsterGenerator.monster.getATK() / 6;

                    CreateMainCharacter.MainCharacter.setHP(CreateMainCharacter.MainCharacter.getHP() - damage);


                    break;
                case "Lightning Strike":
                    damage = MonsterGenerator.monster.getATK() / 5 + MonsterGenerator.monster.getATK() % 5;

                    CreateMainCharacter.MainCharacter.setHP(CreateMainCharacter.MainCharacter.getHP() - damage);

                    break;
                case "Flaming Sphere":
                    int k;
                    Fight.effectsMainCharacter.TryGetValue("Flaming Sphere", out k);
                    damage = (MonsterGenerator.monster.getATK() / 20) * (6 - k);


                    CreateMainCharacter.MainCharacter.setHP(CreateMainCharacter.MainCharacter.getHP() - damage);

                    break;
                case "Sacrifice":

                    int damage_monster = MonsterGenerator.monster.getHP() / 10;
                    int damage_character = CreateMainCharacter.MainCharacter.getHP() / 5;

                    CreateMainCharacter.MainCharacter.setHP(CreateMainCharacter.MainCharacter.getHP() - damage_character);
                    MonsterGenerator.monster.setHP(MonsterGenerator.monster.getHP() - damage_monster);

                    break;
                case "Meteor Shower":
                    Random rand = new Random();
                    bool hit = Convert.ToBoolean(rand.Next(4) / 3);
                    if (hit)
                    {
                        damage = MonsterGenerator.monster.getATK() / 2;
                    }
                    else
                    {
                        damage = 0;
                    }



                    CreateMainCharacter.MainCharacter.setHP(CreateMainCharacter.MainCharacter.getHP() - damage);

                    break;

                default: break;
            }

        }


    }
}
