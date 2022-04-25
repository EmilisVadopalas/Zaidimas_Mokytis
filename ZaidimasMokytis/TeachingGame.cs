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
                Console.Clear();
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
                Console.WriteLine("*         amziaus skaiciuokle - ak         *");
                Console.WriteLine("********************************************");
                Console.WriteLine("*           Daugybos lentele - dl          *");
                Console.WriteLine("********************************************");
                Console.WriteLine("*              Uzdaryti - uz               *");
                Console.WriteLine("********************************************");
                Console.WriteLine("\nJusu pasirinkimas ?");
                var meniuChoice = Console.ReadLine();

                if (meniuChoice.Trim().ToLower() == "uz")
                {
                    Environment.Exit(0);
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
                    GeoTask();
                }
                else if (meniuChoice.Trim().ToLower() == "ak")
                {
                    AgeCalculator();
                }
                else if (meniuChoice.Trim().ToLower() == "dl")
                {
                    MultiplicationTable();
                }
                else if (meniuChoice.Trim().ToLower() == "pol")
                {
                    Console.WriteLine("dar nera");
                }
            }
        }

        public static void MultiplicationTable()
        {      
            for (int i = 2; i < 10; i+=4)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i.ToString().PadLeft(2)} x {j.ToString().PadRight(2)} = {(i * j).ToString().PadLeft(3)}" +
                        $"    " +
                        $"{(1+i).ToString().PadLeft(2)} x {j.ToString().PadRight(2)} = {((1 + i) * j).ToString().PadLeft(3)}" +
                        $"    " +
                        $"{(2+i).ToString().PadLeft(2)} x {j.ToString().PadRight(2)} = {((2 + i) * j).ToString().PadLeft(3)}" +
                        $"    " +
                        $"{(3+i).ToString().PadLeft(2)} x {j.ToString().PadRight(2)} = {((3 + i) * j).ToString().PadLeft(3)}");

                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("Grizti i meniu - spauskite Enter");
            Console.ReadLine();
        }

        private static void AgeCalculator()
        {
            Console.Clear();
            var error = string.Empty;

            while (true)
            {
                if (!string.IsNullOrEmpty(error))
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($"{error} \n");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.WriteLine("Jei norite iseiti iveskite \"q\" raide  (quit) \n");
                Console.Write("Iveskite gimimo metus: ");
                var yearOfBirth = Console.ReadLine();
                var month = 0;
                var day = 0;

                if (yearOfBirth == "q") return;

                if (int.TryParse(yearOfBirth, out var year))
                {
                    if (year > DateTime.Now.Year)
                    {
                        error = $"dabar yra {DateTime.Now.Year} metai zmogus negali but gimes {year} (jis dar negimes)";
                        continue;
                    }
                }
                else
                {
                    error = $"iveskite metus pvz: 1995, '{yearOfBirth}' netinka";
                    continue;
                }

                error = string.Empty;
                var monthNotSelected = true;

                while (monthNotSelected)
                {
                    Console.Clear();

                    if (!string.IsNullOrEmpty(error))
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($"{error} \n");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.WriteLine("Jei norite iseiti iveskite \"q\" raide  (quit) \n");
                    Console.Write("Iveskite gimimo menesi (skaiciumi): ");
                    var monthOfBirth = Console.ReadLine();

                    if (monthOfBirth == "q") return;

                    if (int.TryParse(monthOfBirth, out month))
                    {
                        if (month > 12 || month < 1)
                        {
                            error = $"iveskite menesi nuo 1 iki 12... {month} netinka";
                            continue;
                        }
                        else
                        {
                            monthNotSelected = false;
                        }
                    }
                    else
                    {
                        error = $"iveskite menesio skaiciu pvz: 9, '{monthOfBirth}' netinka";
                        continue;
                    }
                }

                error = string.Empty;
                var dayNotSelected = true;

                while (dayNotSelected)
                {
                    Console.Clear();

                    if (!string.IsNullOrEmpty(error))
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($"{error} \n");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.WriteLine("Jei norite iseiti iveskite \"q\" raide  (quit) \n");
                    Console.Write("Iveskite gimimo diena (skaiciumi): ");
                    var dayOfBirth = Console.ReadLine();

                    if (dayOfBirth == "q") return;

                    if (int.TryParse(dayOfBirth, out day))
                    {
                        if (day > DateTime.DaysInMonth(year, month) || day < 1)
                        {
                            error = $"{year}-{month} menesis turi nuo 1 iki {DateTime.DaysInMonth(year, month)} dienu..., {day} netinka";
                            continue;
                        }
                        else
                        {
                            dayNotSelected = false;
                        }
                    }
                    else
                    {
                        error = $"iveskite dienos skaiciu pvz: 20, '{day}' netinka";
                        continue;
                    }
                }

                var today = DateTime.Today;
                var age = today.Year - year;
                var monthDiff = today.Month - month;
                var dayDiff = today.Day - day;

                if (dayDiff < 0)
                {
                    monthDiff--;
                }
                if (monthDiff < 0)
                {
                    age--;
                }

                Console.Clear();
                
                Console.WriteLine($"\nApskaiciuotas amazius: {age} \n ");

                Console.WriteLine("Jei norite iseiti iveskite \"q\" raide  (quit) \n");
                Console.WriteLine("jei norite kartoti spauskite ENTER ");
                if (Console.ReadLine() == "q") return;
            }
        }

        private static void GeoTask()
        {
            var atsakymas = "x";
            bool firstIteration = true;

            while (true)
            {
                Console.Clear();

                if (atsakymas.Trim().ToLower() == "a")
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("teisingai !");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("paspauskite Enter kad griztumete i meniu");
                    Console.ReadLine();
                    return;

                }
                else if (atsakymas.Trim().ToLower() == "b" || atsakymas.Trim().ToLower() == "c" || atsakymas.Trim().ToLower() == "d")
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Neteisingai :( \n");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (!firstIteration)
                {
                    Console.WriteLine("Pasirinkite viena is: a, b, c, d, - arba q - noredami grizti i pagrindini meniu");
                }
                Console.WriteLine("Jei norite iseiti iveskite \"q\" raide  (quit) \n");
                Console.WriteLine("Koks natūralus išteklis Afganistane yra gausus ir itin reikalingas baterijų technologijai?");
                Console.WriteLine("a: Litis");
                Console.WriteLine("b: Gelezis");
                Console.WriteLine("c: Fosforas");
                Console.WriteLine("d: Silikonas \n");
                Console.Write("Pasirinkite teisinga atasakyma: ");
                
                firstIteration=false;

                atsakymas = Console.ReadLine();
                Console.WriteLine("\n");                
            }
        }

        private static void MathMeniu()
        {
            while (true)
            {
                Console.Clear();
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
                    return;
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
            Console.Clear();

            while (true)
            {
                Random random = new Random();
                var number1 = random.Next(1, 10);
                var number2 = random.Next(1, 10);

                var multipliedNumber = number1 * number2;

                var solved = false;

                while (!solved)
                {                    
                    Console.WriteLine("Jei norite iseiti iveskite \"q\" raide  (quit) \n");
                    Console.WriteLine("Dalybos klausimas :");
                    Console.WriteLine($"{multipliedNumber} / {number1} = ?");                   
                    Console.Write("Iveskite atsakyma :");

                    var atsakymas = Console.ReadLine();

                    Console.Clear();

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
            Console.Clear();

            while (true)
            {
                Random random = new Random();
                var number1 = random.Next(1, 10);
                var number2 = random.Next(1, 10);

                var multipliedNumber = number1 * number2;

                var solved = false;

                while (!solved)
                {
                    Console.WriteLine("Jei norite iseiti iveskite \"q\" raide  (quit) \n");
                    Console.WriteLine("Daugybos klausimas :");
                    Console.WriteLine($"{number1} x {number2} = ?");                   
                    Console.Write("Iveskite atsakyma :");

                    var atsakymas = Console.ReadLine();

                    Console.Clear();

                    if (atsakymas.Trim().ToLower() == "q")
                    {
                        return;
                    }

                    if (int.TryParse(atsakymas, out int number))
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
