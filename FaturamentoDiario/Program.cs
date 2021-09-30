using System;
using System.Xml;
using System.IO;
using System.Collections.Generic;

namespace FaturamentoDiario
{
    public class Diario
    {
        public int Dia { get; set; }
        public double Faturamento { get; set; }

        public Diario(int dia, double faturamento)
        {
            Dia = dia;
            Faturamento = faturamento;
        }

        public Diario()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var mes = new List<Diario>();
            XmlTextReader Leitor = new XmlTextReader("..\\FaturamentoDiario\\dados (2).xml");
            while (Leitor.Read())
            {
                if (Leitor.NodeType == XmlNodeType.Text)
                {
                    Console.WriteLine(Leitor.Value);
                }


            }

        }
    }
}
