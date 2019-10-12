using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Class1
    {
        public void Executa()
        {            
            Console.WriteLine("====Escolha uma das opcoes");
            Console.WriteLine("Informe seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe seu sobrenome: ");
            string sobrenome = Console.ReadLine();
            Console.WriteLine("Digite 1 para pessoa fisica ou 2 para pessoa juridica");
            int opcao = 0;
            switch (opcao)
            {
                case 1:
                    PessoaFisica();
                    break;
                case 2:
                    PessoaJuridica();
                    break;
                default:
                    break;
            }
        }    

        private static void PessoaJuridica()
        {
            Console.WriteLine("Infome o nome da empresa: ");
            string empresa = Console.ReadLine();
            Console.WriteLine("Informe o CNPJ: ");
            int CNPJ = Convert.ToInt32(Console.ReadLine());
        }
            

        private static void PessoaFisica()
        {
            Console.WriteLine("Informe seu CPF: ");
        }
    }
}
