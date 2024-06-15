using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseCsharp
{
    internal class Exemplo04
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");

            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 10)
            {
                Console.WriteLine("Parabéns, você ganhou 15% de desconto!.");
            }
            else if (numero < 20)
            {
                Console.WriteLine("Parabéns, você ganhou 10% de desconto!");
            }
            else
            {
                Console.WriteLine("Parabéns, você genhou 5% de desconto!");
            }
        }
    }
}
