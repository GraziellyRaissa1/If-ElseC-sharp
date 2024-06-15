using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseCsharp
{
    internal class Exemplo03
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua idade para saber se pode ingerir bebidas alcoólica ou não!");

            int idade = Convert.ToInt32(Console.ReadLine());
            if (idade < 18)
            {
                Console.WriteLine("Não pode beber");
            }
            else
            {
                Console.WriteLine("Pode beber");
            }
        }
    }
}
