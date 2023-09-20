using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Permutations
{
    public static List<string> SinglePermutations(string s)
    {
        HashSet<string> permutations = new HashSet<string>();
        GetPermutations(0, s.ToCharArray(), permutations);
        return permutations.ToList();
    }

    public static void GetPermutations(int index, char[] arr, HashSet<string> permutations)
    {
        if (index == arr.Length)
        {
            permutations.Add(string.Join("", arr));
            return;
        }

        for (int i = index; i < arr.Length; i++)
        {
            Swap(ref arr[index], ref arr[i]);
            GetPermutations(index + 1, arr, permutations);
            Swap(ref arr[index], ref arr[i]);
        }

    }

    public static int HowManyPermutations(int countOfElements)
    {
        return Enumerable.Range(1, countOfElements).Aggregate(1, (p, item) => p * item);
    }

    public static void Swap(ref char firstElement, ref char secondElement)
    {
        var temp = firstElement;
        firstElement = secondElement;
        secondElement = temp;
    }
}
