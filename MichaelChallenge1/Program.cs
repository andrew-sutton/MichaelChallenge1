using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            // loop for going through the entire word
            for (int i = 0; i < str.Length; i++)
            {
                //Resetting the temporary word
                tempWord = "";
                //we are trying to find either a special symbol or the end of the entire string. If either of these conditions are met, the while will be false and break out.
                while (Char.IsLetter(str[i]) && i != str.Length - 1)
                {
                    //just collecting the word until the symbol or the end of the string hits
                    tempWord += str[i];
                    i++;
                }
                // this only takes place when we hit the end of the string. it was leaving off the last letter, because it was treating it like a special symbol
                if (i == str.Length - 1 && Char.IsLetter(str[i]))
                {
                    tempWord += str[i];
                } 
                // reversing the word that was found. This does not contain the special symbol
                tempWord = ReverseString(tempWord);
                // tacking on the special symbol, this won't happen at the end of the string if all we have is letters. 
                if (!Char.IsLetter(str[i]))
                {
                    tempWord += str[i];
                }
                toReturn += tempWord;
            }
            return toReturn;
        }
    }
}
