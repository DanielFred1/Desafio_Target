using System;
using System.Collections.Generic;

namespace FaturamentoMensal
{
    public class Estado
    {
        public string Sigla { get; set; }
        public double Faturamento { get; set; }

        public Estado(string sigla, double faturamento)
        {
            Sigla = sigla;
            Faturamento = faturamento;
        }

        public Estado()
        {

        }
    }    
    
    class Program
    {
        static void Main(string[] args)
        {
            var E1 = new Estado("SP", 67836.43);
            var E2 = new Estado("RJ", 36678.66);
            var E3 = new Estado("MG", 29229.88);
            var E4 = new Estado("ES", 27165.48);
            var Outros = new Estado("Outros", 19849.53);

            var ListaEstados = new List<Estado>();
            ListaEstados.Add(E1);
            ListaEstados.Add(E2);
            ListaEstados.Add(E3);
            ListaEstados.Add(E4);
            ListaEstados.Add(Outros);

            Console.Clear();
            double somatorio = 0;

            Console.WriteLine("-------------------------------- Lista de Estados ---------------------------------");
            foreach (var item in ListaEstados)
            {
                Console.Write($"Index: {ListaEstados.IndexOf(item)}");
                Console.WriteLine($" Estado: {item.Sigla}  Faturamento: {item.Faturamento.ToString("C")}");

                somatorio += item.Faturamento;
            }
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine();
            double percentualE1 = (E1.Faturamento / somatorio)*100;
            double percentualE2 = (E2.Faturamento / somatorio)*100;
            double percentualE3 = (E3.Faturamento / somatorio)*100;
            double percentualE4 = (E4.Faturamento / somatorio)*100;
            double percentualOutros = (Outros.Faturamento / somatorio)*100;
            Console.WriteLine($"O valor total de faturamento dos estados é de: {somatorio.ToString("C")}");
            Console.WriteLine();
            Console.WriteLine($"O percentual de representação do estado de {E1.Sigla} no valor total de faturamento é: {Math.Round(percentualE1, 2)}%");
            Console.WriteLine($"O percentual de representação do estado de {E2.Sigla} no valor total de faturamento é: {Math.Round(percentualE2, 2)}%");
            Console.WriteLine($"O percentual de representação do estado de {E3.Sigla} no valor total de faturamento é: {Math.Round(percentualE3, 2)}%");
            Console.WriteLine($"O percentual de representação do estado de {E4.Sigla} no valor total de faturamento é: {Math.Round(percentualE4, 2)}%");
            Console.WriteLine($"O percentual de representação de {Outros.Sigla} estados no valor total de faturamento é: {Math.Round(percentualOutros, 2)}%");
            Console.WriteLine();
            Console.WriteLine("------------------------------------ Fim do Algoritmo ------------------------------------");
        }
    }
}
