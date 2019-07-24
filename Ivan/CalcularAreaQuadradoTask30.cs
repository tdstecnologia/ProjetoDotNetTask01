using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDotNetTask01.Ivan
{
    class CalcularAreaQuadradoTask30
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("PROGRAMA PARA CALCULAR A ÁREA DE UM QUADRADO, DADA A MEDIDA DE UM DOS LADOS");
            Console.WriteLine("INFORME A MEDIDA DE UM DOS LADOS");
            var L = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(L * L);
        }
    }
}
