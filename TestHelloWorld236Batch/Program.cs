using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloWorld236Batch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HelloWorld");
            //className variable=new className()
            Calculator calculator = new Calculator();
            //"20" -> 20
            calculator.AdditionTwoNumbers();
            Console.ReadLine();
        }
    }
}
