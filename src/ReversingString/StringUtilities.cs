using System;

namespace CodingChallenge.ReversingString
{
    public class StringUtilities
    {
        public static string Reverse(string s)
        {
            if (s == null) return null;
            var characterArray = s.ToCharArray();
            Array.Reverse(characterArray);
            return new string(characterArray);
        }
    }
}
