using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ala_5___Polimorfismo__Interface__override_e_overlai.ExercicioHeranca
{
    public abstract class DispositivoEletronico
    {
        private String marca;
        private String modelo;
        private int anoDeFabricacao;
        private int statusBateria;

        public DispositivoEletronico(String marca, String modelo, int anoDeFabricacao, int statusBateria = -1)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.anoDeFabricacao = anoDeFabricacao;
            this.statusBateria = statusBateria;
        }

        public String Marca 
        { 
            get { return marca; } 
            set { marca = value; } 
        }
        public String Modelo 
        { 
            get {return modelo;} 
            set { modelo = value; } 
        }
        public int AnoDeFabricacao 
        { 
            get{ return anoDeFabricacao;} 
            set{ anoDeFabricacao = value; }
        }
        public int StatusBateria 
        { 
            get { return statusBateria; }
            set{ statusBateria = value;}
        }

        public abstract void Ligar();

        public abstract void Desligar();

        public virtual String ObterDescricao()
        {
            return $"Marca: {marca}, Modelo: {modelo}";
        }

        public virtual int VerificaBateria()
        {
            if(statusBateria < 0)
            {
                return -1;
            } else {
                return statusBateria;
            }
            
        }

}

}