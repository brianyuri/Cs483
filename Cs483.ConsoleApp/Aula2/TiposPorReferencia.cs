using Cs483.ConsoleApp.Aula2._1_Classes;
using Cs483.ConsoleApp.Aula2._2_Delegate;
using Cs483.ConsoleApp.Aula2._3_String;
using Cs483.ConsoleApp.Aula2._4_Dynamic;
using Cs483.ConsoleApp.Aula2._5_Inteface;
using Cs483.ConsoleApp.Aula2._6_Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Aula2
{
    class TiposPorReferencia
    {
        public void Executa()
        {
            int opcao = 0;
            do
            {
                MontaMenu();
                Console.WriteLine("Digite uma opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                Classes cs = new Classes();
                Delegates de = new Delegates();
                Strings st = new Strings();
                Dynamics dc = new Dynamics();
                Interfaces it = new Interfaces();
                Objects obj = new Objects();

                switch (opcao)
                {
                    case 1:
                        cs.Executa();
                        break;
                    case 2:
                        de.Executa();
                        break;
                    case 3:
                        st.Executa();
                        break;
                    case 4:
                        dc.Executa();
                        break;
                    case 5:
                        it.Executa();
                        break;
                    case 6:
                        obj.Executa();
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
            Console.WriteLine("====== Tipos por referencia ======");
            Console.WriteLine("0-Sair");
            Console.WriteLine("1-Classes");
            Console.WriteLine("2-Delegates");
            Console.WriteLine("3-Strings");
            Console.WriteLine("4-Dynamics");
            Console.WriteLine("5-Interfaces");
            Console.WriteLine("6-Object");
        }
    }
}
