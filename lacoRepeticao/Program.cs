using System;

namespace lacoRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            int IndiceContagem = 13;
            int SomaTotal = 0;
            int K = 0;

            while (K < IndiceContagem)
            {
                K += 1;
                SomaTotal += K;
            }

            Console.WriteLine($"O resultado do algoritmo é: {SomaTotal}");                
        }
    }
}
