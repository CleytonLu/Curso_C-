using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2
{
    public class Carro
    {
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public String Cor { get; set; }
        public String Placa { get; set; }
        public Double Motor { get; set; }
        public int Ano { get; set; }
        public Double Velocidade { get; set; }

        public Carro(String modelo, int ano, String placa, double velocidade)
        {
            this.Placa = placa;
            this.Modelo = modelo;
            this.Ano = ano;
            this.Velocidade = velocidade;
        }

        public void Acelerar(Double incremento){
            this.Velocidade += incremento;
            Console.WriteLine($"A velocidade do carro subiu para {this.Velocidade} km/h");
        }

        public void Frear (double decremento) {
            this.Velocidade = Velocidade - decremento;
            Console.WriteLine($"A velocidade do carro diminuiu para {this.Velocidade}");
        }

        public void Ligar(){
            Console.WriteLine("O carro está ligado");
        }
    }
}