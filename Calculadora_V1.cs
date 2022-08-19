using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o primeiro numero e aguarde!");
                int entrada = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escolha o segundo numero e aguarde!");
                int entrada2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escolha um Operador (+,-,*,/)");
                var escolha =Console.ReadLine();
            
            switch (escolha)
              
            {

                case "+":
                    Console.WriteLine($" O resultado é {entrada + entrada2}");
                    break;
                case "-":
                    Console.WriteLine($" O resultado é {entrada - entrada2}");
                    break;
                case "*":
                    Console.WriteLine($" O resultado é {entrada * entrada2}");
                    break;
                case "/":
                    Console.WriteLine($" O resultado é {entrada / entrada2}");
                    break;
                   
            }
            Console.ReadLine();
        }
    }
}
