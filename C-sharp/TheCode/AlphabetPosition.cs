using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TheCode
{
    public class AlphabetPosition
    {
        /*
         In this kata you are required to, given a string, replace every letter with its position in the alphabet.
         If anything in the text isn't a letter, ignore it and don't return it.
            a being 1, b being 2, etc.         
         */

        public static string Replace(string text)
        {
            var letters = new List<char>
            {
                'a',
                'b',
                'c',
                'd',
                'e',
                'f',
                'g',
                'h',
                'i',
                'j',
                'k',
                'l',
                'm',
                'n',
                'o',
                'p',
                'q',
                'r',
                's',
                't',
                'u',
                'v',
                'w',
                'x',
                'y',
                'z'
            };
            var sb = new StringBuilder(text.Length);
            foreach (char c in text.ToLower())
            {
                if (char.IsLetter(c))
                {
                    sb.Append($"{letters.IndexOf(c)+1} ");
                }
            }

            return sb.ToString().Trim();
        }

        /*
         * Best solution:
              public static string AlphabetPosition(string text)
              {
                 return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a'+1));
              }
         */
    }
}
