using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введиче число > 0");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 0;
            
            int slag;


            if (n > 0)
            {
                for (slag = 1; slag <= 2 * n - 1; slag=slag+2)
                {

                 
                    int sum = slag + b;
                    Console.WriteLine(sum);
                    b = sum;
                    
                    

                }
            }
            else
            {
                Console.WriteLine("Введено число < или = 0. Поробуйте еще раз.");
            }

            Console.ReadKey();
        }
    }
}
