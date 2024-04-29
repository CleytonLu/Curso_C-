using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ala_5___Polimorfismo__Interface__override_e_overlai.ExercicioHeranca
{
    public class Smartphone : DispositivoEletronico
    {
        private String sistemaOperacional;
        private int capacidadeBateria;

        public Smartphone(string marca, string modelo, int anoDeFabricacao, String sistemaOperacional, int statusBateria) : base(marca, modelo, anoDeFabricacao, statusBateria)
        {
            this.sistemaOperacional = sistemaOperacional;
        }

        public String SistemaOperacional 
        {
            get { return sistemaOperacional; } 
            set { sistemaOperacional = value; }
        }

        public int CapacidadeBateria
        {
            get {return capacidadeBateria;}
            set { capacidadeBateria = value; }
        }

        public override void Ligar()
        {
            Console.WriteLine("Ligando o smartphone"); ;
        }

        public override void Desligar()
        {
            Console.WriteLine("Desligando o smartphone");
        }

        public override string ObterDescricao()
        {
            return $"O sistema operacional do smartphone é: {sistemaOperacional}";
        }

        public override int VerificaBateria()
        {
            return base.VerificaBateria();
        }
    }
}