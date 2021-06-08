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
            string ver = "0.0.2";
            string path = $@"Dice_Game_{ver}.txt";
            int money = 0, bet = 0;
            
            Console.Title = $"Gra w kości by Adiks, wersja {ver}";

            money = Class2.start(path);

            while (true)
            {
                Console.WriteLine($"Stan konta: {money} AC");
                bet = Class2.bet(money);

                Random random = new Random();

                Console.WriteLine("Kliknij enter, aby rzucić kostką.");
                Console.ReadKey();

                int dice = random.Next(1, 7);

                Console.WriteLine("Wyrzuciłeś...");
                Thread.Sleep(1000);
                int player = Class2.dice(dice);

                Console.WriteLine("Rzutu dokonuje teraz komputer.");
                Thread.Sleep(2000);

                dice = random.Next(1, 7);

                Console.WriteLine("Komputer wyrzucił...");

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
