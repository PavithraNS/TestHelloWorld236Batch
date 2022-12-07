using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloWorld236Batch
{
    class Calculator
    {
        public void AdditionTwoNumbers()
        {
            int firstNumber=0, secondNumber=0;

            Console.WriteLine("Please enter 1st number");
            firstNumber = Convert.ToInt32(Console.ReadLine()); //"10" -> 10
            Console.WriteLine("Please enter 2nd number");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            int result = firstNumber + secondNumber;
            Console.WriteLine("Sum:"+result);
        }
    }
}
