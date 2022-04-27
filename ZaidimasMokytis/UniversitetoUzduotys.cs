using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaidimasMokytis
{
    public static class UniversitetoUzduotys
    {

        public delegate void PrintinimoDelegatas();

        public static void PirmaUzduotis()
        {
            var masyvas = CreateArrayList();

            while (true)
            {
                var pasirinkimas = GetUserAction();

                if (pasirinkimas == "add")
                {
                    masyvas = Add(masyvas);
                }
                else if (pasirinkimas == "delete")
                {
                    masyvas = Delete(masyvas);
                }
                else if (pasirinkimas == "quit")
                {
                    return;
                }
            }
        }        

        public static void AntraUzduotisWithDelagate()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Pasirinkite ka nupiesti: ");
                Console.WriteLine("1: NumberTriangleOne");
                Console.WriteLine("2: NumberTriangleTwo");
                Console.WriteLine("3: TriangleOne");
                Console.WriteLine("4: TriangleTwo");
                Console.WriteLine("5: TriangleThree");
                Console.Write("pasirinkite (1-5 arba q (quit)): ");
                var choice = Console.ReadLine();

                PrintinimoDelegatas PrintTriangle = null;

                if (choice == "q")
                {
                    return;
                }
                else if (choice == "1")
                {
                    PrintTriangle = NumberTriangleOne;
                }
                else if (choice == "2")
                {
                    PrintTriangle = NumberTriangleTwo;
                }
                else if (choice == "3")
                {
                    PrintTriangle = TriangleOne;
                }
                else if (choice == "4")
                {
                    PrintTriangle = TriangleTwo;
                }
                else if (choice == "5")
                {
                    PrintTriangle = TriangleThree;
                }

                PrintTriangle();

                Console.WriteLine("\nSpauskite ENTER");
                Console.ReadLine();
            }
        }

        public static void AntraUzduotis()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Pasirinkite ka nupiesti: ");
                Console.WriteLine("1: NumberTriangleOne");
                Console.WriteLine("2: NumberTriangleTwo");
                Console.WriteLine("3: TriangleOne");
                Console.WriteLine("4: TriangleTwo");
                Console.WriteLine("5: TriangleThree");
                Console.Write("pasirinkite (1-5 arba q (quit)): ");
                var choice = Console.ReadLine();                

                if (choice == "q")
                {
                    return;
                }
                else if (choice == "1")
                {
                    NumberTriangleOne();                    
                }
                else if (choice == "2")
                {
                    NumberTriangleTwo();
                }
                else if (choice == "3")
                {
                    TriangleOne();
                }
                else if (choice == "4")
                {
                    TriangleTwo();
                }
                else if (choice == "5")
                {
                    TriangleThree();
                }

                Console.WriteLine("\nSpauskite ENTER");
                Console.ReadLine();
            }
        }

        public static void TreciaUzduotis()
        {
            var nNepasirinktas = true;
            var n = 0;
            var aNepasirinktas = true;
            var a = 0;
            var mNepasirinktas = true;
            var m = 0;

            while (nNepasirinktas)
            {
                Console.WriteLine("Pasirinkite kokio ilgio nelyginiu skaiciu seka spauzdinti (N)");
                Console.Write("N = ");
                var nPossibly = Console.ReadLine();

                if (int.TryParse(nPossibly, out n))
                {
                    nNepasirinktas = false;
                }
            }

            while (aNepasirinktas)
            {
                Console.WriteLine("Pasirinkite nuo kokio skaiciaus seka prasideda (A)");
                Console.Write("A = ");
                var aPossibly = Console.ReadLine();

                if (int.TryParse(aPossibly, out a))
                {
                    aNepasirinktas = false;
                }
            }

            while (mNepasirinktas)
            {
                Console.WriteLine("Pasirinkite kas kiek sekos nariu paklausti ar sustoti (M)");
                Console.Write("M = ");
                var mPossibly = Console.ReadLine();

                if (int.TryParse(mPossibly, out m))
                {
                    mNepasirinktas = false;
                }
            }

            a = ((a % 2) == 0) ? a + 1 : a;
            
            var nCounter = 0;

            while(nCounter <= n)
            {
                Console.WriteLine(a);
                a += 2;
                nCounter++;

                if((nCounter % m) == 0)
                {                    
                    Console.WriteLine("jei norite sustoti rasykite 'q' ir spaukite ENTER");
                    Console.WriteLine("jei norite testi tiesiog spaukite ENTER");

                    if(Console.ReadLine() == "q")
                    {
                        return;
                    }                    
                }
            }

        }

        #region PrivatesFirst

            public static string[] Add(string[] masyvas)
        {
            Console.Clear();
            Console.WriteLine($"Iveskite koki teksta nori prideti ir spauskite ENTER kai baigsite");
            Console.Write("Jusu pridedamas tekstas: ");
            var addedText = Console.ReadLine();

            masyvas = masyvas.Add(addedText); 

            Console.WriteLine("Masyvas pakoreguotas\n");
            Console.WriteLine($"Masyvo ilgis {masyvas.Length}\n");
            Console.WriteLine("Masyvo duomenys:\n");
            masyvas.PrintOut();
            Console.WriteLine("\n\nTesti ? Spauskite ENTER");
            Console.ReadLine();

            return masyvas;
        }

        public static string[] Delete(string[] masyvas)
        {
            var nepasirinkta = true;
            int index = -1;
            while (nepasirinkta)
            {
                Console.Clear();
                Console.WriteLine($"Iveskite koki indeksa ties kurio norite istrinti irasa is masyvo (nuo 0 iki {masyvas.Length - 1})");
                Console.Write("indeksas: ");
                var indekasas = Console.ReadLine();

                if (int.TryParse(indekasas, out index) && index >= 0 && index < masyvas.Length)
                {
                    nepasirinkta = false;
                }
            }

            masyvas = masyvas.Remove(index);

            Console.WriteLine("Masyvas pakoreguotas\n");
            Console.WriteLine($"Masyvo ilgis {masyvas.Length}\n");
            Console.WriteLine("Masyvo duomenys:\n");
            masyvas.PrintOut();
            Console.WriteLine("\n\nTesti ? Spauskite ENTER");
            Console.ReadLine();

            return masyvas;
        }

        public static string GetUserAction()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("*******************************************************");
                Console.WriteLine("*                         Meniu                       *");
                Console.WriteLine("*******************************************************");
                Console.WriteLine("*******************************************************");
                Console.WriteLine("*        Prideti skaiciu i masyvo gala - add          *");
                Console.WriteLine("*******************************************************");
                Console.WriteLine("*   Istrinti is masyvo irasa pagal indeksa - delete   *");
                Console.WriteLine("*******************************************************");
                Console.WriteLine("*               uzdaryti programa - quit              *");
                Console.WriteLine("*******************************************************");
                Console.Write("\nJusu pasirinkimas: ");
                var pasirinkimas = Console.ReadLine();

                pasirinkimas = pasirinkimas.Trim().ToLower();

                if (pasirinkimas == "add" || pasirinkimas == "delete" || pasirinkimas == "quit")
                {
                    return pasirinkimas;
                }
            }
        }

        public static string[] CreateArrayList()
        {
            var nepasirinktasMasyvoDydis = true;
            string[] masyvas = new string[1];

            while (nepasirinktasMasyvoDydis)
            {
                Console.WriteLine("Iveskite kokio dydzio (N) bus jusu masyvas..");
                Console.Write("N = ");
                var n = Console.ReadLine();

                if (int.TryParse(n, out int lenght))
                {
                    nepasirinktasMasyvoDydis = false;
                    masyvas = new string[lenght];

                    for (int i = 0; i < lenght; i++)
                    {
                        Console.Write($"I masyvo {i} dedame: ");
                        masyvas[i] = Console.ReadLine();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("iveskite skaiciu..");
                }
            }

            return masyvas;
        }

        #endregion

        #region PrivatesSecond

        public static void NumberTriangleOne()
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }

                Console.WriteLine();
            }
        }

        public static void NumberTriangleTwo()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }
        }

        public static void TriangleOne()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("|");
                }

                Console.Write("_\n");
            }
        }

        public static void TriangleTwo()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }
        }

        public static void TriangleThree()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }

            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }
        }

        #endregion
    }
}
