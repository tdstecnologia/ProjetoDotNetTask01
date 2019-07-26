using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDotNetTask01.Renato
{
    class VolumeDoCilindro
    {
        static void Main (string[]args)
        {

            double A, R, Altura;

            R = double.Parse(Console.ReadLine());
            Altura = double.Parse(Console.ReadLine());

            A = Math.PI * (R * R) * Altura;
            Console.WriteLine("Volume do Cilindor = " + A );
            Console.ReadLine();

        }

    }
}
