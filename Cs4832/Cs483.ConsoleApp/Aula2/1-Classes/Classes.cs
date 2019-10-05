using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Aula2._1_Classes
{
    class Classes
    {
        public void Executa()
        {
            Console.WriteLine("Classes");
            Carro c = new Carro();
            c.Pneus = 4;
            
            Console.WriteLine(c.Locomover());
            c.PotenciaDoMotor = 15;
            Console.WriteLine(c.PotenciaDoMotor);
            Console.ReadLine();
        }
    }
}
