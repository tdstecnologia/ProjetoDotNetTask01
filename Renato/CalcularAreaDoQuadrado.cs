using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDotNetTask01.Renato
{
    class CalcularAreaDoQuadrado
    {
        static void Main (string[] args)
        {
            double Lado, A;

            Lado = double.Parse(Console.ReadLine());

            A = Lado * Lado;

            Console.WriteLine( "Area do Quadrado"+A );
            Console.ReadLine();

        }

    }
}
