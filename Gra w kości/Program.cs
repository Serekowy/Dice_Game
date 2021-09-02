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
            string ver = "0.0.3";
            string path = $@"Dice_Game_{ver}.txt";
            int money = 0, bet = 0;
            
            Console.Title = $"Gra w kości by Adiks, wersja {ver}";
            Console.ForegroundColor = ConsoleColor.Cyan;

            money = Class2.start(path);

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Stan konta: {money} AC");
                bet = Class2.bet(money);

                Random random = new Random();

                Console.WriteLine("Kliknij enter, aby rzucić kostką.");
                Console.ReadKey();
                Console.Clear();

                int dice = random.Next(1, 7);

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Thread.Sleep(500);
                Console.WriteLine("Wyrzuciłeś...");
                

                int player = Class2.dice(dice);

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Thread.Sleep(1500);
                Console.WriteLine("Komputer wyrzucił...");
                

                dice = random.Next(1, 7);
                
                int pc = Class2.dice(dice);

                money += Class2.result(player, pc, bet);

                money = Class2.loser(money);

                var file = new List<string>(File.ReadAllLines(path));
                file.RemoveAt(1);
                file.Add(money.ToString());
                File.WriteAllLines(path, file.ToArray());

                Console.ReadKey();
                Console.Clear();
            }  
        }
    }
}
