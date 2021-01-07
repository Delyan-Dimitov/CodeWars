using System;
using System.Collections.Generic;
using System.Linq;

namespace Snail__4kyu_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] r =
            {
           new []{1, 2, 3, 9},
           new []{4, 5, 6, 4},
           new []{7, 8, 9, 1},
           new []{ 1, 2, 3, 4},
            };
            Console.WriteLine(Snail(r)); 
        }
        public static int[] Snail(int[][] array)
        {


            for (int i = 0; i < array.GetLength(0); i++)
            {
                var current = array[i];
                if (current.Length == 0)
                {
                    return new int[0];
                }
            }

            int n = array.GetLength(0);
            int finalListLength = n * n;
            var final = new List<int>();
            var result = new int[finalListLength];
            final = GetLayer(array, n - 1, 0, 0, final, finalListLength);
            result = final.ToArray();
            return result;
        }

        public static List<int> GetLayer(int[][] array, int length, int firstIndex, int secondIndex, List<int> final, int finalListLength)
        {
            if (length - 1 == secondIndex)
            {
                final.Add(array[firstIndex][secondIndex]);
                final.Add(array[firstIndex][length]);
                final.Add(array[length][length]);
                final.Add(array[length][secondIndex]);
                return final;
            }
            else if(final.Count + 1 == finalListLength)
            {
                final.Add(array[firstIndex][secondIndex]);
                return final;
            }
            for (int k = secondIndex; k <= length; k++)
            {
                final.Add(array[firstIndex][k]);
            }
            for (int i = firstIndex + 1; i <= length; i++)
            {
                final.Add(array[i][length]);
            }

            for (int i = length - 1; i >= secondIndex; i--)
            {
                final.Add(array[length][i]);
            }

            for (int i = length - 1; i > firstIndex; i--)
            {
                final.Add(array[i][secondIndex]);
            }

            if (final.Count < finalListLength)
            {
                GetLayer(array, length - 1, firstIndex + 1, secondIndex + 1, final, finalListLength);
            }

            return final;
        }
    }
}
