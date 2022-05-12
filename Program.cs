using System;

namespace ConsoleApp1.SRC.Entities;
class Program {

    static void Main(string[] args) {

        Caneta Bic = new Caneta("NIC", "Vermelha", 0.4f, 40);
        Bic.Destampar();
        Console.WriteLine(Bic);
        Bic.Rabiscar();


        Console.WriteLine(" ");

        Caneta Bic2 = new Caneta("FIT", "Azul", 0.5f, 60);
        Bic.Tampada = true;
        Console.WriteLine(Bic2);
        Bic.Rabiscar();

        Console.WriteLine(" ");

        Lapis FaberCastel = new Lapis("Faber", "Cinza", 0.4f, 100, true);
        Console.WriteLine(FaberCastel);
        
       
    }

}
