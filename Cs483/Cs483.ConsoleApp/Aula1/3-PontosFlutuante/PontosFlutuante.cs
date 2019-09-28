using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Aula1._3_PontosFlutuante
{
    class PontosFlutuante
    {
        public void Executa()
        {
            Console.WriteLine("Pontos flutuante");
            Float();
            Double();
            Decimal();
            double massaT = 5.972e24;

            //Decimal
            //decimal vlBeer3 = 6.00f;
            //decimal vlBeerA3 = 2.00f;
            //decimal soma3 = vlBeer3 + vlBeerA3;
            //Console.WriteLine($"VlB: {vlBeer} + vlBA: {vlBeerA} = {soma}");
            ExibirPontosFlutuantes();
        }

        private static void Decimal()
        {
            decimal salario = 1050.00m;
            Console.WriteLine($"Salario professor: {salario}");
            decimal aulaE = 10;
            decimal valorA = 100.00m;
            decimal soma = (aulaE * valorA) + salario;
            Console.WriteLine($"Total a receber:{aulaE} * {valorA} + {salario} = {soma}");
        }

        private static void Float()
        {
            //Float
            float vlBeer = 6.32f;
            float vlBeerA = 2.15f;
            float soma = vlBeer + vlBeerA;
            Console.WriteLine($"VlB: {vlBeer} + vlBA: {vlBeerA} = {soma}");
           
            if ((vlBeer + vlBeerA) == soma)
            {
                Console.WriteLine("É igual");
            }
            if (soma == 8.25)
            {
                Console.WriteLine("Soma igual a 8,25");
            }
        }

        private static void Double()
        {
            //float vlBeer = 6.32f;
            //float vlBeerA = 2.15f;
            //float soma = vlBeer + vlBeerA;
            //Console.WriteLine($"VlB: {vlBeer} + vlBA: {vlBeerA} = {soma}");
            // Double
            double vlBeerD = 6.15;
            double vlBeerAD = 2.1;
            double somaD = vlBeerD + vlBeerAD;
            Console.WriteLine($"VlB: {vlBeerD} + vlBA: {vlBeerAD} = {somaD}");
            if ((vlBeerD + vlBeerAD) == somaD)
            {
                Console.WriteLine("É igual");
            }
            if (somaD == 8.25)
            {
                Console.WriteLine("Soma igual a 8,25");
            }
        }

        private static void ExibirPontosFlutuantes()
        {
            
            //==== float => Single
            Console.WriteLine($"Valor minimo : {float.MinValue}");
            Console.WriteLine($"Valor maximo : {float.MaxValue}");

            //==== double => Double
            Console.WriteLine($"Valor minimo : {double.MinValue}");
            Console.WriteLine($"Valor maximo : {double.MaxValue}");

            //====decimal => Decimal
            Console.WriteLine($"Valor minimo : {decimal.MinValue}");
            Console.WriteLine($"Valor maximo : {decimal.MaxValue}");
        }
    }
}
