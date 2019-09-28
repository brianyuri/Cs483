using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Aula1._1_Tipos
{
    public class Tipos
    {
        public void executa()
        {
            Console.WriteLine("Tipos");

            //ExibeNumeros();
            //ExibeCervejas();
            ExibeTiposPorValor();
        }

        private static void ExibeCervejas()
        {
            Beer b = new Beer();
            b.Graduacao = "18%";
            b.Cor = "Turva";
            b.IBU = 18;
            Beer b2 = new Beer();
            b2.Graduacao = "18%";
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

        private static void ExibeNumeros()
        {
            int numero1 = 20;
            int numCopia = 0;
            Console.WriteLine($"Numero1 : {numero1}");
            Console.WriteLine($"Copia : {numCopia}");

            numCopia = numero1;
            numero1 = 30;
            Console.WriteLine($"Numero1 : {numero1}");
            Console.WriteLine($"Copia : {numCopia}");
        }

        private void ExibeTiposPorValor()
        {
            //==== short => int16 tamanho menor que int
            Console.WriteLine($"Valor minimo : {short.MinValue}");
            Console.WriteLine($"Valor maximo : {short.MaxValue}");
            //==== int => int32 tamanho medio
            Console.WriteLine($"Valor minimo : {int.MinValue}");
            Console.WriteLine($"Valor maximo : {int.MaxValue}");
            //==== long => int64 tamanho maior
            Console.WriteLine($"Valor minimo : {long.MinValue}");
            Console.WriteLine($"Valor maximo : {long.MaxValue}");
        }
    }
}
