using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            Console.WriteLine("Insert A , B , C :");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            bool resultA=A>B;
            bool resultB=B>C;


            if (resultA && resultB)
            {

                A = 2 * A;
                B = 2 * B;
                C = 2 * C;

            }

            else
            {
                A -= 2 * A;
                B -= 2 * B;
                C -= 2 * C;

            }
                 
          
            Console.WriteLine("A = "+A+"\n"+"B = "+B+"\n"+"C = "+C);
        }
    }
}
