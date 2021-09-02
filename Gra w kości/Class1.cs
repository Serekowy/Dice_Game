using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_kości
{
    class Class1
    {
        public static void welcome(string name)
        {
            Console.WriteLine($"Witaj ponownie {name}, życzymy miłej gry.");
        }
        public static void info(string name)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Witaj {name}, w grze w kości, poniżej znajdziesz wszelkie informacje (wyświetlają się tylko przy pierwszym uruchomieniu programu).");
            Console.WriteLine("Po rozpoczęciu rozgrywki gracz dostaje 1000 Adiks Coinów w skrócie AC. Zapamiętaj to, ponieważ AC będzie podstawową walutą w tej grze.");
            Console.WriteLine();
            Console.WriteLine("Gra polega na losowaniu (rzucaniu) kością razem z komputerem, jeżeli liczba oczek na kostce będzie wyższa niż ta od komputera, gracz zgarnia postawioną kwotę do portfela, w przeciwnym wypadku gracz traci walutę. Podczas gdy komputer i gracz wylosują tą samą liczbę, postawiona kwota wraca do gracza ;).");
            Console.WriteLine();
            Console.WriteLine("Nie musisz się również martwić, gdy będziesz chciał zakończyć rozgrywkę, ponieważ gra automatycznie się zapisuje oznacza to, że nie stracisz postępu w grze i będziesz mógł wrócić kiedy tylko będziesz chciał z tą samą ilością AC.");
            Console.WriteLine();
            Console.WriteLine("To na tyle w tym dosyć długim, ale jakże treściwym wstępie, mam nadzieję, że gra się spodoba :D");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("Aby rozpocząć grę naciśnij dowolny przycisk...");
            Console.ReadKey();
            Console.Clear();
        }
        public static void dice1()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------------");
            Console.WriteLine("-           -");
            Console.WriteLine("-           -");
            Console.WriteLine("-     O     -");
            Console.WriteLine("-           -");
            Console.WriteLine("-           -");
            Console.WriteLine("-------------");
            Console.ResetColor();
        }
        public static void dice2()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------------");
            Console.WriteLine("-        O  -");
            Console.WriteLine("-           -");
            Console.WriteLine("-           -");
            Console.WriteLine("-           -");
            Console.WriteLine("-  O        -");
            Console.WriteLine("-------------");
            Console.ResetColor();
        }
        public static void dice3()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------------");
            Console.WriteLine("-        O  -");
            Console.WriteLine("-           -");
            Console.WriteLine("-     O     -");
            Console.WriteLine("-           -");
            Console.WriteLine("-  O        -");
            Console.WriteLine("-------------");
            Console.ResetColor();
        }
        public static void dice4()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------------");
            Console.WriteLine("-  O     O  -");
            Console.WriteLine("-           -");
            Console.WriteLine("-           -");
            Console.WriteLine("-           -");
            Console.WriteLine("-  O     O  -");
            Console.WriteLine("-------------");
            Console.ResetColor();
        }
        public static void dice5()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------------");
            Console.WriteLine("-  O     O  -");
            Console.WriteLine("-           -");
            Console.WriteLine("-     O     -");
            Console.WriteLine("-           -");
            Console.WriteLine("-  O     O  -");
            Console.WriteLine("-------------");
            Console.ResetColor();
        }
        public static void dice6()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------------");
            Console.WriteLine("-  O  O  O  -");
            Console.WriteLine("-           -");
            Console.WriteLine("-           -");
            Console.WriteLine("-           -");
            Console.WriteLine("-  O  O  O  -");
            Console.WriteLine("-------------");
            Console.ResetColor();
        }
        public static void sadFace()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
 @"
+---------------------------+
|                           |
|                           |
|                           |
|   xxxx          xxxxx     |
|   xxxx          xxxxx     |
|   xxxx          xxxxx     |
|   xxxx          xxxxx     |
|                           |
|                           |
|   xxxxxxxxxxxxxx          |
|   xxxxxxxxxxxxxx          |
|   xxx         xx          |
|   xxx         xx          |
|                           |
+---------------------------+
");

            Console.ResetColor();
        }
    }
}
