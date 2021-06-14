using System;
using System.Collections.Generic;
using System.Text;

namespace Task01_Anagram
{
    public static class StringExtension
    {
        // Extension methods
        /// <summary>
        /// Swap all letters in an expression.
        /// </summary>
        /// <param name="str">Input string</param>
        /// <returns>A string in which all letters are in reverse order</returns>
        /// 
        public static string SwapWordsLetters(this string str)
        {
            string[] temp = str.Split(' ');
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = ReverseWord(temp[i]);
            }

            return String.Join(" ", temp);
        }

        private static string ReverseWord(string str)
        {
            char[] stringСharacters = str.ToCharArray();

            for (int i = 0, k = stringСharacters.Length - 1; i < k;)
            {
                if (Char.IsLetter(stringСharacters[i]))
                {
                    if (Char.IsLetter(stringСharacters[k]))
                    {
                        char tmp = stringСharacters[i];
                        stringСharacters[i] = stringСharacters[k];
                        stringСharacters[k] = tmp;
                        i++;
                        k--;
                    }
                    else k--;
                }
                else i++;
            }
            return new string(stringСharacters);
        }
    }
}
