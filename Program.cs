using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12
{
    class Program
    {
        static void Main(string[] args)

        {
            //Declaring variables
            float sum = 0.0f, sum1 = 1.0f, num = 1.0f;
            int n = 2;

            //Calculated
            while ((sum1 - sum) > 0.001)
            {
                if (n % 2 == 0)
                {
                    Console.Write(" {0}", num);
                    sum = sum1;
                    sum1 = sum1 + (1 / n);
                    num = 1 / n;
                    n++;
                }
                else
                {
                    Console.Write(" {0}", num);
                    sum = sum1;
                    sum1 = sum1 -(1 / n);
                    num = -(1 / n);
                    n++;
                }
            }

            //Showing results
            Console.Write(" The sum of the entire series is: {0}", sum1);

            Console.ReadKey();
        }
    }
}
