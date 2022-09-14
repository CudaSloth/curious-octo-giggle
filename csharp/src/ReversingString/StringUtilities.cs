using System;

namespace CodingChallenge.ReversingString
{
    public class StringUtilities
    {
        public static string Reverse(string s)
        {
            string s_local = "";

            if (string.IsNullOrEmpty(s))
            {
                throw new ArgumentException($"{nameof(s)} cannot be null or empty!");
            }

            for (int i = 0; i < s.Length; ++i)
            {
                s_local += s.Substring((s.Length - i) - 1, 1);
            }

            return s_local;
        }
    }
}
