using Cs483.ConsoleApp.Aula2._5_Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Aula2._1_Classes
{

    class Veiculo: IVeiculos, IVeiculoMotorizado
    {
        private int _velocidade;
        public string Tipo { get; set; }
        public float PotenciaDoMotor { get; set; }

        public virtual int Locomover()
        {
            int velocidadeInicial = 20;
            return velocidadeInicial;
        }
        public void AjustarVelocidade()
        {
            this._velocidade += 10;
        }

        public abstract int A();

        void IVeiculos.Locomover()
        {
            throw new NotImplementedException();
        }

        public float CalcularVelocidadeMedia()
        {
            throw new NotImplementedException();
        }

        public float CalcularConsumoMedio()
        {
            throw new NotImplementedException();
        }

        public void LigarMotor()
        {
            throw new NotImplementedException();
        }

        public void Abastecer(int litros)
        {
            throw new NotImplementedException();
        }
    }
}
