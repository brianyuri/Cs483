using Cs483.ConsoleApp.Aula1;
using Cs483.ConsoleApp.Aula1._1_Tipos;
using Cs483.ConsoleApp.Aula1._2_TiposInteiros;
using Cs483.ConsoleApp.Aula1._3_PontoFlutuante;
using Cs483.ConsoleApp.Aula1._4_Boolean;
using Cs483.ConsoleApp.Aula1._5_Structs;
using Cs483.ConsoleApp.Aula1._6_Enum;
using Cs483.ConsoleApp.Aula2;
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
                Console.WriteLine("Digite uma opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                TiposPorValor tpv = new TiposPorValor();
                TiposPorReferencia tpr = new TiposPorReferencia();
                switch (opcao)
                {
                    case 1:
                        tpv.Executa();
                        break;
                    case 2:
                        tpr.Executa();
                        break;
                    default:
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            } while (opcao != 0);
        }
        private static void MontaMenu()
        {
            Console.WriteLine("====== CS 483 ======");
            Console.WriteLine("0-Sair");
            Console.WriteLine("1-Tipos por valor");
            Console.WriteLine("2-Tipos por referencia");
        }
    }
}
