using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloWorld236Batch.BasicPrograms
{
    class ReverseProgram
    {
        public static void ReverseNumber(int number)//1234
        {
            int remainder = 0,reverse = 0;
            while (number != 0)
            {
                remainder = number % 10; //4  
                reverse = (reverse * 10) + remainder; // 4
                number = number / 10; //123
                //Console.WriteLine("Remainder:{0} number:{1} reverse:{2}", remainder, number, reverse);
            }

            Console.WriteLine("Reverse number is:"+reverse);
        }

        public static void ReverseWord(string word)//1234
        {
            string reverse = "";
            char[] setOfCharacters=word.ToCharArray();
            Console.WriteLine("Displaying each character");
            for (int i = 0; i < setOfCharacters.Length; i++)
            {
                Console.Write(setOfCharacters[i] + " ");
            }
            for (int i = 0; i < setOfCharacters.Length; i++)
            {
                reverse= setOfCharacters[i]+ reverse;
            }
            Console.WriteLine("\n"+reverse);

            if (word==reverse)
            {
                Console.WriteLine("It's a Palindrome");
            }
            else
            {
                Console.WriteLine("It's not a palindrome");
            }
        }
    }
}
