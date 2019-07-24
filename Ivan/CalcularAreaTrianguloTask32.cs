using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDotNetTask01.Ivan
{
    class CalcularAreaTrianguloTask32
    {
        public static void Main()
        {
            Console.WriteLine("PROGRAMA PARA CALCULAR A ÁREA DE UM TRIANGULO");
            Console.WriteLine("INFORME A MEDIDA DA BASE");
            var B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("INFORME A MEDIDA DA ALTURA");
            var H = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((B * H)/2);
        }
    }
}
