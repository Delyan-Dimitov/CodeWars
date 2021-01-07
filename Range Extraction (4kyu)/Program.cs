namespace Range_Extraction__4kyu_
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] { -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20 };
            Console.WriteLine(Extract(input));
        }
        public static string Extract(int[] args)
        {
            var list = new List<string>();
            for (int i = 0; i < args.Length; i++) //i = -3
            {
                var streakCount = 0;
                var currentElement = args[i];
                var nextElementIndex = i + 1;
                if (i == args.Length - 1)
                {
                   list.Add(args[i].ToString());
                    return String.Join(",", list);
                }
                while (currentElement + 1 == args[nextElementIndex]) // 
                {
                    currentElement = args[nextElementIndex];
                    streakCount++;
                    if (nextElementIndex == args.Length - 1)
                    {
                        break;
                    }
                    else
                    {
                        nextElementIndex++;
                    }

                }
                if (streakCount >= 2)
                {
                    var first = args[i];
                    var last = args[i + streakCount];
                    i += streakCount;
                    list.Add($"{first}-{last}");
                }
                else
                {
                    list.Add($"{args[i]}");
                }
            }
            return String.Join(",", list);
        }
    }
}
