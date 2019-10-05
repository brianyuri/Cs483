using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Aula2._5_Inteface
{
    interface IVeiculos
    {
        void Locomover();
        float CalcularVelocidadeMedia();
        float CalcularConsumoMedio();
    }
}
