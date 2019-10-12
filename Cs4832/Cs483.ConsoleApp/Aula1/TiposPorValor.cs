using Cs483.ConsoleApp.Aula1._1_Tipos;
using Cs483.ConsoleApp.Aula1._2_TiposInteiros;
using Cs483.ConsoleApp.Aula1._3_PontoFlutuante;
using Cs483.ConsoleApp.Aula1._4_Boolean;
using Cs483.ConsoleApp.Aula1._5_Structs;
using Cs483.ConsoleApp.Aula1._6_Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Aula1
{
    class TiposPorValor
    {
        public void Executa()
        {
            int opcao = 0;
            do
            {
                MontaMenu();
                Console.WriteLine("Digite uma opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                Tipos tipos = new Tipos();
                TiposInteiros tiposInteiros = new TiposInteiros();
                PontoFlutuante pontoFlutuante = new PontoFlutuante();
                Booleano booleano = new Booleano();
                Structs structs = new Structs();
                Enums enuns = new Enums();

                switch (opcao)
                {
                    case 1:
                        tipos.Executa();
                        break;
                    case 2:
                        tiposInteiros.Executa();
                        break;
                    case 3:
                        pontoFlutuante.Executa();
                        break;
                    case 4:
                        booleano.Executa();
                        break;
                    case 5:
                        structs.Executa();
                        break;
                    case 6:
                        enuns.Executa();
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
            Console.WriteLine("====== Tipos por valor ======");
            Console.WriteLine("0-Sair");
            Console.WriteLine("1-Tipos por valor");
            Console.WriteLine("2-Tipos inteiro");
            Console.WriteLine("3-Ponto flutuante ");
            Console.WriteLine("4-Booleano");
            Console.WriteLine("5-Structs");
            Console.WriteLine("6-Enuns");
        }
    }
}
