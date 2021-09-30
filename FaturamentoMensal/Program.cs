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

            double somatorio = 0;

            foreach (var item in ListaEstados)
            {
                Console.Write(ListaEstados.IndexOf(item));
                Console.WriteLine($" Estado: {item.Sigla}  Faturamento: R${item.Faturamento}");

                somatorio += item.Faturamento;
            }

            double percentualE1 = (E1.Faturamento / somatorio)*100;
            double percentualE2 = (E2.Faturamento / somatorio)*100;
            double percentualE3 = (E3.Faturamento / somatorio)*100;
            double percentualE4 = (E4.Faturamento / somatorio)*100;
            double percentualOutros = (Outros.Faturamento / somatorio)*100;
            Console.WriteLine($"O valor total de faturamento dos estados é de: R${somatorio}");
            Console.WriteLine($"O percentual de representação do estado de {E1.Sigla} no valor total de faturamento é: {percentualE1}%");
            Console.WriteLine($"O percentual de representação do estado de {E2.Sigla} no valor total de faturamento é: {percentualE2}%");
            Console.WriteLine($"O percentual de representação do estado de {E3.Sigla} no valor total de faturamento é: {percentualE3}%");
            Console.WriteLine($"O percentual de representação do estado de {E4.Sigla} no valor total de faturamento é: {percentualE4}%");
            Console.WriteLine($"O percentual de representação do estado de {Outros.Sigla} no valor total de faturamento é: {percentualOutros}%");
        }
    }
}
