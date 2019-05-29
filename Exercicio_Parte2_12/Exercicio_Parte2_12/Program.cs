using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Parte2_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiroNumero = 0;
            int segundoNumero = 0;
            int terceiroNumero = 0;

            Console.Write("Digite o Primeiro Número: ");
            primeiroNumero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Segundo Número: ");
            segundoNumero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Terceiro Número: ");
            terceiroNumero = int.Parse(Console.ReadLine());

            if (primeiroNumero > segundoNumero && primeiroNumero > terceiroNumero)
            {
                Console.WriteLine("O maior Número é: {0}", primeiroNumero);
            }

            else if (segundoNumero > primeiroNumero && segundoNumero > terceiroNumero)
            {
                Console.WriteLine("O maior Número é: {0}", segundoNumero);
            }

            else
            {
                Console.WriteLine("O maior Número é: {0}", terceiroNumero);
            }
        }
    }
}
