using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDotNetTask01.Alan
{
    class ValidaEmail37
    {
        public void Executar()
        {
            Boolean lMail =  true;

            while (lMail)
            {
                lMail = Valida();
            }

        }

        Boolean Valida()
        {
            string eMail = infoMail();
            string[] partes = eMail.Split('@');
            Boolean valido = true;

            if (valido = (partes.Length < 2))
            {
                Console.WriteLine("Atenção deve ser informado o @ no e-mail.");
            }
            else if (valido = (partes[0].Length < 3))
            {
                Console.WriteLine("A conta de e-mail deve conter ao menos 3 caracteres.");
            }
            else if (valido = (!(partes[1].Contains(".com.br") | partes[1].Contains(".com"))))
            {
                Console.WriteLine("O dominio do e-mail deve conter o .com ou .com.br.");
            }
            else
            {
                Console.WriteLine("E-mail valido.");
            }

            return valido;
        }

        string infoMail()
        {

            Console.WriteLine("Informe o endereço de e-mail que será validado.");

            return Console.ReadLine();
        }
    }
}
