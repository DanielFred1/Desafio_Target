using System;

namespace InversaoString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("----------------------- Inversão de String -----------------------");
            Console.WriteLine("Esse algoritmo recebe uma frase inserida e inverte a sequência dos ");
            Console.WriteLine("caracteres. Insira uma frase e faça o teste:");
            string palavraInserida = Console.ReadLine();

            char[] inversor = palavraInserida.ToCharArray();
            string palavraInvertida = String.Empty;
            for (var i = inversor.Length - 1; i >= 0; i--)
            {
                palavraInvertida += inversor[i];
            }           
            

            Console.WriteLine();
            Console.WriteLine($"A frase inserida foi: {palavraInserida}");
            Console.WriteLine($"A frase invertida resultante é: {palavraInvertida}");
            Console.WriteLine("------------------------ Fim do Algoritmo -------------------------");
        }
    }
}
