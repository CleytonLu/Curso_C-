using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herança.Funcionario
{
    public abstract class Funcionario
    {
        private String nome;
        public String Nome 
        { 
            get { return nome; }
            set { nome = value; }
        }

        private String departamento;
        public String Departamento 
        { 
            get { return departamento; }
            set { departamento = value; }
        }

    public Funcionario(String departamento, String nome){
            this.departamento = departamento;
            this.nome = nome;
    }

        public abstract void Trabalhar();
    }
}