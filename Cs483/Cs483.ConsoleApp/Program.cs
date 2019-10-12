using Cs483.ConsoleApp.Aula1._1_Tipos;
using Cs483.ConsoleApp.Aula1._2_TiposInteiros;
using Cs483.ConsoleApp.Aula1._3_PontosFlutuante;
using Cs483.ConsoleApp.Aula1._4_Booleano;
using Cs483.ConsoleApp.Aula1._5_Structs;
using Cs483.ConsoleApp.Aula1._6_Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            do
            {
                MontaMenu();
                Console.WriteLine("Digite uma opçao: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                Tipos tipos = new Tipos();
                TiposInteiros tiposInt = new TiposInteiros();
                PontosFlutuante pontos = new PontosFlutuante();
                Booleano1 booleano = new Booleano1();
                Structs1 struct1 = new Structs1();
                Enums enums = new Enums();


                switch (opcao)
                {
                    case 1:
                        tipos.executa();
                        break;
                    case 2:
                        tiposInt.Executa();
                        break;
                    case 3:
                        pontos.Executa();
                        break;
                    case 4:
                        booleano.Executa();
                        break;
                    case 5:
                        struct1.Executa();
                        break;
                    case 6:
                        enums.Executa();
                        break;

                    default:
                        break;

                Console.ReadLine();
                Console.Clear();
                }

                tipos.executa();

            } while (opcao != 0);
       
        }

        private static void MontaMenu()
        {
            Console.WriteLine("===== CS 483 =====");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Tipos por valor");
            Console.WriteLine("2 - Tipos inteiros");
            Console.WriteLine("3 - Pontos flutante");
            Console.WriteLine("4 - Booleano");
            Console.WriteLine("5 - Structs");
            Console.WriteLine("6 - Enums");
            Console.WriteLine("7 - ");
            Console.WriteLine("8 - ");
            Console.WriteLine("9 - ");
            Console.WriteLine("10 - ");

        }
    }
}
