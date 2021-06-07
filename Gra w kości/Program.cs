using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Gra_w_kości
{
    class Program
    {
        static void Main(string[] args)
        {
            string ver = "0.0.1";
            string path = $@"Dice_Game_{ver}.txt";
            int money = 0, bet = 0;
            string name;
            bool spr;

            Console.Title = $"Gra w kości by Adiks, wersja {ver}";
       
            if (!File.Exists(path))
            {
                Console.Write("Wprowadź swoje imię: ");
                name = Console.ReadLine();
                Class1.info(name);
                File.AppendAllText(path, name + "\n" + 1000);
            }
            else
            {
                name = File.ReadLines(path).Skip(0).Take(1).First();
                spr = int.TryParse(File.ReadLines(path).Skip(1).Take(1).First(), out money);
            }
        tutaj:
            spr = false;

            Console.WriteLine($"Stan konta: {money} AC");
            bet = Class2.bet(money);

            Random random = new Random();

            Console.WriteLine("Kliknij enter, aby rzucić kostką.");
            Console.ReadKey();

            int dice = random.Next(1, 7);

            Console.WriteLine("Wyrzuciłeś...");
            int player = Class2.dice(dice);

            Console.WriteLine("Rzutu dokonuje teraz komputer.");
            Thread.Sleep(2000);

            dice = random.Next(1, 7);

            Console.WriteLine("Komputer wyrzucił...");
            int pc = Class2.dice(dice);

            money += Class2.result(player, pc, bet);

            Console.ReadKey();
            Console.Clear();
            goto tutaj;
        }
    }
}
