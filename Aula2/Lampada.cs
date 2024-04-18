using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2
{
    public class Lampada
    {
        public bool Estado { get; set; }
        public int Intensidade { get; set; }

        public Lampada()
        {
            this.Estado = false;
            this.Intensidade = 0;
        }

        public void LigarLampada(bool estado)
        {
            if(!estado){
                this.Estado = true;
                this.Intensidade = 1;
                Console.WriteLine("A lâmpada está ligada");
            } else {
                this.Estado = false;
                this.Intensidade = 0;
                Console.WriteLine("A lâmpada está desligada");
            }
        }

        public void AjustarIntensidade(int novaIntensidade)
        {
            if(novaIntensidade > 0){
                this.Intensidade += novaIntensidade;
            }else{
                this.Intensidade -= novaIntensidade;
            }
            Console.WriteLine($"A intensidade da lâmpada foi ajustada para: {this.Intensidade}");
            
        }
    }
}