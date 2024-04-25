using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herança.Funcionario
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string departamento, string nome) : base(departamento, nome)
        {
        }

        public override void Trabalhar()
        {
            Console.WriteLine("Desenvolvendo projetos");
        }
    }
}