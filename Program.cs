using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] studMarks = new int[4, 5]; 

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter Roll No for student {0}: ", i + 1);
                studMarks[i, 0] = Convert.ToInt32(Console.ReadLine());

                for (int j = 1; j < 5; j++)
                {
                    Console.Write("Enter Sem{0} marks for student {1}: ", j, i + 1);
                    studMarks[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("RollNo\tSem1\tSem2\tSem3\tSem4\tTotal");
            for (int i = 0; i < 4; i++)
            {
                int totalMarks = 0;
                Console.Write(studMarks[i, 0] + "\t"); 

                for (int j = 1; j < 5; j++)
                {
                    Console.Write(studMarks[i, j] + "\t");
                    totalMarks += studMarks[i, j];
                }

                Console.WriteLine(totalMarks);
            }

            Console.ReadLine();
        }
    }
}



