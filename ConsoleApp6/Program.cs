using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;


            Console.Write("Digite o valor do a :");
            a = Convert.ToDouble(Console.ReadLine());
           
            Console.Write("Digite o valor do b :");
            b = Convert.ToDouble(Console.ReadLine());
           
            Console.Write("Digite o valor do c: ");
            c = Convert.ToDouble(Console.ReadLine());
           
             delta = b * b - 4 * a * c;

            if (delta < 0)
            {

                Console.Write("nao existe raiz real");

            }


            else
            {

                x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                x2 = (-b - Math.Sqrt(delta)) / 2 * a;
               
                Console.WriteLine($"o valor e x1 é: {x1}");
                Console.WriteLine($"o valor e x1 é: {x2}");
            }

              
            
            
        }
    }
}
