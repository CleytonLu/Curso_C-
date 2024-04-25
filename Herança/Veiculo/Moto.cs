using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herança
{
    public class Moto : Veiculo
    {
        private int cilindrada;
        public Moto(string marca, string modelo, int ano) : base(marca, modelo, ano)
        {
        }

        public int Cilindrada
        {
            get { return cilindrada; }
            set { cilindrada = value; }
        }
    }
}