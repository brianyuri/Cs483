using Cs483.ConsoleApp.Aula2._5_Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Aula2._1_Classes
{
    abstract class VeiculoTerrestre : Veiculo
    {
        public int Rodas { get; set; }
        public void VelecidadeMedia()
        {
        }
        public override int A()
        {
            return 10;
        }
        public override int Locomover()
        {
            
            return base.Locomover()-1;
        }

    }
}
