using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herança.Funcionario
{
    public class Analista : Funcionario
    {
        public Analista(string departamento, string nome) : base(departamento, nome)
        {
        }

        public override void Trabalhar()
        {
            Console.WriteLine("Analisando requisitos!");
        }

        internal void Nome(string v)
        {
            throw new NotImplementedException();
        }
    }
}