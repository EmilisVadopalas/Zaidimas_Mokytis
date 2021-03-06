using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaidimasMokytis
{
    public static class ArrayExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="addedInt">adds to the end of array</param>
        /// <returns>return new array with changes</returns>
        public static int[] Add(this int[] array, int addedInt)
        {
            var newArray = new int[array.Length + 1];

            for(int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            newArray[array.Length] = addedInt;

            return newArray;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="addedInt">adds to the end of array</param>
        /// <returns>return new array with changes</returns>
        public static string[] Add(this string[] oldArray, string addedString)
        {
            //1. susikuriam nauja array +1 dydzio
            var newArray = new string[oldArray.Length + 1];

            //2. is seno array reiksmes perkeliam i nauja
            for (int i = 0; i < oldArray.Length; i++)
            {
                newArray[i] = oldArray[i];
            }

            //3. pridedam i nauja arreju papildoma reiksme
            newArray[oldArray.Length] = addedString;

            //4. grazinam nauja array
            return newArray;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="indexOfRemoved">Index of element i array to be removed</param>
        /// <returns>return new array with changes</returns>
        public static int[] Remove(this int[] array, int indexOfRemoved)
        {
            var newArray = new int[array.Length - 1];

            for (int i = 0; i < array.Length; i++)
            {
                if (i != indexOfRemoved)
                {
                    if (i > indexOfRemoved)
                    {
                        newArray[i-1] = array[i];
                    }
                    else
                    {
                        newArray[i] = array[i];
                    }
                }
            }

            return newArray;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="indexOfRemoved">Index of element i array to be removed</param>
        /// <returns>return new array with changes</returns>
        public static string[] Remove(this string[] array, int indexOfRemoved)
        {
            var newArray = new string[array.Length - 1];

            for (int i = 0; i < array.Length; i++)
            {
                if (i != indexOfRemoved)
                {
                    if (i > indexOfRemoved)
                    {
                        newArray[i - 1] = array[i];
                    }
                    else
                    {
                        newArray[i] = array[i];
                    }
                }
            }

            return newArray;
        }

        public static void PrintOut(this string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"index: {i.ToString().PadLeft(3)}    value: {array[i]}");
            }
        }
    }
}
