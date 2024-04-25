using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herança
{
    public abstract class Veiculo
    {
        private String marca;
        public String Marca 
        { 
            get { return marca; } 
            set 
            { 
                if(value.Length < 0 )
                {
                    throw new ArgumentException("A marca é obrigatório!");
                }

                marca = value;
            } 
        }
        private String modelo;
        public String Modelo
        {
            get { return modelo; }
            set 
            {
                if(value.Length < 0){
                    throw new ArgumentException("O modelo é obrigatório");
                }

                modelo = value;
            }
        }
        private int ano;
        public int Ano 
        {
            get { return ano; }
            set
            {
                if(value < 0){
                    throw new Exception("O ano tem que ser maior que 0");
                }

                ano = value;
            }
        }

        public Veiculo(String marca, String modelo, int ano){
            this.ano = ano;
            this.marca = marca;
            this.modelo = modelo;
        }

    }
}