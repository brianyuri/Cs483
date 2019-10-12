using Cs483.ConsoleApp.Aula1._1_Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Aula1._5_Structs
{
    class Structs
    {
        public void Executa()
        {
            Console.WriteLine("Structs");

            Tipos tipos = new Tipos();
            tipos.ExibeCervejas();
            ExibeCervejasS();

        }
        public void ExibeCervejasS()
        {
            Console.WriteLine("Beer Struct");
            BeerS b = new BeerS();
            b.Graduacao = "18%";
            b.Cor = "Turva";
            b.IBU = 18;
            BeerS b2 = new BeerS();
            b2.Graduacao = "10%";
            b2.Cor = "Clara";
            b2.IBU = 15;

            Console.WriteLine($"Beer1 : { b.ToString() } ");
            Console.WriteLine($"Beer2 : { b2.ToString() } ");

            b2 = b;
            b.Graduacao = "50%";
            b.Cor = "Escura";
            b.IBU = 25;
            Console.WriteLine($"Beer1 : { b.ToString() } ");
            Console.WriteLine($"Beer2 : { b2.ToString() } ");
        }
    }

}
