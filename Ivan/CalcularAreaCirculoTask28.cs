using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDotNetTask01.Ivan
{
    class CalcularAreaCirculoTask28
    {
        public static void Main(string[] args)
        {


            Console.WriteLine("FÓRMULA PARA CALCULAR A ÁREA DO CÍRCULO A PARTIR DO RAIO");
            Console.WriteLine("DIGITE O RAIO");
            var R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((R*R) * Math.PI);
           
        }
    }
}
