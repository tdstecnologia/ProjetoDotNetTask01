using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDotNetTask01.Renato
{
    class CalculoCirculo
    {

        static void Main(string[] args)

        {

            double A, Raio;

            Raio = double.Parse(Console.ReadLine());

            A =  Math.PI * (Raio * Raio);

            Console.WriteLine("Area do círculo = " +A);
            Console.ReadLine();

        }

    }
}
