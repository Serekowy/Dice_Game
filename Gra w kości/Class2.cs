using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_kości
{
    class Class2
    {
        public static int result(int pnumber, int pcnumber, int bet)
        {
            if (pnumber > pcnumber)
            {
                Console.WriteLine($"Wygrywasz! + {bet} AC");
                return bet;
            }
            else if (pnumber < pcnumber)
            {
                Console.WriteLine($"Niestety, komputer wygrał - {bet} AC ;c");
                return -bet;
            }
            else
            {
                Console.WriteLine("Remis! Adiks Coiny wracają do Ciebie");
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
                if (bet < 50)
                {
                    Console.WriteLine("Minimalna stawka to 50AC.");
                    spr = false;
                }
                if (bet > ac)
                {
                    Console.WriteLine("Nie masz tyle Adiks Coinów.");
                    spr = false;
                }
                continue;
            }
            return bet;
        }
    }
}
