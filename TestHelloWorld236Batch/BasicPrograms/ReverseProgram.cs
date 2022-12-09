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
    }
}
