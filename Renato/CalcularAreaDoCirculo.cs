using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDotNetTask01.Renato
{
    class CalcularAreaDoCirculo
    {
        static void Main(string[] args)
        {
            double A, R;

            R = double.Parse(Console.ReadLine());

            A = Math.PI * (R * R);

            Console.WriteLine(" Área do Raio = "+ A);
            Console.ReadLine();
        }
    }
}
