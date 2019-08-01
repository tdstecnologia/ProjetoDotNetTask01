using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDotNetTask01.Alan
{
    class ContarPalavras36
    {

        public void Executar()
        {

            string texto = "";
            int contador = 0;

            texto = solicitaTexto();

            foreach(Char c in texto)
            {
                    contador++;
            }

            Console.WriteLine("Foi contado um total de " + contador + " caracteres.");

        }

        string solicitaTexto()
        {
            Console.WriteLine("Informe o texto que deseje saber a quantidade de caracteres:");

            return Console.ReadLine();

        }

    }
}
