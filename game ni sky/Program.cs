using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_ni_sky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rn = new Random();
            int enemycounter = 3;
            int initialPlayerHP = 100; // Assuming initial player HP is 100
            int playerHP = initialPlayerHP; // Assign initial player HP
            int healCount = 3; // Number of healing actions allowed


            // INTRODUCTION OF THE GAME
            Console.WriteLine("░▒▓█▓▒░░▒▓█▓▒░▒▓███████▓▒░░▒▓███████▓▒░░▒▓████████▓▒░▒▓███████▓▒░▒▓████████▓▒░▒▓██████▓▒░░▒▓█▓▒░      ░▒▓████████▓▒░ \r\n░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░ ░▒▓█▓▒░  ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░        \r\n░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░ ░▒▓█▓▒░  ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░        \r\n░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓██████▓▒░ ░▒▓███████▓▒░  ░▒▓█▓▒░  ░▒▓████████▓▒░▒▓█▓▒░      ░▒▓██████▓▒░   \r\n░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░ ░▒▓█▓▒░  ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░        \r\n░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░ ░▒▓█▓▒░  ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░        \r\n ░▒▓██████▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓███████▓▒░░▒▓████████▓▒░▒▓█▓▒░░▒▓█▓▒░ ░▒▓█▓▒░  ░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░▒▓████████▓▒░ \r\n                                                                                                                     \r\n                                                                                                                     \r\n");
            Console.WriteLine("                                 .''.\r\n       .''.             *''*    :_\\/_:     . \r\n      :_\\/_:   .    .:.*_\\/_*   : /\\ :  .'.:.'.\r\n  .''.: /\\ : _\\(/_  ':'* /\\ *  : '..'.  -=:o:=-\r\n :_\\/_:'.:::. /)\\*''*  .|.* '.\\'/.'_\\(/_'.':'.'\r\n : /\\ : :::::  '*_\\/_* | |  -= o =- /)\\    '  *\r\n  '..'  ':::'   * /\\ * |'|  .'/.\\'.  '._____\r\n      *        __*..* |  |     :      |.   |' .---\"|\r\n       _*   .-'   '-. |  |     .--'|  ||   | _|    |\r\n    .-'|  _.|  |    ||   '-__  |   |  |    ||      |\r\n    |' | |.    |    ||       | |   |  |    ||      |\r\n ___|  '-'     '    \"\"       '-'   '-.'    '`      |____");
            Console.WriteLine(" WELCOME TO UNDERTALE RECREATED BY : ISKAII");
            Console.WriteLine("________________________________________________________________________");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("________________________________________________________________________");
            Console.WriteLine("*YOU RUNNING THE PROGRAM FILLS YOU WITH DETERMINATION*");
            Console.ResetColor();
            Console.WriteLine("\n\n");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("???: What is your name brave child? \n");
            string username = Console.ReadLine();
            Console.ResetColor();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n\n");
            Console.WriteLine("░░░░█░░░░░░░░░░░░░█░░░░\r\n░░░█░░░░░░░░░░▄▄▄░░█░░░\r\n░░░█░░▄▄▄░░▄░░███░░█░░░\r\n░░░▄█░▄░░░▀▀▀░░░▄░█▄░░░\r\n░░░█░░▀█▀█▀█▀█▀█▀░░█░░░\r\n░░░▄██▄▄▀▀▀▀▀▀▀▄▄██▄░░░\r\n░▄█░█▀▀█▀▀▀█▀▀▀█▀▀█░█▄░\r\n▄▀░▄▄▀▄▄▀▀▀▄▀▀▀▄▄▀▄▄░▀▄\r\n█░░░░▀▄░█▄░░░▄█░▄▀░░░░█\r\n░▀▄▄░█░░█▄▄▄▄▄█░░█░▄▄▀░\r\n░░░▀██▄▄███████▄▄██▀░░░\r\n░░░████████▀████████░░░\r\n░░▄▄█▀▀▀▀█░░░█▀▀▀▀█▄▄░░\r\n░░▀▄▄▄▄▄▀▀░░░▀▀▄▄▄▄▄▀░﻿\r\n");
            Console.WriteLine($"sans: oh, hi {username}! so happy you're here. you may not know me but i know u ;p ");
            Console.ResetColor();
            Console.WriteLine("________________________________________________________________________");
            Console.WriteLine($"{username}: Where am i? what's all this?! why am i here! *how does this skeleton know me?* \r\n **PRESS ANYTHING TO CONTINUE**");
            Console.ReadLine();
            Console.WriteLine("________________________________________________________________________");
            Console.Clear();

            //INTERACTION
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\n\n");
                Console.WriteLine("░░░░█░░░░░░░░░░░░░█░░░░\r\n░░░█░░░░░░░░░░▄▄▄░░█░░░\r\n░░░█░░▄▄▄░░▄░░███░░█░░░\r\n░░░▄█░▄░░░▀▀▀░░░▄░█▄░░░\r\n░░░█░░▀█▀█▀█▀█▀█▀░░█░░░\r\n░░░▄██▄▄▀▀▀▀▀▀▀▄▄██▄░░░\r\n░▄█░█▀▀█▀▀▀█▀▀▀█▀▀█░█▄░\r\n▄▀░▄▄▀▄▄▀▀▀▄▀▀▀▄▄▀▄▄░▀▄\r\n█░░░░▀▄░█▄░░░▄█░▄▀░░░░█\r\n░▀▄▄░█░░█▄▄▄▄▄█░░█░▄▄▀░\r\n░░░▀██▄▄███████▄▄██▀░░░\r\n░░░████████▀████████░░░\r\n░░▄▄█▀▀▀▀█░░░█▀▀▀▀█▄▄░░\r\n░░▀▄▄▄▄▄▀▀░░░▀▀▄▄▄▄▄▀░﻿\r\n");
                Console.WriteLine($"sans: well you fell here {username}, again. if you wanna escape i can help you. but you need to know the rules first hehehe.");
                Console.ResetColor();
                Console.WriteLine("________________________________________________________________________");
                Console.WriteLine("[1] what's the rules? \r\n[2] no! i wanna exit this game now!");
                Console.WriteLine("________________________________________________________________________");
                int ch1 = int.Parse(Console.ReadLine());
                Console.WriteLine("\n\n");
                Console.Clear();

                if (ch1 == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"sans: okay here's the rules, but this time its different.");
                    Console.ResetColor();
                    Console.WriteLine("\n\n");
                    Console.Clear();
                    break;

                }
                else if (ch1 == 2)
                {

                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"████████▀▀░░░░░░░░░░░░░░░░░░░▀▀███████\r\n██████▀░░░░░░░░░░░░░░░░░░░░░░░░░▀██████\r\n█████░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█████\r\n████░░░░░▄▄▄▄▄▄▄░░░░░░░░▄▄▄▄▄▄░░░░░████\r\n████░░▄██████████░░░░░░██▀░░░▀██▄░░████\r\n████░░███████████░░░░░░█▄░░▀░░▄██░░████\r\n█████░░▀▀███████░░░██░░░██▄▄▄█▀▀░░█████\r\n██████░░░░░░▄▄▀░░░████░░░▀▄▄░░░░░██████\r\n█████░░░░░█▄░░░░░░▀▀▀▀░░░░░░░█▄░░░█████\r\n█████░░░▀▀█░█▀▄▄▄▄▄▄▄▄▄▄▄▄▄▀██▀▀░░█████\r\n██████░░░░░▀█▄░░█░░█░░░█░░█▄▀░░░░██▀▀▀▀\r\n▀░░░▀██▄░░░░░░▀▀█▄▄█▄▄▄█▄▀▀░░░░▄█▀░░░▄▄\r\n▄▄▄░░░▀▀██▄▄▄▄░░░░░░░░░░░░▄▄▄███░░░▄██▄\r\n██████▄▄░░▀█████▀█████▀██████▀▀░░▄█████\r\n██████████▄░░▀▀█▄░░░░░▄██▀▀▀░▄▄▄███▀▄██");
                    Console.WriteLine($"sans: nope try again kid.");
                    Console.ResetColor();
                    Console.WriteLine("\n\n");

                }
                else
                    Console.WriteLine($" We don't have that option kid hehehehe.");
            }

            //INTERACTION
            while (true)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("__________██▓▓▒▒░░░░░░░--SYSTEM RULES--░░░░░░░▒▒▓▓██_________");
                Console.WriteLine($"IF THE PLAYER WANTS TO ESCAPE THE UNDERGROUND, HERE ARE THE THINGS THE PLAYER MUST KNOW ABOUT. \r\n1. player is given 3 interactions for the game (attack, heal, flee.) for each level, your health increases and also your damage. \r\n2. HEAL ONLY HAS 3 TRIES PER LEVEL, once you ran out of heals you're dead, \r\n3. there are only 3 levels to go out to the surface but with each level the difficulties of the enemies increases. \r\n4. enjoy the game, you've been here once, so goodluck ;) ");
                Console.WriteLine("\n\n");
                Console.WriteLine("________________________________________________________________________");
                Console.WriteLine("[1] Im ready to play \r\n[2] noooo! i wanna exit this game now!");
                Console.WriteLine("________________________________________________________________________");
                int ch2 = int.Parse(Console.ReadLine());
                Console.Clear();

                if (ch2 == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("________________________________________________________________________");
                    Console.WriteLine("*The choice made you stronger, it gave you DETERMINATION.*");
                    Console.WriteLine("________________________________________________________________________");
                    Console.ResetColor();
                    Console.WriteLine("\n\n");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"████████▀▀░░░░░░░░░░░░░░░░░░░▀▀███████\r\n██████▀░░░░░░░░░░░░░░░░░░░░░░░░░▀██████\r\n█████░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█████\r\n████░░░░░▄▄▄▄▄▄▄░░░░░░░░▄▄▄▄▄▄░░░░░████\r\n████░░▄██████████░░░░░░██▀░░░▀██▄░░████\r\n████░░███████████░░░░░░█▄░░▀░░▄██░░████\r\n█████░░▀▀███████░░░██░░░██▄▄▄█▀▀░░█████\r\n██████░░░░░░▄▄▀░░░████░░░▀▄▄░░░░░██████\r\n█████░░░░░█▄░░░░░░▀▀▀▀░░░░░░░█▄░░░█████\r\n█████░░░▀▀█░█▀▄▄▄▄▄▄▄▄▄▄▄▄▄▀██▀▀░░█████\r\n██████░░░░░▀█▄░░█░░█░░░█░░█▄▀░░░░██▀▀▀▀\r\n▀░░░▀██▄░░░░░░▀▀█▄▄█▄▄▄█▄▀▀░░░░▄█▀░░░▄▄\r\n▄▄▄░░░▀▀██▄▄▄▄░░░░░░░░░░░░▄▄▄███░░░▄██▄\r\n██████▄▄░░▀█████▀█████▀██████▀▀░░▄█████\r\n██████████▄░░▀▀█▄░░░░░▄██▀▀▀░▄▄▄███▀▄██");
                    Console.WriteLine($"sans: GOOD! come on let's go through the first level. I'm sure you know exactly what to do {username} ;D");
                    Console.ResetColor();
                    Console.WriteLine("\n\n");
                    Console.Clear();
                    break;

                }
                else if (ch2 == 2)
                {

                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"████████▀▀░░░░░░░░░░░░░░░░░░░▀▀███████\r\n██████▀░░░░░░░░░░░░░░░░░░░░░░░░░▀██████\r\n█████░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█████\r\n████░░░░░▄▄▄▄▄▄▄░░░░░░░░▄▄▄▄▄▄░░░░░████\r\n████░░▄██████████░░░░░░██▀░░░▀██▄░░████\r\n████░░███████████░░░░░░█▄░░▀░░▄██░░████\r\n█████░░▀▀███████░░░██░░░██▄▄▄█▀▀░░█████\r\n██████░░░░░░▄▄▀░░░████░░░▀▄▄░░░░░██████\r\n█████░░░░░█▄░░░░░░▀▀▀▀░░░░░░░█▄░░░█████\r\n█████░░░▀▀█░█▀▄▄▄▄▄▄▄▄▄▄▄▄▄▀██▀▀░░█████\r\n██████░░░░░▀█▄░░█░░█░░░█░░█▄▀░░░░██▀▀▀▀\r\n▀░░░▀██▄░░░░░░▀▀█▄▄█▄▄▄█▄▀▀░░░░▄█▀░░░▄▄\r\n▄▄▄░░░▀▀██▄▄▄▄░░░░░░░░░░░░▄▄▄███░░░▄██▄\r\n██████▄▄░░▀█████▀█████▀██████▀▀░░▄█████\r\n██████████▄░░▀▀█▄░░░░░▄██▀▀▀░▄▄▄███▀▄██");
                    Console.WriteLine($"sans: you've been through this before, don't you remember?");
                    Console.ResetColor();
                    Console.WriteLine("\n\n");

                }
                else
                    Console.WriteLine($" We don't have that option kid hehehehe.");
            }

            // status of player
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                                   .''.\r\n       .''.      .        *''*    :_\\/_:     .\r\n      :_\\/_:   _\\(/_  .:.*_\\/_*   : /\\ :  .'.:.'.\r\n  .''.: /\\ :    /)\\   ':'* /\\ *  : '..'.  -=:o:=-\r\n :_\\/_:'.:::.  | ' *''*    * '.\\'/.'_\\(/_'.':'.'\r\n : /\\ : :::::  =  *_\\/_*     -= o =- /)\\    '  *\r\n  '..'  ':::' === * /\\ *     .'/.\\'.  ' ._____\r\n      *        |   *..*         :       |.   |' .---\"|\r\n        *      |     _           .--'|  ||   | _|    |\r\n        *      |  .-'|       __  |   |  |    ||      |\r\n     .-----.   |  |' |  ||  |  | |   |  |    ||      |\r\n ___'       ' /\"\\ |  '-.\"\".    '-'   '-.'    '`      |____\r\njgs~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\r\n  &                    ~-~-~-~-~-~-~-~-~-~   /|\r\n ejm97    )      ~-~-~-~-~-~-~-~  /|~       /_|\\\r\n        _-H-__  -~-~-~-~-~-~     /_|\\    -~======-~\r\n~-\\XXXXXXXXXX/~     ~-~-~-~     /__|_\\ ~-~-~-~\r\n~-~-~-~-~-~    ~-~~-~-~-~-~    ========  ~-~-~-~");
            Console.WriteLine("________________________________________________________________________");
            Console.WriteLine($"______{username}______");
            Console.WriteLine($"HEALTH: {playerHP}");
            Console.WriteLine("STATUS: -___-");
            Console.WriteLine("ROUTE(cannot be changed. EVER -sans):PASSIVE ROUTE");
            Console.WriteLine("WEAPON: LOVE AND DETERMINATION (DMG: 20)");
            Console.WriteLine("________________________________________________________________________");
            Console.WriteLine("**PRESS ANYTHING TO CONTINUE**");
            Console.ReadLine();
            Console.Clear();
            Console.ResetColor();
            //----------------------------------------

            //LEVEL 1 ENEMIES (RUINS)
            Dictionary<string, Tuple<int, string>> e1 = new Dictionary<string, Tuple<int, string>>();
            e1.Add("froggit", new Tuple<int, string>(100, "         (.)_(.)\r\n        _ (   _   ) _\r\n       / \\/`-----'\\/ \\\r\n     __\\ ( (     ) ) /__\r\n     )   /\\ \\._./ /\\   (\r\njgs   )_/ /|\\   /|\\ \\_("));
            e1.Add("dummy", new Tuple<int, string>(50, "  (__  '.\r\n    /_____)\r\n   ()@ @ )))\r\n    'C ,()(()\r\n    ,.'_'.' \\\r\n __/ )   (--'\r\n'._./     \\\r\n   (_._._._)\r\n    _|| ||_\r\nmrf(__.).__)"));
            e1.Add("Migosp", new Tuple<int, string>(100, "       ,_    /) (\\    _,\r\n        >>  <<,_,>>  <<\r\n       //   _0.-.0_   \\\\\r\n       \\'._/       \\_.'/\r\n        '-.\\.--.--./.-'\r\n        __/ : :Y: : \\ _\r\n';,  .-(_| : : | : : |_)-.  ,:'\r\n  \\\\/.'  |: : :|: : :|  `.\\//\r\n   (/    |: : :|: : :|    \\)\r\n         |: : :|: : :;\r\n        /\\ : : | : : /\\\r\n       (_/'.: :.: :.'\\_)\r\n        \\\\  `\"\"`\"\"`  //\r\n    jgs  \\\\         //\r\n          ':.     .:'"));

            // BOSS FOR LEVEL 1
            string bossName = "Flowey";
            Tuple<int, string> bossData = new Tuple<int, string>(150, "▀▀▀▀▀▀▀█████████████▀▀▀▀▀█████\r\n█████████▀░░▀▀█▄▄▄▄▄▄██▄▄▄▄▄▄█▀░░▀███████\r\n████████▄░░▄▄████▀▀▀▀▀▀▀▀▀████▄▄░░▄████████\r\n████▀▀▀▀█████▀░░░░░░░░░░░░░░░▀█████▀▀▀▀████\r\n██▀░░░░░░██▀░░░░░░██░░░██░░░░░░▀██░░░░░░▀██\r\n█░░░▀▀▀▀███░░░░░░░██░░░██░░░░░░░███▀▀▀▀░░░█\r\n█▄▄░░░░░░██░░░░▄░░▀▀░░░▀▀░░▄░░░░██░░░░░░▄▄█\r\n████▄░░░░▀██░░░░██▀▀▀▀▀▀▀██░░░░██▀░░░░▄████\r\n██████████▀██▄░░░▀███████▀░░░▄██▀██████████\r\n███████▀░░░████▄▄░░░░░░░░░▄▄████░░░▀███████\r\n██████░░░▄▀░░▀▀▀███████████▀▀▀░░▀▄░░░██████\r\n██████░░░▀░░░░░░░░▄▄▄█▄▄▄░░░░░░░░▀░░░██████\r\n████████▄▄▄▄▄▄███████████████▄▄▄▄▄▄████████\r\n██████████████████▀░░▀█████████████████████\r\n█████████████████▀░░░▄█████████████████████\r\n█████████████████░░░███████████████████████\r\n██████████████████░░░▀█████████████████████\r\n███████████████████▄░░░████████████████████\r\n█████████████████████░░░██████████████");

            //visual of level 1
            Console.WriteLine("\r\n░▒▓█▓▒░      ░▒▓████████▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░▒▓█▓▒░                ░▒▓█▓▒░ \r\n░▒▓█▓▒░      ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░             ░▒▓████▓▒░ \r\n░▒▓█▓▒░      ░▒▓█▓▒░       ░▒▓█▓▒▒▓█▓▒░░▒▓█▓▒░      ░▒▓█▓▒░                ░▒▓█▓▒░ \r\n░▒▓█▓▒░      ░▒▓██████▓▒░  ░▒▓█▓▒▒▓█▓▒░░▒▓██████▓▒░ ░▒▓█▓▒░                ░▒▓█▓▒░ \r\n░▒▓█▓▒░      ░▒▓█▓▒░        ░▒▓█▓▓█▓▒░ ░▒▓█▓▒░      ░▒▓█▓▒░                ░▒▓█▓▒░ \r\n░▒▓█▓▒░      ░▒▓█▓▒░        ░▒▓█▓▓█▓▒░ ░▒▓█▓▒░      ░▒▓█▓▒░                ░▒▓█▓▒░ \r\n░▒▓████████▓▒░▒▓████████▓▒░  ░▒▓██▓▒░  ░▒▓████████▓▒░▒▓████████▓▒░         ░▒▓█▓▒░ \r\n                                                                                   \r\n                                                                                   \r\n");

            //START FOR LEVEL 1
            while (enemycounter > 0)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("*While walking through the ruins, you saw a monster coming towards you!");
                Console.WriteLine($"sans: are you ready {username}?");
                Console.WriteLine("[1] Yes \r\n[2] No ");
                Console.ResetColor();
                int ch3;
                try
                {
                    ch3 = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                if (ch3 == 1) // if player chooses yes
                {
                    // Encounter loop for regular enemies
                    string[] enemies = e1.Keys.ToArray();

                    // randomizing what enemies you'll encounter
                    for (int i = 0; i < enemies.Length; i++)
                    {
                        int randomIndex = rn.Next(i, enemies.Length);
                        string temp = enemies[randomIndex];
                        enemies[randomIndex] = enemies[i];
                        enemies[i] = temp;
                    }


                    string e1Name = enemies[0]; // Selects the first enemy after shuffling
                    string visualText = e1[e1Name].Item2; // show what the enemy looks like

                    Console.WriteLine("\n\n");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"{e1Name}:\r\n{visualText}");
                    Console.WriteLine($"{e1Name} magically appeared!");
                    Console.ResetColor();

                    int enemyHP = e1[e1Name].Item1 * 20; // Assigning enemy's HP based on its level


                    // Encounter loop
                    while (playerHP > 0 && enemyHP > 0)
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("________________________________________");
                        Console.WriteLine($"WEAPON: none \r\nHEALTH:{playerHP}");
                        Console.WriteLine("[1] Attack \r\n[2] Heal \r\n[3] flee");

                        int playerAction;
                        try //just fixing the players choices for combat
                        {
                            playerAction = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            continue;
                        }

                        if (playerAction == 1) // if player chooses to fight
                        {
                            // Player attacks
                            int playerDamage = 20;
                            int enemyHealth = e1[e1Name].Item1;
                            e1[e1Name] = new Tuple<int, string>(enemyHealth - playerDamage, e1[e1Name].Item2); // Update enemy's health in the dictionary //---

                            // if enemy's HP reaches zero
                            if (e1[e1Name].Item1 <= 0)
                            {
                                Console.WriteLine("\n\n");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine($"{e1Name}:\r\n{visualText}");
                                Console.WriteLine($"{e1Name} got pursuaded and left you alone!");
                                Console.ResetColor();
                                break; // End the loop if enemy is defeated
                            }

                            // Enemy attacks
                            if (enemyHealth > 0)
                            {
                                int enemyDamage = 10;
                                playerHP -= enemyDamage; // ---

                                //visuals
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\n\n");
                                Console.WriteLine($"{username} pursuaded {e1Name} for {playerDamage}dmg of love!");
                                Console.WriteLine($"{e1Name} got mad at {username} and hit the player for {enemyDamage} HP :((");
                                Console.WriteLine($"{e1Name}:\r\n{visualText}");
                                Console.WriteLine($"{username}HP: {playerHP}\r\n{e1Name}HP: {enemyHealth}");
                                Console.WriteLine("________________________________________");
                                Console.ResetColor();

                                // if player's HP reaches zero
                                if (playerHP <= 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine($"{username} Determination is still in your heart!");
                                    Console.ResetColor();
                                    break; // End the loop if player is defeated

                                }
                            }
                        }
                        else if (playerAction == 2) // if player choose to heal
                        {
                            // Player heals
                            if (healCount > 0)
                            {
                                playerHP += 50; // Heal player
                                if (playerHP > initialPlayerHP)
                                    playerHP = initialPlayerHP; // Ensure player's HP doesn't exceed initial HP
                                healCount--; // Decrease heal count
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine($"{username} healed for 50 HP. {healCount} heals left.");
                                Console.ResetColor();
                            }
                            else //if player uses all heals for the level 
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine($"You have no more heals left!");
                                Console.ResetColor();
                            }
                        }
                        else if (playerAction == 3) //if player chose to leave
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine($"{username} ran the match!"); //just leave if you wanna skip the fight
                            Console.ResetColor();
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine($"Invalid action!"); //if u press the wrong input
                            Console.ForegroundColor = ConsoleColor.Magenta;
                        }

                    }
                }
                else if (ch3 == 2) // if player skips the level (cheat)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"████████▀▀░░░░░░░░░░░░░░░░░░░▀▀███████\r\n██████▀░░░░░░░░░░░░░░░░░░░░░░░░░▀██████\r\n█████░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█████\r\n████░░░░░▄▄▄▄▄▄▄░░░░░░░░▄▄▄▄▄▄░░░░░████\r\n████░░▄██████████░░░░░░██▀░░░▀██▄░░████\r\n████░░███████████░░░░░░█▄░░▀░░▄██░░████\r\n█████░░▀▀███████░░░██░░░██▄▄▄█▀▀░░█████\r\n██████░░░░░░▄▄▀░░░████░░░▀▄▄░░░░░██████\r\n█████░░░░░█▄░░░░░░▀▀▀▀░░░░░░░█▄░░░█████\r\n█████░░░▀▀█░█▀▄▄▄▄▄▄▄▄▄▄▄▄▄▀██▀▀░░█████\r\n██████░░░░░▀█▄░░█░░█░░░█░░█▄▀░░░░██▀▀▀▀\r\n▀░░░▀██▄░░░░░░▀▀█▄▄█▄▄▄█▄▀▀░░░░▄█▀░░░▄▄\r\n▄▄▄░░░▀▀██▄▄▄▄░░░░░░░░░░░░▄▄▄███░░░▄██▄\r\n██████▄▄░░▀█████▀█████▀██████▀▀░░▄█████\r\n██████████▄░░▀▀█▄░░░░░▄██▀▀▀░▄▄▄███▀▄██");
                    Console.WriteLine($"sans: cheating your way huh {username}?");
                    Console.ResetColor();
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"████████▀▀░░░░░░░░░░░░░░░░░░░▀▀███████\r\n██████▀░░░░░░░░░░░░░░░░░░░░░░░░░▀██████\r\n█████░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█████\r\n████░░░░░▄▄▄▄▄▄▄░░░░░░░░▄▄▄▄▄▄░░░░░████\r\n████░░▄██████████░░░░░░██▀░░░▀██▄░░████\r\n████░░███████████░░░░░░█▄░░▀░░▄██░░████\r\n█████░░▀▀███████░░░██░░░██▄▄▄█▀▀░░█████\r\n██████░░░░░░▄▄▀░░░████░░░▀▄▄░░░░░██████\r\n█████░░░░░█▄░░░░░░▀▀▀▀░░░░░░░█▄░░░█████\r\n█████░░░▀▀█░█▀▄▄▄▄▄▄▄▄▄▄▄▄▄▀██▀▀░░█████\r\n██████░░░░░▀█▄░░█░░█░░░█░░█▄▀░░░░██▀▀▀▀\r\n▀░░░▀██▄░░░░░░▀▀█▄▄█▄▄▄█▄▀▀░░░░▄█▀░░░▄▄\r\n▄▄▄░░░▀▀██▄▄▄▄░░░░░░░░░░░░▄▄▄███░░░▄██▄\r\n██████▄▄░░▀█████▀█████▀██████▀▀░░▄█████\r\n██████████▄░░▀▀█▄░░░░░▄██▀▀▀░▄▄▄███▀▄██");
                    Console.WriteLine($"sans: :D ?");
                    Console.ResetColor();
                    break;
                }

                enemycounter--; // Decrement enemycounter after each encounter
            }

            // after 3 fights with the enemy, will encounter a boss level
            Console.WriteLine("*You encountered Flowey, the Ruins' Guardian!");
            int bossHP = bossData.Item1; // Boss HP

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"████████▀▀░░░░░░░░░░░░░░░░░░░▀▀███████\r\n██████▀░░░░░░░░░░░░░░░░░░░░░░░░░▀██████\r\n█████░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█████\r\n████░░░░░▄▄▄▄▄▄▄░░░░░░░░▄▄▄▄▄▄░░░░░████\r\n████░░▄██████████░░░░░░██▀░░░▀██▄░░████\r\n████░░███████████░░░░░░█▄░░▀░░▄██░░████\r\n█████░░▀▀███████░░░██░░░██▄▄▄█▀▀░░█████\r\n██████░░░░░░▄▄▀░░░████░░░▀▄▄░░░░░██████\r\n█████░░░░░█▄░░░░░░▀▀▀▀░░░░░░░█▄░░░█████\r\n█████░░░▀▀█░█▀▄▄▄▄▄▄▄▄▄▄▄▄▄▀██▀▀░░█████\r\n██████░░░░░▀█▄░░█░░█░░░█░░█▄▀░░░░██▀▀▀▀\r\n▀░░░▀██▄░░░░░░▀▀█▄▄█▄▄▄█▄▀▀░░░░▄█▀░░░▄▄\r\n▄▄▄░░░▀▀██▄▄▄▄░░░░░░░░░░░░▄▄▄███░░░▄██▄\r\n██████▄▄░░▀█████▀█████▀██████▀▀░░▄█████\r\n██████████▄░░▀▀█▄░░░░░▄██▀▀▀░▄▄▄███▀▄██");
            Console.WriteLine($"sans: boss fights are unavoidable kid, press 1 to fight lol :p");
            Console.WriteLine("[1] Yes");
            Console.ResetColor();
            int ch4;
            try
            {
                ch4 = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            if (ch4 == 1)
            {
                while (playerHP > 0 && bossHP > 0)
                {
                    Console.WriteLine($"{bossName}:\r\n{bossData.Item2}");

                    Console.WriteLine("\n\n");
                    Console.WriteLine("________________________________________");
                    Console.WriteLine($"WEAPON: none \r\nHEALTH:{playerHP}");
                    Console.WriteLine("[1] Attack \r\n[2] Heal \r\n[3] flee");
                    int playerAction;
                    string visualText = bossData.Item2;

                    try
                    {
                        playerAction = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        continue;
                    }

                    if (playerAction == 1)
                    {
                        // Player attacks
                        int playerDamage = 20;
                        bossHP -= playerDamage;


                        // Check if enemy's HP reaches zero
                        if (bossData.Item1 <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine($"{bossName} has been defeated!");
                            Console.ResetColor();
                            break; // End the loop if enemy is defeated
                        }

                        // Boss attacks
                        if (bossHP > 0)
                        {
                            int bossDamage = 10;
                            playerHP -= bossDamage;

                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"{bossName}:\r\n{visualText}");
                            Console.WriteLine($"You hit {bossName} for {playerDamage} HP");
                            Console.WriteLine($"{bossName} hit you for {bossDamage} HP");
                            Console.WriteLine($"{bossName}:\r\n{bossData.Item2}");
                            Console.WriteLine($"PLAYER HP: {playerHP}  {bossName} HP: {bossHP}");
                            Console.ResetColor();
                        }
                    }
                    else if (playerAction == 2)
                    {
                        // Player heals
                        if (healCount > 0)
                        {
                            playerHP += 40; // Heal player
                            if (playerHP > initialPlayerHP)
                                playerHP = initialPlayerHP; // Ensure player's HP doesn't exceed initial HP
                            healCount--; // Decrease heal count
                            Console.WriteLine($"{username} healed for 30 HP. {healCount} heals left.");
                        }
                        else
                        {
                            Console.WriteLine($"You have no more heals left!");
                        }
                    }
                    else if (playerAction == 3)
                    {
                        Console.WriteLine("weak");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid action!");
                    }
                }
            }
            else
            {
                Console.WriteLine("sans: no going back kiddo");
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\r\n ░▒▓██████▓▒░ ░▒▓██████▓▒░░▒▓██████████████▓▒░░▒▓███████▓▒░░▒▓█▓▒░      ░▒▓████████▓▒░▒▓████████▓▒░▒▓████████▓▒░ \r\n░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░         ░▒▓█▓▒░   ░▒▓█▓▒░        \r\n░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░         ░▒▓█▓▒░   ░▒▓█▓▒░        \r\n░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓███████▓▒░░▒▓█▓▒░      ░▒▓██████▓▒░    ░▒▓█▓▒░   ░▒▓██████▓▒░   \r\n░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░      ░▒▓█▓▒░         ░▒▓█▓▒░   ░▒▓█▓▒░        \r\n░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░      ░▒▓█▓▒░         ░▒▓█▓▒░   ░▒▓█▓▒░        \r\n ░▒▓██████▓▒░ ░▒▓██████▓▒░░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓████████▓▒░▒▓████████▓▒░  ░▒▓█▓▒░   ░▒▓████████▓▒░ \r\n                                                                                                                 \r\n                                                                                                                 \r\n");
            Console.WriteLine("after every  fight, though with no weapons.. it filled you with DETERMINATION");
            Console.ResetColor();
            //end 

            // LEVEL 2 ENEMIES (SNOWDIN)
            Dictionary<string, Tuple<int, string>> e2 = new Dictionary<string, Tuple<int, string>>();
            e2.Add("Snowdrake", new Tuple<int, string>(200, "           __            \r\n          _/ '>           \r\n    _ _.-'(   )'-._ _     \r\n   '=._.=-(   )-=._.='    \r\n          |/-\\|           \r\ncjr       Y   Y"));
            e2.Add("Lesser Dog", new Tuple<int, string>(200, "         __\r\n        /  \\\r\n       / ..|\\\r\n      (_\\  |_)\r\n      /  \\@' \r\n     /     \\\r\n_   /  `   |\r\n\\\\/  \\  | _\\\r\n \\   /_ || \\\\_\r\n  \\____)|_) \\_)"));
            e2.Add("Greater Dog", new Tuple<int, string>(250, "     |\\_/|                  \r\n     | @ @   Woof! \r\n     |   <>              _  \r\n     |  _/\\------____ ((| |))\r\n     |               `--' |   \r\n ____|_       ___|   |___.' \r\n/_/_____/____/_______|"));

            //BOSS FOR LEVEL 2
            string boss2 = "muffet";
            Tuple<int, string> bossd2 = new Tuple<int, string>(300, "\r\n░▄████░▀▄░░░░░░░▄▀░█████▄░\r\n████▀█▀▄█████████▄▀█▀████░\r\n▀▀░▀▄█████▀▀▀▀▀░▀███▄▀░▀▀░\r\n░░░░████▀▄░░██░░▄░███░░░░░\r\n░░░▄███▀▄▀▀░▀▀░▀▀▄▀██▄░░░░\r\n░▄▄████░███▄░░▄███░███▄▄░░\r\n░░█████░░▀▀░░░░▀▀░░████░░░\r\n░░░▀▀███▄░▀▄▀▀▄▀░▄██▀▀░░░░\r\n░░░░░░░░░▀▄▄░░▄▄█░░░░░░░░░\r\n░░░░░░░░▄▀▀▄▀▀▄▀▀▄░░░░░░░░\r\n░▄▄▄▄▄▀▀▀██░▄▄░██▀▀▀▄▄▄▄▄░\r\n▀▄▄▀░░░▄▀█▀█▀▀█▀█▀▄░░░▀▄▄▀\r\n░░▄▄▄▄▀▄█▀░▄░░▄░▀█▄▀▄▄▄▄░░\r\n░▀▄▄▀░▄▀█░░▄▄▄▄░░█▀▄░▀▄▄▀░\r\n░░░░░█▀▄░▀▄▀░░▀▄▀░▄▀█░░░░░\r\n░░░░░█▄▀░░█▄░░▄█░░▀▄█░░░░░\r\n░░░░░░░░░▄█▀░░▀█▄░░░░░░░░░");

            int enemycounter2 = 2;
            playerHP = 200;
            int initialPlayerHP2 = 200;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"████████▀▀░░░░░░░░░░░░░░░░░░░▀▀███████\r\n██████▀░░░░░░░░░░░░░░░░░░░░░░░░░▀██████\r\n█████░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█████\r\n████░░░░░▄▄▄▄▄▄▄░░░░░░░░▄▄▄▄▄▄░░░░░████\r\n████░░▄██████████░░░░░░██▀░░░▀██▄░░████\r\n████░░███████████░░░░░░█▄░░▀░░▄██░░████\r\n█████░░▀▀███████░░░██░░░██▄▄▄█▀▀░░█████\r\n██████░░░░░░▄▄▀░░░████░░░▀▄▄░░░░░██████\r\n█████░░░░░█▄░░░░░░▀▀▀▀░░░░░░░█▄░░░█████\r\n█████░░░▀▀█░█▀▄▄▄▄▄▄▄▄▄▄▄▄▄▀██▀▀░░█████\r\n██████░░░░░▀█▄░░█░░█░░░█░░█▄▀░░░░██▀▀▀▀\r\n▀░░░▀██▄░░░░░░▀▀█▄▄█▄▄▄█▄▀▀░░░░▄█▀░░░▄▄\r\n▄▄▄░░░▀▀██▄▄▄▄░░░░░░░░░░░░▄▄▄███░░░▄██▄\r\n██████▄▄░░▀█████▀█████▀██████▀▀░░▄█████\r\n██████████▄░░▀▀█▄░░░░░▄██▀▀▀░▄▄▄███▀▄██");
            Console.WriteLine($"sans: you're a natural! since you finished the level.. i think you're ready for the next level. goodluck {username}!");
            Console.ResetColor();
            Console.ReadLine();

            Console.WriteLine("\r\n░▒▓█▓▒░      ░▒▓████████▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░▒▓█▓▒░             ░▒▓███████▓▒░  \r\n░▒▓█▓▒░      ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░                    ░▒▓█▓▒░ \r\n░▒▓█▓▒░      ░▒▓█▓▒░       ░▒▓█▓▒▒▓█▓▒░░▒▓█▓▒░      ░▒▓█▓▒░                    ░▒▓█▓▒░ \r\n░▒▓█▓▒░      ░▒▓██████▓▒░  ░▒▓█▓▒▒▓█▓▒░░▒▓██████▓▒░ ░▒▓█▓▒░              ░▒▓██████▓▒░  \r\n░▒▓█▓▒░      ░▒▓█▓▒░        ░▒▓█▓▓█▓▒░ ░▒▓█▓▒░      ░▒▓█▓▒░             ░▒▓█▓▒░        \r\n░▒▓█▓▒░      ░▒▓█▓▒░        ░▒▓█▓▓█▓▒░ ░▒▓█▓▒░      ░▒▓█▓▒░             ░▒▓█▓▒░        \r\n░▒▓████████▓▒░▒▓████████▓▒░  ░▒▓██▓▒░  ░▒▓████████▓▒░▒▓████████▓▒░      ░▒▓████████▓▒░ \r\n                                                                                       \r\n                                                                                       \r\n");
            Console.WriteLine("                                   /\\\r\n                              /\\  //\\\\\r\n                       /\\    //\\\\///\\\\\\        /\\\r\n                      //\\\\  ///\\////\\\\\\\\  /\\  //\\\\\r\n         /\\          /  ^ \\/^ ^/^  ^  ^ \\/^ \\/  ^ \\\r\n        / ^\\    /\\  / ^   /  ^/ ^ ^ ^   ^\\ ^/  ^^  \\\r\n       /^   \\  / ^\\/ ^ ^   ^ / ^  ^    ^  \\/ ^   ^  \\       *\r\n      /  ^ ^ \\/^  ^\\ ^ ^ ^   ^  ^   ^   ____  ^   ^  \\     /|\\\r\n     / ^ ^  ^ \\ ^  _\\___________________|  |_____^ ^  \\   /||o\\\r\n    / ^^  ^ ^ ^\\  /______________________________\\ ^ ^ \\ /|o|||\\\r\n   /  ^  ^^ ^ ^  /________________________________\\  ^  /|||||o|\\\r\n  /^ ^  ^ ^^  ^    ||___|___||||||||||||___|__|||      /||o||||||\\\r\n / ^   ^   ^    ^  ||___|___||||||||||||___|__|||          | |\r\n/ ^ ^ ^  ^  ^  ^   ||||||||||||||||||||||||||||||oooooooooo| |ooooooo\r\nooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo");
            Console.WriteLine("-----------------------------------------------------------");

            // Loop for level 2 encounters
            while (enemycounter2 > 0)
            {
                Console.WriteLine("*while enjoyinh the cold weather in Snowdin, you saw a dancing towards you!");
                Console.WriteLine($"Are you ready {username}?");
                Console.WriteLine("[1] Yes \r\n[2] No ");

                int ch5;
                try
                {
                    ch5 = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                if (ch5 == 1)
                {
                    // Encounter loop for regular enemies
                    string[] enemies = e2.Keys.ToArray();

                    // Shuffle the array of enemies
                    for (int i = 0; i < enemies.Length; i++)
                    {
                        int randomIndex = rn.Next(i, enemies.Length);
                        string temp = enemies[randomIndex];
                        enemies[randomIndex] = enemies[i];
                        enemies[i] = temp;
                    }

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    string e2Name = enemies[0]; // Select the first enemy after shuffling
                    string visualText = e2[e2Name].Item2;
                    Console.ResetColor();

                    Console.WriteLine($"{e2Name}:\r\n{visualText}");
                    Console.WriteLine($"player encountered {e2Name}!");

                    int enemyHP = e2[e2Name].Item1 * 20; // Assigning enemy's HP based on its level

                    // Encounter loop
                    while (playerHP > 0 && enemyHP > 0)
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("________________________________________");
                        Console.WriteLine($"WEAPON: none \r\nHEALTH:{playerHP}");
                        Console.WriteLine("[1] Attack \r\n[2] Heal \r\n[3] flee");
                        int playerAction;
                        try //just fixing the players choices for combat
                        {
                            playerAction = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            continue;
                        }

                        if (playerAction == 1) // if player chooses to fight
                        {
                            // Player attacks
                            int playerDamage = 40;
                            int enemyHealth = e2[e2Name].Item1;
                            e2[e2Name] = new Tuple<int, string>(enemyHealth - playerDamage, e2[e2Name].Item2); // Update enemy's health in the dictionary

                            // if enemy's HP reaches zero
                            if (e2[e2Name].Item1 <= 0)
                            {
                                Console.WriteLine($"{e2Name} has been defeated!");
                                break; // End the loop if enemy is defeated
                            }

                            // Enemy attacks
                            if (enemyHealth > 0)
                            {
                                int enemyDamage = 20;
                                playerHP -= enemyDamage;
                                //visuals
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine($"{username} try dancing along with {e2Name} for {playerDamage}dmg! ");
                                Console.WriteLine($"The {e2Name} glared at {username} for {enemyDamage}dmg :((");
                                Console.WriteLine($"{e2Name}:\r\n{visualText}");
                                Console.WriteLine($"{username} HP: {playerHP}  {e2Name} HP: {enemyHealth}");
                                Console.ResetColor();
                                // if player's HP reaches zero
                                if (playerHP <= 0)
                                {
                                    Console.WriteLine($"you'll be better next time....");
                                    break; // End the loop if player is defeated
                                }
                            }
                        }
                        else if (playerAction == 2) // if player choose to heal
                        {
                            // Player heals
                            if (healCount > 0)
                            {
                                playerHP += 50; // Heal player
                                if (playerHP > initialPlayerHP2)
                                    playerHP = initialPlayerHP2; // Ensure player's HP doesn't exceed initial HP
                                healCount--; // Decrease heal count
                                Console.WriteLine($"{username} healed for 50 HP. {healCount} heals left.");
                            }
                            else //if player uses all heals for the level 
                            {
                                Console.WriteLine($"You have no more heals left!");
                            }
                        }
                        else if (playerAction == 3) //if player chose to leave
                        {
                            Console.WriteLine($"{username} dance away from the match!"); //just leave if you wanna skip the fight
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Invalid action!"); //if u press the wrong input
                        }
                    }
                }
                else if (ch5 == 2)
                {
                    Console.WriteLine($"sans: cheating {username}?");
                    break;
                }
                else
                {
                    Console.WriteLine($"sans: hmmm {username}?");
                    break;
                }

                enemycounter2--; // Decrement enemycounter after each encounter
            }
            // after 3 fights with the enemy, will encounter a boss level
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("*You encountered muffet, the snowdin's boss!");
            Console.ResetColor();
            int bossHP2 = bossd2.Item1; // Boss HP

            //BOSS OF LEVEL 2
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"████████▀▀░░░░░░░░░░░░░░░░░░░▀▀███████\r\n██████▀░░░░░░░░░░░░░░░░░░░░░░░░░▀██████\r\n█████░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█████\r\n████░░░░░▄▄▄▄▄▄▄░░░░░░░░▄▄▄▄▄▄░░░░░████\r\n████░░▄██████████░░░░░░██▀░░░▀██▄░░████\r\n████░░███████████░░░░░░█▄░░▀░░▄██░░████\r\n█████░░▀▀███████░░░██░░░██▄▄▄█▀▀░░█████\r\n██████░░░░░░▄▄▀░░░████░░░▀▄▄░░░░░██████\r\n█████░░░░░█▄░░░░░░▀▀▀▀░░░░░░░█▄░░░█████\r\n█████░░░▀▀█░█▀▄▄▄▄▄▄▄▄▄▄▄▄▄▀██▀▀░░█████\r\n██████░░░░░▀█▄░░█░░█░░░█░░█▄▀░░░░██▀▀▀▀\r\n▀░░░▀██▄░░░░░░▀▀█▄▄█▄▄▄█▄▀▀░░░░▄█▀░░░▄▄\r\n▄▄▄░░░▀▀██▄▄▄▄░░░░░░░░░░░░▄▄▄███░░░▄██▄\r\n██████▄▄░░▀█████▀█████▀██████▀▀░░▄█████\r\n██████████▄░░▀▀█▄░░░░░▄██▀▀▀░▄▄▄███▀▄██");
            Console.WriteLine($"sans: boss fights are unavoidable kid, press 1 to fight lol :p");
            Console.ResetColor();
            Console.WriteLine("[1] Yes");
            int ch7;
            try
            {
                ch7 = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            if (ch7 == 1)
            {
                while (playerHP > 0 && bossHP2 > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"{boss2}:\r\n{bossd2.Item2}");
                    Console.ResetColor();

                    Console.WriteLine("\n\n");
                    Console.WriteLine("________________________________________");
                    Console.WriteLine($"WEAPON: none \r\nHEALTH:{playerHP}");
                    Console.WriteLine("[1] Attack \r\n[2] Heal \r\n[3] flee");
                    int playerAction;
                    string visualText = bossd2.Item2;

                    try
                    {
                        playerAction = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        continue;
                    }

                    if (playerAction == 1)
                    {
                        // Player attacks
                        int playerDamage = 40;
                        bossHP2 -= playerDamage;

                        // Check if enemy's HP reaches zero
                        if (bossd2.Item1 <= 0)
                        {
                            Console.WriteLine($"{boss2} has been defeated!");
                            break; // End the loop if enemy is defeated
                        }

                        // Boss attacks
                        if (bossHP2 > 0)
                        {
                            int bossDamage = 30;
                            playerHP -= bossDamage;
                            Console.WriteLine("\n\n");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine($"You hit {boss2} for {playerDamage} HP");
                            Console.WriteLine($"{boss2} hit you for {bossDamage} HP");
                            Console.WriteLine($"{boss2}:\r\n{bossd2.Item2}");
                            Console.WriteLine($"PLAYER HP: {playerHP}  {boss2} HP: {bossHP2}");
                            Console.ResetColor();
                        }
                    }
                    else if (playerAction == 2)
                    {
                        // Player heals
                        if (healCount > 0)
                        {
                            playerHP += 50; // Heal player
                            if (playerHP > initialPlayerHP2)
                                playerHP = initialPlayerHP2; // Ensure player's HP doesn't exceed initial HP
                            healCount--; // Decrease heal count
                            Console.WriteLine($"{username} healed for 30 HP. {healCount} heals left.");
                        }
                        else
                        {
                            Console.WriteLine($"You have no more heals left!");
                        }
                    }
                    else if (playerAction == 3)
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("\n\n");
                        Console.WriteLine("PFFT");

                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid action!");
                    }
                }
            }
            else
            {
                Console.WriteLine("sans: no going back kiddo");
            }

            // END OF LEVEL 2

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\r\n ░▒▓██████▓▒░ ░▒▓██████▓▒░░▒▓██████████████▓▒░░▒▓███████▓▒░░▒▓█▓▒░      ░▒▓████████▓▒░▒▓████████▓▒░▒▓████████▓▒░ \r\n░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░         ░▒▓█▓▒░   ░▒▓█▓▒░        \r\n░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░         ░▒▓█▓▒░   ░▒▓█▓▒░        \r\n░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓███████▓▒░░▒▓█▓▒░      ░▒▓██████▓▒░    ░▒▓█▓▒░   ░▒▓██████▓▒░   \r\n░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░      ░▒▓█▓▒░         ░▒▓█▓▒░   ░▒▓█▓▒░        \r\n░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░      ░▒▓█▓▒░         ░▒▓█▓▒░   ░▒▓█▓▒░        \r\n ░▒▓██████▓▒░ ░▒▓██████▓▒░░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓████████▓▒░▒▓████████▓▒░  ░▒▓█▓▒░   ░▒▓████████▓▒░ \r\n                                                                                                                 \r\n                                                                                                                 \r\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("after everything,  DETERMINATION still lingers within you.");
            Console.ResetColor();


            int enemycounter3 = 2;
            playerHP = 250;
            int initialPlayerHP3 = 250;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"████████▀▀░░░░░░░░░░░░░░░░░░░▀▀███████\r\n██████▀░░░░░░░░░░░░░░░░░░░░░░░░░▀██████\r\n█████░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█████\r\n████░░░░░▄▄▄▄▄▄▄░░░░░░░░▄▄▄▄▄▄░░░░░████\r\n████░░▄██████████░░░░░░██▀░░░▀██▄░░████\r\n████░░███████████░░░░░░█▄░░▀░░▄██░░████\r\n█████░░▀▀███████░░░██░░░██▄▄▄█▀▀░░█████\r\n██████░░░░░░▄▄▀░░░████░░░▀▄▄░░░░░██████\r\n█████░░░░░█▄░░░░░░▀▀▀▀░░░░░░░█▄░░░█████\r\n█████░░░▀▀█░█▀▄▄▄▄▄▄▄▄▄▄▄▄▄▀██▀▀░░█████\r\n██████░░░░░▀█▄░░█░░█░░░█░░█▄▀░░░░██▀▀▀▀\r\n▀░░░▀██▄░░░░░░▀▀█▄▄█▄▄▄█▄▀▀░░░░▄█▀░░░▄▄\r\n▄▄▄░░░▀▀██▄▄▄▄░░░░░░░░░░░░▄▄▄███░░░▄██▄\r\n██████▄▄░░▀█████▀█████▀██████▀▀░░▄█████\r\n██████████▄░░▀▀█▄░░░░░▄██▀▀▀░▄▄▄███▀▄██");
            Console.WriteLine($"sans: you've made it! last level and you're good to go kid.");
            Console.ResetColor();
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\r\n░▒▓█▓▒░      ░▒▓████████▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░▒▓█▓▒░             ░▒▓███████▓▒░  \r\n░▒▓█▓▒░      ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░                    ░▒▓█▓▒░ \r\n░▒▓█▓▒░      ░▒▓█▓▒░       ░▒▓█▓▒▒▓█▓▒░░▒▓█▓▒░      ░▒▓█▓▒░                    ░▒▓█▓▒░ \r\n░▒▓█▓▒░      ░▒▓██████▓▒░  ░▒▓█▓▒▒▓█▓▒░░▒▓██████▓▒░ ░▒▓█▓▒░             ░▒▓███████▓▒░  \r\n░▒▓█▓▒░      ░▒▓█▓▒░        ░▒▓█▓▓█▓▒░ ░▒▓█▓▒░      ░▒▓█▓▒░                    ░▒▓█▓▒░ \r\n░▒▓█▓▒░      ░▒▓█▓▒░        ░▒▓█▓▓█▓▒░ ░▒▓█▓▒░      ░▒▓█▓▒░                    ░▒▓█▓▒░ \r\n░▒▓████████▓▒░▒▓████████▓▒░  ░▒▓██▓▒░  ░▒▓████████▓▒░▒▓████████▓▒░      ░▒▓███████▓▒░  \r\n                                                                                       \r\n                                                                                       \r\n");
            Console.WriteLine("\n\n");
            Console.WriteLine("   `,.      .   .        *   .    .      .  _    ..          .\r\n     \\,~-.         *           .    .       ))       *    .\r\n          \\ *          .   .   |    *  . .  ~    .      .  .  ,\r\n ,           `-.  .            :               *           ,-\r\n  -             `-.        *._/_\\_.       .       .   ,-'\r\n  -                 `-_.,     |n|     .      .       ;\r\n    -                    \\ ._/_,_\\_.  .          . ,'         ,\r\n     -                    `-.|.n.|      .   ,-.__,'         -\r\n      -                   ._/_,_,_\\_.    ,-'              -\r\n      -                     |..n..|-`'-'                -\r\n       -                 ._/_,_,_,_\\_.                 -\r\n         -               ,-|...n...|                  -\r\n           -         ,-'._/_,_,_,_,_\\_.              -\r\n             -  ,-=-'     |....n....|              -\r\n              -;       ._/_,_,_,_,_,_\\_.         -\r\n             ,-          |.....n.....|          -\r\n           ,;         ._/_,_,_,_,_,_,_\\_.         -\r\n  `,  '.  `.  \".  `,  '.| n   ,-.   n |  \",  `.  `,  '.  `,  ',\r\n,.:;..;;..;;.,:;,.;:,o__|__o !.|.! o__|__o;,.:;.,;;,,:;,.:;,;;:\r\n ][  ][  ][  ][  ][  |_i_i_H_|_|_|_H_i_i_|  ][  ][  ][  ][  ][\r\n                     |     //=====\\\\     |\r\n                     |____//=======\\\\____|\r\n gpyy                    //=========\\\\");
            Console.ResetColor();

            // LEVEL 3 ENEMIES (HOTLAND)
            Dictionary<string, Tuple<int, string>> e3 = new Dictionary<string, Tuple<int, string>>();
            e3.Add("Tsunderplane", new Tuple<int, string>(250, "                             |\r\n                       --====|====--\r\n                             |  \r\n\r\n                         .-\"\"\"\"\"-. \r\n                       .'_________'. \r\n                      /_/_|__|__|_\\_\\\r\n                     ;'-._       _.-';\r\n,--------------------|    `-. .-'    |--------------------,\r\n ``\"\"--..__    ___   ;       '       ;   ___    __..--\"\"``\r\n  jgs      `\"-// \\\\.._\\             /_..// \\\\-\"`\r\n              \\\\_//    '._       _.'    \\\\_//\r\n               `\"`        ``---``        `\"`"));
            e3.Add("Vulkin", new Tuple<int, string>(250, "        ___\r\n      _/ 66\\\r\n     ( \\  ^/__\r\n      \\    \\__)\r\n      /     \\\r\njgs  /      _\\\r\n    `\"\"\"\"\"``"));
            e3.Add("Pyrope", new Tuple<int, string>(300, "                 /\\\r\n                 ||\r\n   ____ (((+))) _||_\r\n  /.--.\\  .-.  /.||.\\\r\n /.,   \\\\(0.0)// || \\\\\r\n/;`\";/\\ \\\\|m|//  ||  ;\\\r\n|:   \\ \\__`:`____||__:|\r\n|:    \\__ \\T/ (@~)(~@)|\r\n|:    _/|     |\\_\\/  :|\r\n|:   /  |     |  \\   :|\r\n|'  /   |     |   \\  '|\r\n \\_/    |     |    \\_/\r\n        |     |\r\n        |_____|\r\n    jgs |_____|"));


            // BOSS BATTLE
            string boss3 = "timmie";
            Tuple<int, string> bossd3 = new Tuple<int, string>(350, "       █    █▄▀██▄▀ ▄▀ ▀▄\r\n       █▄█▄████████   ▄ █\r\n      ███████  ▀███████ █▄\r\n     ▄████▀      ▀████████\r\n▄▀▀▄████  ▀       ████████\r\n▀▄   ████     ▀  ▀ ▀██████▀▀▄\r\n   ▀▀████▄ ▀▀▄▄▀   ▄████  ▄▀\r\n     █████▄▄     ▄▄█████▀▀  ▄▄\r\n     ▀████  █▀▄▄▄▀  ████▀▀▀▀  █\r\n       ▀█▀   █  ▄    █▀ █   ▄▄▄▀\r\n             █   █▄  ▄▄█   █\r\n              █▄█  ▀▄█   █▄█ ");

            // FOR LEVEL 3
            while (enemycounter3 >= 0)
            {
                Console.WriteLine("*walking slowly through the hotland with sweaty hands, then suddenly you saw a monster coming towards you!");
                Console.WriteLine($"sans: are you ready {username}?");
                Console.WriteLine("[1] Yes \r\n[2] No ");

                int ch8;
                try
                {
                    ch8 = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                if (ch8 == 1)
                {
                    // Encounter loop for regular enemies
                    string[] enemies = e3.Keys.ToArray();

                    // Shuffle the array of enemies
                    for (int i = 0; i < enemies.Length; i++)
                    {
                        int randomIndex = rn.Next(i, enemies.Length);
                        string temp = enemies[randomIndex];
                        enemies[randomIndex] = enemies[i];
                        enemies[i] = temp;
                    }

                    string e3Name = enemies[0]; // Select the first enemy after shuffling
                    string visualText = e3[e3Name].Item2;

                    //visuals
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"{e3Name}:\r\n{visualText}");
                    Console.WriteLine($"player encountered {e3Name}!");
                    Console.ResetColor();

                    int enemyHP3 = e3[e3Name].Item1 * 20; // Assigning enemy's HP based on its level

                    // Encounter loop
                    while (playerHP > 0 && enemyHP3 > 0)
                    {
                        Console.WriteLine($"WEAPON: none \r\nHEALTH:{playerHP}");
                        Console.WriteLine("[1] Attack \r\n[2] Heal \r\n[3] flee");
                        int playerAction;
                        try //just fixing the players choices for combat
                        {
                            playerAction = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            continue;
                        }

                        if (playerAction == 1) // if player chooses to fight
                        {
                            // Player attacks
                            int playerDamage = 60;
                            int enemyHealth = e3[e3Name].Item1;
                            e3[e3Name] = new Tuple<int, string>(enemyHealth - playerDamage, e3[e3Name].Item2); // Update enemy's health in the dictionary

                            // if enemy's HP reaches zero
                            if (e3[e3Name].Item1 <= 0)
                            {
                                Console.WriteLine($"{e3Name} has been defeated!");
                                break; // End the loop if enemy is defeated
                            }

                            // Enemy attacks
                            if (enemyHealth > 0)
                            {
                                int enemyDamage = 30;
                                playerHP -= enemyDamage;
                                //visuals

                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"The {username} hit {e3Name} for {playerDamage} HP");
                                Console.WriteLine($"The {e3Name} hit {username} for {enemyDamage} HP");
                                Console.WriteLine($"{e3Name}:\r\n{visualText}");
                                Console.WriteLine($"{username} HP: {playerHP}  {e3Name} HP: {enemyHealth}");
                                Console.ResetColor();

                                // if player's HP reaches zero
                                if (playerHP <= 0)
                                {
                                    Console.WriteLine($"{username} has been defeated!");
                                    break; // End the loop if player is defeated
                                }
                            }
                        }
                        else if (playerAction == 2) // if player choose to heal
                        {
                            // Player heals
                            if (healCount > 0)
                            {
                                playerHP += 70; // Heal player
                                if (playerHP > initialPlayerHP3)
                                    playerHP = initialPlayerHP3; // Ensure player's HP doesn't exceed initial HP
                                healCount--; // Decrease heal count
                                Console.WriteLine($"{username} healed for 50 HP. {healCount} heals left.");
                            }
                            else //if player uses all heals for the level 
                            {
                                Console.WriteLine($"You have no more heals left!");
                            }
                        }
                        else if (playerAction == 3) //if player chose to leave
                        {
                            Console.WriteLine($"{username} Fleed the match!"); //just leave if you wanna skip the fight
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Invalid action!"); //if u press the wrong input
                        }
                    }
                }
                else if (ch8 == 2)
                {
                    Console.WriteLine($"sans: what {username}?");
                    break;
                }
                else
                {
                    Console.WriteLine($"sans: are you ready {username}?");
                    break;
                }

                enemycounter3--; // Decrement enemycounter after each encounter
            }

            //BOSS FIGHT FOR LEVEL 3
            // after 3 fights with the enemy, will encounter a boss level
            Console.WriteLine("*You encountered timmie, the snowdin's boss!");
            int bossHP3 = bossd3.Item1; // Boss HP

            //BOSS OF LEVEL 3
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"████████▀▀░░░░░░░░░░░░░░░░░░░▀▀███████\r\n██████▀░░░░░░░░░░░░░░░░░░░░░░░░░▀██████\r\n█████░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█████\r\n████░░░░░▄▄▄▄▄▄▄░░░░░░░░▄▄▄▄▄▄░░░░░████\r\n████░░▄██████████░░░░░░██▀░░░▀██▄░░████\r\n████░░███████████░░░░░░█▄░░▀░░▄██░░████\r\n█████░░▀▀███████░░░██░░░██▄▄▄█▀▀░░█████\r\n██████░░░░░░▄▄▀░░░████░░░▀▄▄░░░░░██████\r\n█████░░░░░█▄░░░░░░▀▀▀▀░░░░░░░█▄░░░█████\r\n█████░░░▀▀█░█▀▄▄▄▄▄▄▄▄▄▄▄▄▄▀██▀▀░░█████\r\n██████░░░░░▀█▄░░█░░█░░░█░░█▄▀░░░░██▀▀▀▀\r\n▀░░░▀██▄░░░░░░▀▀█▄▄█▄▄▄█▄▀▀░░░░▄█▀░░░▄▄\r\n▄▄▄░░░▀▀██▄▄▄▄░░░░░░░░░░░░▄▄▄███░░░▄██▄\r\n██████▄▄░░▀█████▀█████▀██████▀▀░░▄█████\r\n██████████▄░░▀▀█▄░░░░░▄██▀▀▀░▄▄▄███▀▄██");
            Console.WriteLine($"sans: boss fights are unavoidable kid, press 1 to fight lol :p");
            Console.ResetColor();
            Console.WriteLine("[1] Yes");
            int ch9;
            try
            {
                ch9 = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            if (ch9 == 1)
            {
                while (playerHP > 0 && bossHP3 > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{boss3}:\r\n{bossd3.Item2}");

                    Console.WriteLine("\n\n");
                    Console.WriteLine("________________________________________");
                    Console.WriteLine($"WEAPON: none \r\nHEALTH:{playerHP}");
                    Console.WriteLine("[1] Attack \r\n[2] Heal \r\n[3] flee");
                    Console.ResetColor();

                    int playerAction;
                    string visualText = bossd3.Item2;

                    try
                    {
                        playerAction = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        continue;
                    }

                    if (playerAction == 1)
                    {
                        // Player attacks
                        int playerDamage = 40;
                        bossHP3 -= playerDamage;

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"{boss3}:\r\n{visualText}");
                        Console.WriteLine($"You hit {boss3} for {playerDamage} HP");
                        Console.WriteLine($"PLAYER HP:{playerHP}  {boss3} HP:{bossHP3}");
                        Console.Clear();

                        // Check if enemy's HP reaches zero
                        if (bossd3.Item1 <= 0)
                        {
                            Console.WriteLine($"{boss3} has been defeated!");
                            break; // End the loop if enemy is defeated
                        }

                        // Boss attacks
                        if (bossHP3 > 0)
                        {
                            int bossDamage = 20;
                            playerHP -= bossDamage;
                            Console.WriteLine($"{boss3} hit you for {bossDamage} HP");
                            Console.WriteLine($"{boss3}:\r\n{bossd2.Item2}");
                            Console.WriteLine($"PLAYER HP: {playerHP}  {boss3} HP: {bossHP3}");
                        }
                    }
                    else if (playerAction == 2)
                    {
                        // Player heals
                        if (healCount > 0)
                        {
                            playerHP += 70; // Heal player
                            if (playerHP > initialPlayerHP3)
                                playerHP = initialPlayerHP3; // Ensure player's HP doesn't exceed initial HP
                            healCount--; // Decrease heal count
                            Console.WriteLine($"{username} healed for 30 HP. {healCount} heals left.");
                        }
                        else
                        {
                            Console.WriteLine($"You have no more heals left!");
                        }
                    }
                    else if (playerAction == 3)
                    {
                        Console.WriteLine("hOi");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid action!");
                    }
                }
            }
            else
            {
                Console.WriteLine("sans: no going back kiddo");
            }

            //OUTRO

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"████████▀▀░░░░░░░░░░░░░░░░░░░▀▀███████\r\n██████▀░░░░░░░░░░░░░░░░░░░░░░░░░▀██████\r\n█████░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█████\r\n████░░░░░▄▄▄▄▄▄▄░░░░░░░░▄▄▄▄▄▄░░░░░████\r\n████░░▄██████████░░░░░░██▀░░░▀██▄░░████\r\n████░░███████████░░░░░░█▄░░▀░░▄██░░████\r\n█████░░▀▀███████░░░██░░░██▄▄▄█▀▀░░█████\r\n██████░░░░░░▄▄▀░░░████░░░▀▄▄░░░░░██████\r\n█████░░░░░█▄░░░░░░▀▀▀▀░░░░░░░█▄░░░█████\r\n█████░░░▀▀█░█▀▄▄▄▄▄▄▄▄▄▄▄▄▄▀██▀▀░░█████\r\n██████░░░░░▀█▄░░█░░█░░░█░░█▄▀░░░░██▀▀▀▀\r\n▀░░░▀██▄░░░░░░▀▀█▄▄█▄▄▄█▄▀▀░░░░▄█▀░░░▄▄\r\n▄▄▄░░░▀▀██▄▄▄▄░░░░░░░░░░░░▄▄▄███░░░▄██▄\r\n██████▄▄░░▀█████▀█████▀██████▀▀░░▄█████\r\n██████████▄░░▀▀█▄░░░░░▄██▀▀▀░▄▄▄███▀▄██");
            Console.WriteLine($"sans: well kid, it was nice beeing with you again. hope you'll still remember to come back heheheheh. congratulations!");
            Console.ResetColor();

            Console.WriteLine($"\r\n ░▒▓██████▓▒░ ░▒▓██████▓▒░░▒▓███████▓▒░ ░▒▓██████▓▒░░▒▓███████▓▒░ ░▒▓██████▓▒░▒▓████████▓▒░▒▓███████▓▒░▒▓█▓▒░ \r\n░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ ░▒▓█▓▒░  ░▒▓█▓▒░      ░▒▓█▓▒░ \r\n░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ ░▒▓█▓▒░  ░▒▓█▓▒░      ░▒▓█▓▒░ \r\n░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒▒▓███▓▒░▒▓███████▓▒░░▒▓████████▓▒░ ░▒▓█▓▒░   ░▒▓██████▓▒░░▒▓█▓▒░ \r\n░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ ░▒▓█▓▒░         ░▒▓█▓▒░▒▓█▓▒░ \r\n░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ ░▒▓█▓▒░         ░▒▓█▓▒░       \r\n ░▒▓██████▓▒░ ░▒▓██████▓▒░░▒▓█▓▒░░▒▓█▓▒░░▒▓██████▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ ░▒▓█▓▒░  ░▒▓███████▓▒░░▒▓█▓▒░ \r\n                                                                                                              \r\n                                                                                                              \r\n                                                                                                              \r\n                                                                                                              \r\n                                                                                                              \r\n                                                                                                              \r\n                                                                                                              \r\n                                                                                                              \r\n                                                                                                              \r\n                                                                                                              \r\n                                                                                                              \r\n");
            Console.WriteLine($"@  *  .  . *       *    .        .        .   *    ..\r\n @. /\\ *     ###     .      .        .            *\r\n @ /  \\  *  #####   .     *      *        *    .\r\n ]/ [] \\  ######### *    .  *       .  //    .  *   .\r\n / [][] \\###\\#|#/###   ..    *     .  //  *  .  ..  *\r\n |  __  | ###\\|/###  *    *  ___o |==// .      *   *\r\n |  |!  |  # }}|{{  #         /\\  \\/  //|\\\r\n |  ||  |    }}|{{    ejm97  / /        | \\\r\n                           ` `        '  '");
            Console.WriteLine($"------------------------------------------------------------------------------------------------------------------------");
        }

    }
}

        
    

