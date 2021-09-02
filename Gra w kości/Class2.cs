using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_kości
{
    class Class2
    {
        public static int loser(int money)
        {
            if (money < 50)
            {
                Console.ReadKey();
                Console.Clear();
                Class1.sadFace();
                Console.WriteLine("Przegrałeś wszystkie Adiks Coiny :(");
                Console.WriteLine("Dostaniesz 1000 abyś mógł grać dalej :D");
                Console.WriteLine("Miłej zabawy! Pamiętaj, żeby znowu nie przegrać...");
                return 1000;
            }
            return money;
        }
        public static int start(string path)
        {
            string name;
            bool spr;
            int money;

            if (!File.Exists(path))
            {
                Console.Write("Wprowadź swoje imię: ");
                name = Console.ReadLine();
                Class1.info(name);
                File.AppendAllText(path, name + "\n" + 1000);
                spr = int.TryParse(File.ReadLines(path).Skip(1).Take(1).First(), out money);
                return money;
            }
            else
            {
                name = File.ReadLines(path).Skip(0).Take(1).First();
                Class1.welcome(name);
                spr = int.TryParse(File.ReadLines(path).Skip(1).Take(1).First(), out money);
                return money;
            }
        }
        public static int result(int pnumber, int pcnumber, int bet)
        {
            if (pnumber > pcnumber)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Wygrywasz! +{bet} AC");
                Console.ResetColor();
                return bet;
            }
            else if (pnumber < pcnumber)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Niestety, komputer wygrał -{bet} AC ;c");
                Console.ResetColor();
                return -bet;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Remis! Adiks Coiny wracają do Ciebie");
                Console.ResetColor();
                return 0;
            }
        }
        public static int dice(int rand)
        {
            switch (rand)
            {
                case 1:
                    Class1.dice1();
                    return 1;
                case 2:
                    Class1.dice2();
                    return 2;
                case 3:
                    Class1.dice3();
                    return 3;
                case 4:
                    Class1.dice4();
                    return 4;
                case 5:
                    Class1.dice5();
                    return 5;
                case 6:
                    Class1.dice6();
                    return 6;
                default:
                    return 0;
            }
        }
        public static int bet(int ac)
        {
            bool spr = false;
            int bet = 0;

            while (!spr)
            {
                Console.Write("Wpisz ilość Adiks Coinów: ");
                string pos = Console.ReadLine();
                spr = int.TryParse(pos, out bet);
                if (spr == false)
                {
                    Console.Clear();
                    Console.WriteLine($"Stan konta: {ac} AC");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Musisz wprowadzić liczbę.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (bet < 50)
                {
                    Console.Clear();
                    Console.WriteLine($"Stan konta: {ac} AC");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Minimalna stawka to 50AC.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    spr = false;
                }
                else if (bet > ac)
                {
                    Console.Clear();
                    Console.WriteLine($"Stan konta: {ac} AC");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Nie masz tyle Adiks Coinów.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    spr = false;
                }
                continue;
            }
            return bet;
        }
    }
}
