using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Aula1._2_TiposInteiros
{
    class TiposInteiros
    {
        public void Executa()
        {
            Console.WriteLine("TiposInteiros");
            Conversoes();
            ExibeTiposInteiros();
        }

        private static void Conversoes()
        {
            char l = 'B';
            int n = l;
            Console.WriteLine($"Letra: {n}");

            int idB = 26;
            byte idade = (byte)idB;
            Console.WriteLine($"Idade Brian: {idade}");
        }

        private void ExibeTiposInteiros()
        {
            //==== char => Char 
            Console.WriteLine($"Valor minimo : {char.MinValue}");
            Console.WriteLine($"Valor maximo : {char.MaxValue}");

            //==== byte => Byte 
            Console.WriteLine($"Valor minimo : {byte.MinValue}");
            Console.WriteLine($"Valor maximo : {byte.MaxValue}");
            //==== byte => sByte 
            Console.WriteLine($"Valor minimo : {sbyte.MinValue}");
            Console.WriteLine($"Valor maximo : {sbyte.MaxValue}");


            //==== short => int16 
            Console.WriteLine($"Valor minimo : {short.MinValue}");
            Console.WriteLine($"Valor maximo : {short.MaxValue}");
            //==== ushort => UInt16 
            Console.WriteLine($"Valor minimo : {ushort.MinValue}");
            Console.WriteLine($"Valor maximo : {ushort.MaxValue}");

           
            //==== int => int32 
            Console.WriteLine($"Valor minimo : {int.MinValue}");
            Console.WriteLine($"Valor maximo : {int.MaxValue}");
            //==== uint => UInt32 
            Console.WriteLine($"Valor minimo : {uint.MinValue}");
            Console.WriteLine($"Valor maximo : {uint.MaxValue}");


            //==== long => int64 
            Console.WriteLine($"Valor minimo : {long.MinValue}");
            Console.WriteLine($"Valor maximo : {long.MaxValue}");
            //==== ulong => UInt64 
            Console.WriteLine($"Valor minimo : {ulong.MinValue}");
            Console.WriteLine($"Valor maximo : {ulong.MaxValue}");

        }
    }
    
}
