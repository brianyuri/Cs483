using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Aula2._1_Classes
{
    class Carro : VeiculoTerrestre
    {
        public  int numChassi = 123132;
        public int Pneus { get; set; }

        public Carro()
        {
            Console.WriteLine("Construindo a classe carro");  
        }
        public Carro(string marca)
        {
            Console.WriteLine($"Construindo a classe carro da marca {marca}");
        }
        public override int Locomover()
        {
            return base.Locomover();
        }
    } 
}
