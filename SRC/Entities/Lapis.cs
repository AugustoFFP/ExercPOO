using System;

namespace ConsoleApp1.SRC.Entities
{
    internal class Lapis : Caneta
    {
        public Lapis(String Modelo, String cor, float Ponta, int Carga, Boolean tampada) : base(Modelo, cor, Ponta, Carga) { 
        
        }

        public override string ToString()
        {
            return "Sobre O Lápis:"
                  + "\n- Modelo: " + this.Modelo
                  + "\n- Ponta: " + this.Ponta
                  + "\n- A carga do Lápis é: " + this.Carga;
        }
    }
}
