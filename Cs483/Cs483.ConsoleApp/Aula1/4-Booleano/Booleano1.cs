using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Aula1._4_Booleano
{
    class Booleano1
    {
        public void Executa()
        {
            Console.WriteLine("Booleano");

            double a = 10.10;
            double b = 20.20;
            double resultado = a + b;

            Console.WriteLine(resultado);
            Console.WriteLine($"Valor resultado = 30 - {resultado == 30.30}");
            //ExibeBooleano();


        }

        private static void ExibeBooleano()
        {
            double a = 10;
            double b = 20;
            double resultado = a + b;
            Console.WriteLine($"Valor igual {resultado}");

            //Vai aparecer true ou false
            Console.WriteLine($"Valor resultado = 30 - {resultado == 30}");

            //Neste caso aparece sim ou nao
            Console.WriteLine($"Valor resultado = 30 - {(resultado == 30 ? "Sim" : "Não")}");
        }
    }
}
