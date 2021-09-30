using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("===================================================================================");
            Console.WriteLine("A sequência de Fibonacci é constituída da soma dos números anteriores na contagem, ");
            Console.WriteLine("ou seja, o terceiro número é o resultado da soma dos dois números anteriores.");
            Console.WriteLine("Ex.: 0 1 1 2 3 5... -> onde 0 + 1 = 1, 1 + 1 = 2, 2 + 1 = 3...");
            Console.WriteLine("===================================================================================");
            Console.WriteLine("Quer descobrir se um número faz parte da sequência? Digite ele aqui: ");
            int NumeroInserido = int.Parse(Console.ReadLine());
            
            int numero1 = 0;
            int numero2 = 1;
            int SomaTotal = 0;
            for (var i = 1; i < NumeroInserido; i++)
            {
                numero1 = numero2;
                numero2 = SomaTotal;
                SomaTotal = numero1 + numero2;
                if (SomaTotal == NumeroInserido)
                {
                    Console.WriteLine($"O número {NumeroInserido}, que você informou, faz parte da sequência de Fibonacci.");
                    break;
                }
            }
            if (SomaTotal > NumeroInserido)
            {
                Console.WriteLine($"O número {NumeroInserido}, que você informou, não faz parte da sequência Fibonacci.");
            }
            
            Console.WriteLine("Fim do algoritmo.");
            Console.WriteLine("===================================================================================");
        }
    }
}
