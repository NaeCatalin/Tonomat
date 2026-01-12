using System;
using System.Runtime.Intrinsics.Arm;

namespace Tonomat
{
    class Program
    {
        static void Main()
        {
            int suma = 0;
            bool continuare = true;


            Console.WriteLine("===Tonomat===");
            Console.WriteLine("Pret Sticla Pepsi:8 lei");
            Console.WriteLine("Pret Nuga: 4 lei");
            Console.WriteLine("Pret Apa: 4 lei");
            Console.WriteLine("Pret Fresh Cola: 6.00 lei");
            Console.WriteLine("Pret biscuiti: 4.00 lei");
            Console.WriteLine("Pret Sandwich: 10.00 lei");
            Console.WriteLine("Monede Acceptate: 1, 5, 10 lei");
            Console.WriteLine("1 = 1 Lei");
            Console.WriteLine("5 = 5 Lei ");
            Console.WriteLine("10 = 10 Lei ");
            Console.WriteLine("X = Iesi");

            while (continuare)
            {
                Console.WriteLine($"\nSuma curenta: {suma} lei");
                Console.WriteLine("Alege produs:");
                Console.WriteLine("1 - Pepsi (8 lei)");
                Console.WriteLine("2 - Nuga (4 lei)");
                Console.WriteLine("3 - Apa (4 lei)");
                Console.WriteLine("4 - Fresh Cola (6 lei)");
                Console.WriteLine("5 - Biscuiti (4 lei)");
                Console.WriteLine("6 - Sandwich (10 lei)");

                Console.Write("Optiune: ");
                char produse = Console.ReadKey().KeyChar;
                Console.WriteLine();

                int pret = 0;
                string produs = "";




                switch (produse)
                {
                    case '1': pret = 8; produs = "Pepsi"; break;
                    case '2': pret = 4; produs = "Nuga"; break;
                    case '3': pret = 4; produs = "Apa"; break;
                    case '4': pret = 6; produs = "Fresh Cola"; break;
                    case '5': pret = 4; produs = "Biscuiti"; break;
                    case '6': pret = 10; produs = "Sandwich"; break;
                    case 'X':
                        continuare = false; continue;
                    default:
                        Console.WriteLine("Optiune invalida. Incearca din nou.");
                        continue;
                }

                while (suma < pret)
                {
                    Console.Write("Introdu moneda (1, 5, 10 lei): ");
                    int moneda = int.Parse(Console.ReadLine());

                    if (moneda == 1 || moneda == 5 || moneda == 10) 
                    suma += moneda;
                    else
                        Console.WriteLine("Moneda invalida. Incearca din nou.");
                }
                Console.WriteLine($"\n>>> Produs eliberat:{produs}");
                int rest = suma - pret;
                if (rest > 0)
                {
                    Console.WriteLine($">>> Rest: {rest} lei");
                    Darest(rest);
                }

                suma = 0;
                Console.WriteLine("Tonomatul a fost resetat");

            }
        }
        static void Darest(int rest)
        {
            if (rest >= 10)
            {
                int zecelei = rest / 10;
                Console.WriteLine($">>> {zecelei} x 10 lei");
                rest = 10;
            }
            if (rest >= 5)
            {
                int cinciLei = rest / 5;
                Console.WriteLine($">>> {cinciLei} x 5 lei");
                rest -= 5;
            }
            if (rest >= 1)
            {
                int unuLei = rest / 1;
                Console.WriteLine($">>> {unuLei} x 1 lei");
                rest -= 1;
            }
        }
    }
}