using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    { 
        interface IVeiculos
        {
            void Ligar();
        }

        class Carro : IVeiculos
        {
            public int pneus;
            public string cor;

            public void Ligar()
            {
                Console.WriteLine("Veiculo ligando....");
            }

            public override string ToString()
            {
                return $"{this.cor}-{this.pneus}";
            }
        }

        static void Main(string[] args)
        {
            Carro c2 = new Carro();
            c2.cor = "Amarelo";
            c2.pneus = 3;
            c2.Ligar();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
