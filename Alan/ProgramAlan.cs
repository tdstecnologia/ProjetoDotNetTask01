using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDotNetTask01.Alan
{
    class ProgramAlan
    {
        static void Main(string[] args)
        {
            string opcao = "";

            Menu menu = new Menu();
            ContarPalavras36 ContPlvrs = new ContarPalavras36();
            ValidaEmail37 ValEmail = new ValidaEmail37();

            do
            {
                menu.mostraMenu();

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "36": ContPlvrs.Executar();
                        break;
                    case "37": ValEmail.Executar();
                        break;
                    case "99":
                        Console.WriteLine("Saindo do Programa!");
                        break;
                    default:
                        Console.WriteLine("Opção invalida, digite novamente!");
                        break;
                }
            }

            while (opcao != "99");

            Console.ReadKey();

        }
    }
}
