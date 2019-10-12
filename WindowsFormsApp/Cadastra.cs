using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    class Cadastra
    {
        static void cadastra()
        {
            Console.WriteLine("Escolha a opcao");

            Class1 cl = new Class1();
            int opcao = 0;
            switch (opcao)
            {
                case 1:
                cl.Executa();
                    break;
                default:
                    break;
            }
                    Console.ReadLine();
                    Console.Clear();
        }
    }
}
