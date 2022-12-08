using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelloWorld236Batch
{
    class Marks
    {
        // These variables are instance variables.
        // These variables are in a class and
        // are not inside any function
        public int engMarks;
        public  int mathsMarks;
        public int phyMarks;

        public void MarksDeatils()
        {
            Console.WriteLine("EngMarks:{0} Maths:{1} Physics:{2}",engMarks,mathsMarks,phyMarks);
        }

    }

}
