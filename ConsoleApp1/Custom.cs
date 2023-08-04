using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Custom
    {
        public static int CustomLastIndexOf(this string sentence, char letter)
        {
            for (int i = sentence.Length - 1; i >= 0; i--)
            {
                if (sentence[i] == letter)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int CustomVowelCounter(this string text)
        {

            int vowelCount = 0;
            //char[] vowels = { 'a', 'e', 'o', 'u', 'i', 'A', 'E', 'O', 'U', 'I' };
            string vowels = "aeouiAEOUI";

            foreach (char letter in text)
            {
                if (!vowels.Contains(letter))
                {
                    vowelCount++;
                }
            }
            return vowelCount;
        }

       public static string CustomTrim(this string text)
        {
            int start = 0;
            int end = text.Length - 1;
            string result = "";

            while(start <= end && Char.IsWhiteSpace(text[start]))
            {
                start++;
            }

            while (start >= end && Char.IsWhiteSpace(text[end]))
            {
                end--;
            }

            for (int i = start; i < end; i++)
            {
                result += text[i];
            }

            return result;
        }

       public static string CustomOldTrim(this string text)
        {
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (!Char.IsWhiteSpace(text[i]))
                {
                    result += text[i];
                }
            }

            return result;
        }
    }
}