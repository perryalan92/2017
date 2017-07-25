using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG;

namespace TextRPG
{
    public  class MonsterGenerator
    {

        public static string[] monsterNames =
        {
            "Venom",
            "Cave Crawler",
            "Goblin",
            "Goob"
        };


        public class faceGenerate
        {




            public static List<string[]> generate()
            { 


                  String[] cave_crawler ={
",,,,,,,,,,,,,,,,,,,,,,:,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,:,,,,,,:,,",
",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,:,,,,,,,,,,,,,,,:,,,,,,:,,,:",
",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,:~,,,,,,,,,,:,:",
",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,::= III,:,,,,,,,,,,:,,,~:",
",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,+= +~:~~= I +::,,,,,,,,,,,,:",
",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,== ~:~=::::::~=::,,,,,,,,,,:,,,",
",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,~:~= ~~:,:,,,:::~~+,,,,,,,,,,,::,,",
",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,~~~~:= ~~~::,,:,~~:~~=,,,,,,,,,,,,,::",
",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,::~:::~~~=:~::::~~:::~== ~:,:,:=,,,,,,,::",
",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,:,,= ~:=:== ~~:::~~~::.,::~,,,,::,,,,,,,,::",
",,,,,,,,,,,,,,,,,,,,,,,,,,,,,:,,,,,,:=:::~== ~= ~~~~~~:::::,,::,,,,::::,,,,:,=::",
",,,,,,,,,,,,,,,,,,,,,,:,,,,,:+::,,~~~,::+= ~= ~~~:~~:,,::,,,:,,,,,,::,::,,I,,,=:",
",,,,,,,,,,,,,,,,,,,,,,,,,,,::::~:,,,::= ~= ~~~:~~=:,...,,,,,,,,,:,,:,,,::,,,::~,",
",,,,,,,,,,,,,,,,,,,,,,,,,,,,~+,=,.,:::~+==:~~:,,.:...,,,:~::,:::+,,,,:~:,::,,:,:",
",,,,,,,,,,,,,,,,,,,,,,,,,,:::== ~+,,~:,~= ~==,,,,:.....:::,,::::::,::~~=,:~::,=,",
",,,,,,,,,,,,,,,,,,,,,,,,,,,,,:= ~,,~::::~:,,.,.......+:+,,:::::,,::::::+:,,::::=",
",,,,,,,,,,,,,,,,,,,,,,,,,,::,=:=::~::::,:,:......,...~:?:,:+:~,,,,::::,:~::+,,=:",
",,,,,,,,,,,,,,,,,,,,,,,,::,,+= ~~~:= ~,,.........,.,~:.,.,,~~+:,,,:,I: +:::,,:,,",
",,,,,,,,,,,,,,,,,,,,,,,::,,~:I~==:,,,,......,,,,,:,:,...,=,= ~,~::~,=,::,,:I:,,,",
",,,,,,,,,,,,,,,,,,,,,,=:=:,,,+=+=:,,..,:,,:....,,,:::,..,,::~~? ~::~=,:=:,,:7,,:",
",,,,,,,,,,,,,,,,,,,,,,,:,== ~,+~== ~:~~~:,,,,,:,~,.,~,,....,:,,:==?: I::+:::= +:",
",,,,,,,,,,,,,,,,,,,,,,,,:+~?::+::+ ~:== ~~:::,,:,~:::= ~:....,,:,,,+::I:,,:+I7,,",
",,,,,,,,,,,,,,,,,,,,,,,,~::,::=::,:~~~~~,:~~:::,::,,:= ~~..,,,,::,:+,= +,+7:::~=",
",,,,,,,,,,,,,,,,,,,,,,,:::,,,,:~:,,:~== ~=,~~:~::::~:~,+~~,:,~,,,:+:I,+?,:=:+~::",
",,,,,,,,,,,,,,,,,,,,,,,,,,,,::~,,,,:::~+~=:~~~:~:::~:=,= ~+,:,+,,,=?== I ??:,,:+",
",,,,,,,,,,,,,,,,,,,,,,,~,:::::,?:,:,,,,::+=?== ~::::: ~::~~:~==== ~= ~++= 7 ?=,,",
",,,,,,,,,,,,,,,,,,,,,,::~~::~,=:..~77 ?=? ++== ~= ++~~::::::::::,,::= ~~~:==,+,:",
",,,,,,,,,,,,,,,,,,,,,:::~:~::~:+~.,I ??? ~~: ~:~~=???+= ~::::,:,,,,,,,::~~~,:,,~",
",,,,,,,,,,,,,,,,,,,,,::~:~:,==:==,,=====:=::=+== +I === ~::::,:,,,,,:,,:~~,,:=:,",
",,,,,,,,,,,,,,,,,,,,,,:~~:~:~:::::,= ~~+:~,~=:,:?+~~=:,,:,,,:,,,,,,,,:::,=,~=,,:",
",,,,,,,,,,,,,,,,,,,,,,,,:,~+~==:~:::=?+= ~= ~+~~: ~= ~+~:,,~=,,,,,,,,~=,= ~+::,~",
",,,,,,,,,,,,,,,,,,,,,,,,::::~= +,~= ++++== ~+= ~~~~==,::,,,::,,,:,,,,,,:,,+=,,~,",
",,,,,,,,,,,,,,,,,,,,,,,,~+= +::~~,,::~+~+=== ~= ++=:,:,,,::::,,,:,:::,,:,,,,,,,,",
",,,,,,,,,,,,,,,,,,,,,,,~:?~~=+= +~:,,::,~++?? +:,~~~~,,,,,,:::,:,::,,,,:,,:,,,,,",
",,,,,,,,,,,,,,,,,,,,,,,= +:=:~++= ~:,,:~::=:?+=:~=:=,,:,,,:+:::,,,:?::,,:,,,,,,,",
};

                string[] vemom =
                {
            "                                              . .  ........                     ",
            "                                            .,.... ....:.. ,.                   ",
            "                                  .       ,...    .    ,,...,~...               ",
            "                         .  . ....... .,,.. ,     .... .....,.,,:...            ",
            "                              ..,.:.... ... ......   .. , :....,.:,,=:.         ",
            "                              ..,..,    ,,..: .. . .. ......::.....:,.+,        ",
            "                               .,.. . ......: ....   ...,.. ....:,:,..~=+..     ",
            "                             ....,.   .  .....~,., ,..,,~:.:..::..=:,,~~=~...   ",
            "  .        . .    ..  ....... ..~..   ......,....,I$+=~=,:~:::..,:.,~~.,~+~:.   ",
            "                  .            .7.,.     .......,$:~$?=~I==:~..,.:,:~.~:~:?I..  ",
            "                            ...=+..  . .  ..,=I+~,$?~I+:=:,~.,...,.,.,:~.:,==.. ",
            "                           ..=$I...    . ...7?7?.:ZI?+=++=.:..,,...:,~,~,=~??:..",
            "                         .. ,... .     .. ...=?.,I?I?::=+=:.::..=,~.,~~:~=~=+.. ",
            "                          ..,.~,.,...... ...,~7+==,,=?:?+=.::.,,.:,,:~,,?,===.. ",
            "                            ?7~~?I=7++?~7?.?+~7::~=.?=?.?+~,.:,,:,,~:~~:=:=+=.. ",
            "                           .=I7:?+,++=~~+=7~=?,7.=.,,:~::I~~~=:=:,:=:==::?:+=. .",
            "                           .I,7II..==~?+7++?~:=7~I~..::::?I?~~:~=~~~~?::+~:?: . ",
            "                   .        ?,.7~~.III=I7I:??=:~?=?~,...,.,=:++==?~==~~+=+=?.   ",
            "           .                ...:...,: ....,....=.+,=::.,.,,$?++:+==+++=I:I+,... ",
            "                              ..             ....,.,+~...,,7I?I?+?=I?++$~.,  .. ",
            "                                               .  ..:?:~..,ZI+7?ZZ7I7$?,.       ",
            "                                                 ..,,,,,.,,$I7~??II+$$~,...     ",
            "             .  .    ..     .......... .. ... ......::+:?,,I++,I===I?I?I...     ",
            "                                  .....         . ..,:+,+,+:?+~?+:=~~~=I..  .   ",
            "  .:+:.=..                                      .. ..,+~+?:=7Z+~++~:?==~$~,     ",
            " .......~,:.                                     ..,..:=++,,=?$~~++~.:=,?+?~..  ",
            "        ...,,.  .                        ......~,~:.:,.=?$.,==$I=?=.::+=~,=,~.. ",
            "           .:.,.               ... ....~~:?7III+?~III.,,7=:~:=I+=$=~:,,~:,.:,,+.",
            "             .,..            .    .+~~~=??I+,..,=+=7+.,:.,.~.=?++=7+=~=,,~,,~.,.",
            "               ..=              .,:~~?.   .. ..III:?=~+I=.+=?+,+I==+++:~~~~ ~.:,",
            "                .:,:..      ...,~?+=.   :..7:+?=~?+.$I~+=+~~++==~I,+=~:,........",
            "                 ...~==,..=I:::==...... ?+7+I+7?..I+=~,:?~,=+=+++:?.I=... .. .. ",
            "                     ....:~..... ....,I=I+??~7~+?..~?:::~:?$?I7+=~.,..        . ",
            "            ..                     =,???+....$I+~:..,.,~7+I+?+~I:,....          ",
            "         .                        .....I==+++..:,,=~?:$7++~,+=,=,... . .        ",
            "         ..                       . ...~+?~=,,..~~:.   ??+~~=,~~...    .        ",
            "                                       . . .,+?~=.      =I+~~~,,.               "};

               String[] Goblin =

{
"                                                                               ",
"                                                                               ",
"                                                                               ",
"                             .M,NMOMMMMMM8M                                     ",
"                          8.M                MN                                 ",
"                         M                     ~                                ",
"                       M                         M                              ",
"                      M                           M,                            ",
"                     M                             M                            ",
"           MD+       D                             8=   .ND                     ",
"            .  ,M$  M,                         O    8.M  M                      ",
"              M   D M     ,  ~                      MN.                         ",
"               M    N$                        ~     M   M                       ",
"                , MM M        Z              N      ~  :                        ",
"                 ~ M.      O7 ZM     M ,    MO  D   M  :                        ",
"                  M M      .M   .M,  M  MM      D     MM                        ",
"                  NM MN      MM= ~M        MMMD    M  +                         ",
"                 $              M               ~  M  8                         ",
"                   M   D           +Z   O$       M MM                           ",
"                  DM M?MM  Z      8$     .M   .O+  M                            ",
"                       M~   MM=   .  M     $M: M   M                            ",
"                       M ?   M    .           I?   +                            ",
"                       M.M    ~8M           N M    M                            ",
"                      .M8D     M +M          M    O                             ",
"                      M  M ~     M          M     M                             ",
"                      M    8       MMMMMMMM      $                              ",
"                     MM     M                   M M                             ",
"                    M M       M       M      . M  M.IM                          ",
"                   M           MM            M=    M +N                         ",
"                 M8             M   IOODMMM. D?        MM.,M                    ",
"               .                            N                    7M====,        ",
"            DM                    M                         M                   ",
"         ,?                                      ?M                             ",
"                         +??7MM+               ~                                ",
"                                                                                ",
"                                                                                "
            };

                           string[] goob =

{

"                   MMMMM                               MMMM                     ",
"                   MMMMM                               MMMMM                    ",
"                     MMM                              MMMMM                     ",
"                      MM                              MMM                       ",
"                       M                              MMM                       ",
"                       M                              MM                        ",
"                       MM                             MM                        ",
"                       MM          MMMMMMMMM          MM                        ",
"                       MM     MMMMMMMMMMMMMMMMMMM     MM                        ",
"                       MMM MMMMMMMMMMMMMMMMMMMMMMMMM MMM                        ",
"                       MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM                        ",
"                       MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM                        ",
"                     MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM                      ",
"                    MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM                     ",
"                   MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM                    ",
"                 MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM                  ",
"               MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM                ",
"               MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM                ",
"               MMMMMMMMMMMMM   MMMMMMMMMMMMMMMMM  MMMMMMMMMMMMMM                ",
"              MMMMMMMMMMMMMMM    MMMMMMMMMMMMM     MMMMMMMMMMMMMM               ",
"              MMMMMMMMMMMMMMM     MMMMMMMMMMMM     MMMMMMMMMMMMMM               ",
"              MMMMMMMMMMMMMMM     MMMMMMMMMMM     MMMMMMMMMMMMMMM               ",
"              MMMMMMMMMMMMMMMM     MMMMMMMMM      MMMMMMMMMMMMMMM               ",
"              MMMMMMMMMMMMMMMMM                 MMMMMMMMMMMMMMMMM               ",
"              MMMMMMMMMMMMMMMMMM              MMMMMMMMMMMMMMMMMMM               ",
"              MMMMMMMMMMMMMMMMMMMMMM        MMMMMMMMMMMMMMMMMMMMMM              ",
"              MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM              ",
"             MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM              ",
"             MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM              ",
"             MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM              ",
"           MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM            ",
"           MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM            ",
"          MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM           ",
"         MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM          ",
"        MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM         ",
"      MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM      ",
"  MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM    ",
"MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM "

            };

            List<string[]> monsterfaces = new List<string[]>();
                monsterfaces.Add(vemom);
                monsterfaces.Add(cave_crawler);
                monsterfaces.Add(Goblin);
                monsterfaces.Add(goob);





                return monsterfaces;
            }
 

            }
        public class monster
        {
            private static string Name;
            private static string[] face;
            private static int Level;
            private static int DEF = 0;
            private static int HP;
            private static int ATK;
            private static int SPC;
            public static Dictionary<string, string> MonsterMoveList = moves.getMoveDictionary();

            public static string getMoveDescription(int i)
            {
                return MonsterMoveList.ElementAt(i).Value;
            }


            public void make()
            {

                moves move = new moves();
                move.fillDict(MonsterMoveList);

            }
        
            public  string getMoveName(int i)
            {
                return MonsterMoveList.ElementAt(i).Key;
            }
            public static int getLevel()
            {
                return Level;
            }
            public static int getATK()
            {
                return ATK;
            }
            public static int getHP()
            {
                return HP;
            }
            public static int getDEF()
            {
                return DEF;
            }
            public  string[] getface()
            {
                return face;
            }
            public void setSPC()
            {
                var random = new Random();
                if (GameInfo.settings.getdifficulty() == 1) SPC = CreateMainCharacter.MainCharacter.getSPC() + random.Next(1000) % (GameInfo.settings.getdifficulty());
                if (GameInfo.settings.getdifficulty() == 2) SPC = CreateMainCharacter.MainCharacter.getSPC() + random.Next(1000) % (GameInfo.settings.getdifficulty());
                if (GameInfo.settings.getdifficulty() == 3) SPC = CreateMainCharacter.MainCharacter.getSPC() + random.Next(1000) % (GameInfo.settings.getdifficulty());
            }
            public static int getSPC()
            {
                return SPC;
            }
            public static string getname()
            {
                return Name;
            }

            private void setName()
            {
                Name = monsterNames[RandomString.newRandom(monsterNames.Length)];
            }
            private void setFace()
            {
               
                face = faceGenerate.generate()[RandomString.newRandom(faceGenerate.generate().Count)];
            }
            private void setLevel()
            {
                var random = new Random();
                if (GameInfo.settings.getdifficulty() == 1) Level = CreateMainCharacter.MainCharacter.getLevel() - 1;
                if (GameInfo.settings.getdifficulty() == 2) Level = CreateMainCharacter.MainCharacter.getLevel();
                if (GameInfo.settings.getdifficulty() == 3) Level = CreateMainCharacter.MainCharacter.getLevel() + 1;
            }

            public  void setATK()
            {
                var random = new Random();
                ATK = CreateMainCharacter.MainCharacter.getATK() / 2
                      + (Fight.weapon1.getATK() + Fight.weapon2.getATK() + Fight.weapon3.getATK() + Fight.weapon4.getATK()) / 4
                      + random.Next(1000) % (GameInfo.settings.getdifficulty());
   
            }

            public static void setHP(int HPScore)
            {
                HP = HPScore;

            }
            public void setDEF()
            {
                
                var random = new Random();
                if (GameInfo.settings.getdifficulty() == 1) DEF = CreateMainCharacter.MainCharacter.getDEF() + random.Next(1000) % (GameInfo.settings.getdifficulty() );
                if (GameInfo.settings.getdifficulty() == 2) DEF = CreateMainCharacter.MainCharacter.getDEF() + random.Next(1000) % (GameInfo.settings.getdifficulty() );
                if (GameInfo.settings.getdifficulty() == 3) DEF = CreateMainCharacter.MainCharacter.getDEF() + random.Next(1000) % (GameInfo.settings.getdifficulty() );

            }
            public monster create()
            {
                monster newb = new monster();
                newb.setName();
                newb.setLevel();
                newb.setDEF();
                newb.setSPC();
                newb.setATK();
                setHP(100);
                newb.setFace();
                newb.make();
                return newb;
            }

            
       public class moves
        {
                private static Dictionary<string, string> moveDict = new Dictionary<string, string>();

                public static Dictionary<string, string> getMoveDictionary()
                {
                    moves move = new moves();
                    return moveDict;
                }

            public static Dictionary<string, string> moveList()
            {


                    Dictionary<string, string> moveDict1 = new Dictionary<string, string>();
                    moveDict1.Add("Fire Ball", "When " + monster.getname() + " uses Fire Ball, it does " + monster.getATK() +1 + " damage. In addition it applies burning for 2 turns (which does " + MonsterGenerator.monster.getATK() / 5 + 1 + "damage per turn).");
                    moveDict1.Add("Blood Song", "When " + monster.getname() + " uses Blood Song, blood is drawn from " + CreateMainCharacter.MainCharacter.getName() + " stealing " + monster.getATK() / 5 + " HP for six turns.");
                    moveDict1.Add("Lightning Strike", "When " + monster.getname() + " uses Lightning Strike, it does " + MonsterGenerator.monster.getATK() / 5 + MonsterGenerator.monster.getATK() % 5 + " damage.");
                    moveDict1.Add("Flaming Sphere", "When " + monster.getname() + " uses Flaming Sphere, it does " + monster.getATK() / 5 + 1 + " damage for five turns.");
                    moveDict1.Add("Sacrifice", "When " + monster.getname() + " uses Sacrifice, it reduces it's HP by 10% and " + CreateMainCharacter.MainCharacter.getName() + "'s by 20%.");
                    moveDict1.Add("Meteor Shower", "When " + monster.getname() + " uses Meteor Shower, for 4 turns there is a 25 % chance it does " + monster.getATK() / 2 + " damage .");
                    if(CreateMainCharacter.MainCharacter.getSPC() > 5)
                    {

                    }
                    return moveDict1;

               }
            

 public static void setMove(Dictionary<string, string> diction)
                {
                    Random rand = new Random();
                    string move = moveList().ElementAt(rand.Next(0, moveList().Count)).Key;
                   
                    if (!diction.ContainsKey(move))
                    {                        
                     string Value = "";
                    if(moveList().TryGetValue(move, out Value))
                    { moveDict.Add(move, Value);} 
                    }

                }

                public void fillDict(Dictionary<string, string> diction)
                {

                    while (diction.Count<4)
                    {
                        
                        setMove(diction);
                    }
                   
                }
                    
            

            

                
        }

        }







 

            
        }



        
        

        





    }

    

