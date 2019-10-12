using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Aula2._4_Dynamic
{
    class Dynamics
    {
        public void Executa()
        {
            Console.WriteLine("Dynamics");
            var idade = 21;            
            int resultado = idade * 2;

            dynamic idade2 = 21;
            idade2.Testar(); //==== vai dar erro
            int resultado2 = idade2 * 2;

            object idade3 = 21;
            int resultado3 = (int)idade * 2;

            Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}
