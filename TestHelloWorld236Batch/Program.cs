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
            Calculator c = new Calculator();
            //int sum = c.AdditionTwoNumbers();
            Console.WriteLine("Sum of 2 numbers:{0}", c.AdditionTwoNumbers());
            Console.WriteLine("enter user name");
            string userName=Console.ReadLine();
            Console.WriteLine("enter your batch name");
            string batchName = Console.ReadLine();
            Console.WriteLine("hello {0}, welcome to the {1} batch", userName, batchName);
            Console.ReadLine();
        }
    }
}
