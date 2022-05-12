using System;

namespace ConsoleApp1.SRC.Entities
{
    public class Caneta
    {
        public String Modelo;
        public String Cor;
        public float Ponta;
        public int Carga;
        public Boolean Tampada;

        public Caneta(String m, String c, float p, int ca)
        {
            this.Modelo = m;
            this.Cor = c;
            this.Ponta = p;
            this.Tampar();
            this.Cor = "Azul";
            this.Carga = ca;
        }

        public void Rabiscar()
        {
            if (this.Tampada == true)
            {
                Console.WriteLine("Erro");
            }
            else {
                Console.WriteLine("Rabiscando");
            }
        }

        public void Tampar()
        {
            this.Tampada = true;
        }

        public void Destampar()
        {
            this.Tampada = false;
        }

        public override string ToString()
        {
            return "Sobre a Caneta:"
                   + "\n- Modelo: " + this.Modelo
                   + "\n- Ponta: " + this.Ponta
                   + "\n- A carga da caneta é: " + this.Carga;
        }

    }
}
