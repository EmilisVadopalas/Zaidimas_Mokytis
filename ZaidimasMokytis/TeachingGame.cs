using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaidimasMokytis
{
    public static class TeachingGame
    {
        public static void MainMeniu()
        {
            while (true)
            {
                // matematikos, geografijos, lietuvių kalbos, politologijos
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                Console.WriteLine("********************************************");
                Console.WriteLine("*                 Meniu                    *");
                Console.WriteLine("********************************************");
                Console.WriteLine("********************************************");
                Console.WriteLine("*             Matematika - mat             *");
                Console.WriteLine("********************************************");
                Console.WriteLine("*             Lietuviu - liet              *");
                Console.WriteLine("********************************************");
                Console.WriteLine("*             Geografija - geo             *");
                Console.WriteLine("********************************************");
                Console.WriteLine("*            Politologija - pol            *");
                Console.WriteLine("********************************************");
                Console.WriteLine("*              Uzdaryti - uz               *");
                Console.WriteLine("********************************************");
                Console.WriteLine("\nJusu pasirinkimas ?");
                var meniuChoice = Console.ReadLine();

                if (meniuChoice.Trim().ToLower() == "uz")
                {
                    System.Environment.Exit(0);
                }
                else if (meniuChoice.Trim().ToLower() == "mat")
                {
                    MathMeniu();
                }
                else if (meniuChoice.Trim().ToLower() == "liet")
                {
                    Console.WriteLine("dar nera");
                }
                else if (meniuChoice.Trim().ToLower() == "geo")
                {
                    Console.WriteLine("dar nera");
                }
                else if (meniuChoice.Trim().ToLower() == "pol")
                {
                    Console.WriteLine("dar nera");
                }
            }
        }

        private static void MathMeniu()
        {
            while (true)
            {
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                Console.WriteLine("********************************************");
                Console.WriteLine("*          Matematikos Meniu               *");
                Console.WriteLine("********************************************");
                Console.WriteLine("********************************************");
                Console.WriteLine("*        Dalybos klausimas - dlk           *");
                Console.WriteLine("********************************************");
                Console.WriteLine("*        Daugybos klausimas - dgk          *");
                Console.WriteLine("********************************************");
                Console.WriteLine("*      Grizti i pagrindini Meniu - uz      *");
                Console.WriteLine("********************************************");
                Console.WriteLine("\nJusu pasirinkimas ?");
                var meniuChoice = Console.ReadLine();

                if (meniuChoice.Trim().ToLower() == "uz")
                {
                    MainMeniu();
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

        private static void AskDivisionQuestion()
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

                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

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

        private static void AskMultiplicationQuestion()
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

                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

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
