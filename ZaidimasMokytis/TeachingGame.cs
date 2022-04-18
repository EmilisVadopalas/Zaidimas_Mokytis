using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaidimasMokytis
{
    public static class TeachingGame
    {
        //kuris moko vaikus dalybos. Paleidus programą yra parodoma lygtis,
        //pvz: “64 / 4 = “. Kursorius gale mirksi laukdamas atsakymo.
        //Pakartoti jei neteisingai ir parašyti, kad neteisinga

        public static void StartGame()
        {
            AskDivisionQuestion();

            while (true)
            {
                Console.WriteLine("********************************************");
                Console.WriteLine("*                   Meniu                  *");
                Console.WriteLine("********************************************");
                Console.WriteLine("********************************************");
                Console.WriteLine("*           Dalybos klausimas - dlk        *");
                Console.WriteLine("********************************************");
                Console.WriteLine("*           Daugybos klausimas - dgk       *");
                Console.WriteLine("********************************************");
                Console.WriteLine("*            Uzdaryti zaidima - uz         *");
                Console.WriteLine("********************************************");
                Console.WriteLine("\nJusu pasirinkimas ?");
                var meniuChoice = Console.ReadLine();

                if (meniuChoice.Trim().ToLower() == "uz")
                {
                    System.Environment.Exit(0);
                }
                else if (meniuChoice.Trim().ToLower() == "dlk")
                {
                    AskDivisionQuestion();
                }
                else if (meniuChoice.Trim().ToLower() == "dgk")
                {
                    AskMultiplicationQuestion();
                }

            }
        }

        public static void AskDivisionQuestion()
        {
            while (true)
            {
                Random random = new Random();
                var number1 = random.Next(1, 10);
                var number2 = random.Next(1, 10);

                var multipliedNumber = number1 * number2;

                var solved = false;

                while (!solved)
                {
                    Console.WriteLine("Jei norite iseiti iveskite \"q\" raide  (quit)");
                    Console.WriteLine("Dalybos klausimas :");
                    Console.WriteLine($"{multipliedNumber} / {number1} = ?");                   
                    Console.WriteLine("Iveskite atsakyma :");

                    var atsakymas = Console.ReadLine();

                    if (atsakymas.Trim().ToLower() == "q")
                    {
                        return;
                    }

                    if (int.TryParse(atsakymas, out var number))
                    {
                        if (number == number2)
                        {
                            solved = true;
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Teisingai !");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Neteisingai, bandykite dar");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ivedete ne skaiciu, bandykite dar karta...");
                    }
                }
            }
        }

        public static void AskMultiplicationQuestion()
        {
            while (true)
            {
                Random random = new Random();
                var number1 = random.Next(1, 10);
                var number2 = random.Next(1, 10);

                var multipliedNumber = number1 * number2;

                var solved = false;

                while (!solved)
                {
                    Console.WriteLine("Jei norite iseiti iveskite \"q\" raide  (quit)");
                    Console.WriteLine("Daugybos klausimas :");
                    Console.WriteLine($"{number1} x {number2} = ?");                   
                    Console.WriteLine("Iveskite atsakyma :");

                    var atsakymas = Console.ReadLine();

                    if (atsakymas.Trim().ToLower() == "q")
                    {
                        return;
                    }

                    if (int.TryParse(atsakymas, out var number))
                    {
                        if (number == multipliedNumber)
                        {
                            solved = true;
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Teisingai !");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Neteisingai, bandykite dar");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ivedete ne skaiciu, bandykite dar karta...");
                    }
                }
            }
        }
    }
}
