using System;
using System.Text;

namespace ExtendString
{
    public static class StringExtensions
    {
        private static Random random;

        static StringExtensions()
        {
            random = new Random();
        }
        
        public static string ToRandom(this string s)
        {
            StringBuilder sb = new();

            foreach (char c in s)
            {
                if (random.NextDouble() < 0.5)
                {
                    sb.Append(char.ToUpper(c));
                }
                else
                {
                    sb.Append(char.ToLower(c));
                }
            }

            return sb.ToString();
        }
    }
}