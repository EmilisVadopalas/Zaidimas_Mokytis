using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaidimasMokytis
{
    public static class UniversitetoUzduotys
    {
        public static void PirmaUzduotis()
        {
            var masyvas = CreateArrayList();

            while (true)
            {
                var pasirinkimas = GetUserAction();

                if (pasirinkimas == "add")
                {
                    Add(masyvas);
                }
                else if (pasirinkimas == "delete")
                {
                    Delete(masyvas);
                }
                else if (pasirinkimas == "quit")
                {
                    return;
                }
            }
        }

        #region Privates

        public static void Add(string[] masyvas)
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
        }

        public static void Delete(string[] masyvas)
        {
            var nepasirinkta = false;
            int index = -1;
            while (nepasirinkta)
            {
                Console.Clear();
                Console.WriteLine($"Iveskite koki indeksa ties kurio norite istrinti irasa is masyvo (nuo 0 iki {masyvas.Length-1}");
                Console.Write("indeksas: ");
                var indekasas = Console.ReadLine();

                if(int.TryParse(indekasas, out index) && index >= 0 && index < masyvas.Length)
                {
                    nepasirinkta = false;
                }
            }
            
            masyvas = masyvas.Remove(index);

            Console.WriteLine("Masyvas pakoreguotas\n");
            Console.WriteLine($"Masyvo ilgis {masyvas.Length}\n");
            Console.WriteLine("Masyvo duomenys:\n");
            masyvas.PrintOut();
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

                if(pasirinkimas == "add" || pasirinkimas == "delete" || pasirinkimas == "quit")
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
    }
}
