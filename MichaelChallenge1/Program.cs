using System;
using System.Collections.Generic;
using System.Linq;

namespace MichaelChallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "this$is?the!string";
            Console.WriteLine(input);
            Console.WriteLine(ReverseString(input));
            Console.WriteLine(FindAndReverseWords(input));
        }
        static string ReverseString(string str)
        {
            string toReturn = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                toReturn += str[i];
            }
            return toReturn;
        }
        static string FindAndReverseWords(string str)
        {
            string toReturn = "";
            string tempWord;
            for (int i = 0; i < str.Length; i++)
            {
                tempWord = "";
                while (Char.IsLetter(str[i]) && i != str.Length - 1)
                {
                    tempWord += str[i];
                    i++;
                }
                if (i == str.Length - 1)
                {
                    tempWord += str[i];
                } 
                tempWord = ReverseString(tempWord);
                if (i != str.Length - 1)
                {
                    tempWord += str[i];
                }
                toReturn += tempWord;
            }
            return toReturn;
        }
    }
}
