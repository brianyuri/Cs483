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
            Console.WriteLine("Tipos Inteiros");
            Conversoes();
            ExibeTiposInteiro();

        }

        private static void Conversoes()
        {
            char l = 'M';
            int n = l;
            Console.WriteLine($"Letra: {n}");

            int idM = 381;
            byte idade = (byte)idM;
            Console.WriteLine($"Idade Maykon: {idade}");
        }

        private void ExibeTiposInteiro()
        {
            //==== char => Char
            Console.WriteLine($"Valor minimo : {char.MinValue}");
            Console.WriteLine($"Valor maximo : {char.MaxValue}");

            //==== byte => Byte
            Console.WriteLine($"Valor minimo : {byte.MinValue}");
            Console.WriteLine($"Valor maximo : {byte.MaxValue}");
            //==== byte => SByte
            Console.WriteLine($"Valor minimo : {sbyte.MinValue}");
            Console.WriteLine($"Valor maximo : {sbyte.MaxValue}");

            //==== short => Int16
            Console.WriteLine($"Valor minimo : {short.MinValue}");
            Console.WriteLine($"Valor maximo : {short.MaxValue}");
            //==== ushort => UInt16
            Console.WriteLine($"Valor minimo : {ushort.MinValue}");
            Console.WriteLine($"Valor maximo : {ushort.MaxValue}");

            //==== int => Int32
            Console.WriteLine($"Valor minimo : {int.MinValue}");
            Console.WriteLine($"Valor maximo : {int.MaxValue}");
            //==== uint => UInt32
            Console.WriteLine($"Valor minimo : {uint.MinValue}");
            Console.WriteLine($"Valor maximo : {uint.MaxValue}");
            
            //==== long => Int64
            Console.WriteLine($"Valor minimo : {long.MinValue}");
            Console.WriteLine($"Valor maximo : {long.MaxValue}");
            //==== ulong => UInt64
            Console.WriteLine($"Valor minimo : {ulong.MinValue}");
            Console.WriteLine($"Valor maximo : {ulong.MaxValue}");
        }
    }
}
