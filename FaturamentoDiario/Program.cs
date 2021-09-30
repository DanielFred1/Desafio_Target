using System;
using System.Xml;
using System.IO;
using System.Collections.Generic;

namespace FaturamentoDiario
{

    class Program
    {
        static void Main(string[] args)
        {
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
