using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloWorld236Batch
{
    class TypesOfVariables
    {
        /// <summary>
        /// Default constructor- it will intialize default value
        /// Initializes a new instance of the <see cref="TypesOfVariables"/> class.
        /// </summary>
        public TypesOfVariables()
        {
            Console.WriteLine("Default constructor");
        }
        

        /// <summary>
        /// it will intialized parameterized
        /// Parameterized constructor
        /// Initializes a new instance of the <see cref="TypesOfVariables"/> class.
        /// </summary>
        /// <param name="phone">The phone.</param>
        public TypesOfVariables(int phone)
        {
            Console.WriteLine("Parameterized constructor");
        }
        /// <summary>
        /// local variable age - score is only to the method.
        /// </summary>
        public static void StudentAge(int phoneNumber)
        {
            // local variable age
            int age = 0;

            age = age + 10;
            Console.WriteLine("Student age is {0} and phone number is {1} : ",age, phoneNumber);
        }
    }
}
