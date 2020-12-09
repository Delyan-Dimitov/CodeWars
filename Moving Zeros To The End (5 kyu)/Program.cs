using System;

namespace Moving_Zeros_To_The_End__5_kyu_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", MoveZeroes(new int[] {1,2,3,4,0,0,0,0,0,5,6,7,0,1,2 })));
        }
            public static int[] MoveZeroes(int[] arr)
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    bool done = false;
                    if (arr[i] == 0)
                    {
                        while (arr[i] == 0)
                        {
                            var zeroCount = 0;
                            var nonZeroCount = 0;
                            for (int k = 0; k < i; k++)
                            {
                                if (arr[k] == 0)
                                {
                                    zeroCount++;
                                var maikavietupa;
                                    break;

                                }
                            }
                            for (int j = i; j < arr.Length; j++)
                            {

                                if (arr[j] != 0)
                                {
                                    nonZeroCount++;
                                    break;
                                }
                            }
                            if (nonZeroCount == 0 && zeroCount == 0)
                            {
                                done = true;
                                break;
                            }
                            else
                            {
                                arr = shiftLeft(arr, i);
                            }
                        }
                        if (done)
                        {
                            break;
                        }
                    }
                }
                return arr;
            }
            public static int[] shiftLeft(int[] arr, int index)
            {
                for (int i = index; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[arr.Length - 1] = 0;
                return arr;
            }
        }
    }

