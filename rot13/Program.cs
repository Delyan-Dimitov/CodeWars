using System;
using System.Text;
using System.Text.RegularExpressions;

namespace rot13
{
    class Program
    {
        // What i tried and failed
        static void Main(string[] args)
        {
            Console.WriteLine(Rot13("Grfg"));
        }
        public static string Rot13(string message)
        {
            int incrementor = 13;
            var sb = new StringBuilder();
            for (int i = 0; i < message.Length; i++)
            {
                char current = message[i];
                if (Regex.IsMatch(current.ToString(), "^[A-Z]*$"))
                {
                    if ((int)current >= 110)
                    {
                        sb.Append((char)(current - (char)incrementor));
                    }
                    sb.Append((char)(current + (char)incrementor));
                }
               
                else if (Regex.IsMatch(current.ToString(), "^[A-Z]*$"))
                {
                    if ((int)current >= 78)
                    {
                        sb.Append((char)(current - (char)incrementor));
                    }
                    sb.Append((char)(current + (char)incrementor));
                }
                else
                {
                    sb.Append(current);
                }

            }
            return sb.ToString().Trim();
        }
    }
}
