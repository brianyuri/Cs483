using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Aula1._3_PontoFlutuante
{
    class PontoFlutuante
    {
        public void Executa()
        {
            Console.WriteLine("Ponto Flutuante");
            Float();
            Double();
            Decimal();
            ExibirPontoFlutuante();
        }

        private static void Decimal()
        {
            decimal salario = 1050.00m;
            decimal adicional = 80;
            decimal soma = salario + adicional;
            Console.WriteLine($"Salario professor: {salario} + {adicional} = {soma} ");
        }

        private static void Double()
        {
            double vlBeerD = 6.15;
            double vlBeerAD = 2.1;
            double somaD = vlBeerD + vlBeerD;
            Console.WriteLine($"VlB: {vlBeerD} + vlBA: {vlBeerAD} = {somaD}");
            if ((vlBeerD + vlBeerAD) == somaD)
            {
                Console.WriteLine("É igual");
            }
            if (somaD == 8.25)
            {
                Console.WriteLine("Soma igual a 8,25");
            }

            double massaT = 5.972e24;
            Console.WriteLine($"massa da terra: {massaT}");
        }

        private static void Float()
        {
            float vlBeer = 6.32f;
            float vlBeerA = 2.15f;
            float soma = vlBeer + vlBeerA;
            Console.WriteLine($"VlB: {vlBeer} + vlBA: {vlBeerA} = {soma}");
        }

        private static void ExibirPontoFlutuante()
        {
            //==== float => Single
            Console.WriteLine($"Valor minimo : {float.MinValue}");
            Console.WriteLine($"Valor maximo : {float.MaxValue}");
            //==== double => Double
            Console.WriteLine($"Valor minimo : {double.MinValue}");
            Console.WriteLine($"Valor maximo : {double.MaxValue}");
            //==== decimal => Decimal
            Console.WriteLine($"Valor minimo : {decimal.MinValue}");
            Console.WriteLine($"Valor maximo : {decimal.MaxValue}");
        }
    }
}
