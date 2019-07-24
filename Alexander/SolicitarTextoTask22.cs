using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDotNetTask01.Alexander
{
    class SolicitarTextoTask22
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um Texto");
            var texto = Console.ReadLine();
            Console.WriteLine("Seu Texto é: " + Convert.ToString(texto));
        }
    }
}
