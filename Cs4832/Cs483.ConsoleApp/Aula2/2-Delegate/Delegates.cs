using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Aula2._2_Delegate
{
    class Delegates
    {
        public void Executa()
        {
            Console.WriteLine("Delegates");
            ContasMatematicas cm = Duplicar;
            Console.WriteLine( cm(2) ) ;

            cm = Triplicar;
            Console.WriteLine( cm(2) );

            cm = (int valor) =>
            {
                return valor * 4;
            };

            Console.WriteLine( cm(2) );
            Console.ReadLine();
        }
        int Duplicar(int valor)
        {
            return valor * 2;
        }
        int Triplicar(int valor)
        {
            return valor * 3;
        }

    }

    delegate int ContasMatematicas(int valor);
 
}
