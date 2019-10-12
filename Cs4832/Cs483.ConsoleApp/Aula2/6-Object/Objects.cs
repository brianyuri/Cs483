using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Aula2._6_Object
{
    class Objects
    {
        public void Executa()
        {
            Console.WriteLine("Objects");
            object idade = 20;
            
            Console.WriteLine(idade.GetType()); 

            Console.ReadLine();
        }
    }
}
