using System.Runtime.CompilerServices;

namespace Valor_teclado
{
    internal class Program
    {
        static void Main()
        {
            int v1, v2, soma;

            Console.Write("Digite o primeiro valor: ");
            v1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            v2 = Convert.ToInt32(Console.ReadLine());

            soma = v1 + v2;
            Console.WriteLine("A soma de {0} mais {1} é igual a {2}", v1, v2, soma);


            // Convert.ToInt32()  - 32 é o tamanho do inteiro (int)
            //conversão de string (que vem do teclado) para um número inteiro.
        }
    }
}