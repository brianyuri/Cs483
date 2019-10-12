using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Aula2._3_String
{
    class Strings
    {
        public void Executa()
        {
            Console.WriteLine("Strings");
            string nome = "    Maykon D. Granemann    ";    

            Console.WriteLine(nome[0]);
            Console.WriteLine(nome.Length);
            Console.WriteLine(nome.Substring(0,6));
            Console.WriteLine(nome);
            Console.WriteLine(nome.Trim() ) ;
            Console.WriteLine(nome.Trim().Remove(0,6));
            Console.WriteLine(nome.TrimStart()) ;
            Console.WriteLine(nome.TrimEnd());
            Console.WriteLine(nome.Replace('n', '1'));
            Console.WriteLine(nome.Replace("Granemann", "Rauen"));
            Console.WriteLine(nome.ToLower() );
            Console.WriteLine(nome.ToUpper());
            Console.WriteLine(nome.Contains('G'));
            Console.WriteLine(nome.Contains("Gra"));
            Console.WriteLine(nome.Count() );
            Console.WriteLine(nome.Trim().EndsWith("nn"));
            Console.WriteLine(nome.Trim().StartsWith("Ma"));
            Console.WriteLine(nome.Trim().Insert(8, "yego") );
            string[] nomes = nome.Trim().Split(' ');
            Console.WriteLine(nomes[0]);
            Console.WriteLine(nome.Trim().IndexOf('D'));

            Console.ReadLine();
        }
    }
}
