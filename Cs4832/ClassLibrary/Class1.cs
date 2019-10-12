using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Class1
    {
        public void Cadastro()
        {
            string juridica;
            string fisica;
            
            Console.WriteLine("Pessoa fisica ou juridica? ");
            int opcao = Convert.ToInt32 (Console.ReadLine());
            if (opcao == 2)
            {
                PessoaJuridica()
            }
            else
            {
                PessoaFisica();
            }


        }

        private static void PessoaFisica()
        {
            Console.WriteLine("Informe seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe seu sobrenome: ");
            string sobrenome = Console.ReadLine();
            Console.WriteLine("Informe seu CPF: ");
            int CPF = Convert.ToInt32(Console.ReadLine());
        }

        public void PessoaJuridica()
        {
            Console.WriteLine("Informe o nome de sua empresa: ");
            string empresa = Console.ReadLine();
            Console.WriteLine("Informe seu CNPJ: ");
            int CNPJ = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(empresa);
            Console.WriteLine(CNPJ);
        }

    }
}
