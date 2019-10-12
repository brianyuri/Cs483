using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Aula1._4_Boolean
{
    class Booleano
    {
        public void Executa()
        {
            Console.WriteLine("Booleano");

            double a = 10.10;
            double b = 20.20;
            double resultado = a + b;
            Console.WriteLine(resultado);
            Console.WriteLine($"Valor resultado = 30.30 - { resultado == 30.30} ");

            //ExibeBoolean();

        }

        private static void ExibeBoolean()
        {
            double a = 10;
            double b = 20;
            double resultado = a + b;
            Console.WriteLine($"Valor igual {resultado}");

            Console.WriteLine($"Valor resultado = 30 - { resultado == 30} ");
            Console.WriteLine($"Valor resultado = 30 - { (resultado == 30 ? "Sim" : "Não") } ");
        }
    }
}
