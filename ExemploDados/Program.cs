using System;
using ExemploDados.Models;

namespace ExemploDados
{
    class Program
    {
       

        static void Main(string[] args)
        {


          Console.WriteLine($"Bem vindo a nossa Feirinha Online!!\n");
          Console.WriteLine($"Confira os produtos que temos abaixo , valor e quantidade que temos em Estoque\n");

        Produto p1 = new Produto();

        p1.Nome = "Banana";
        p1.Preço = 3.9;
        p1.Comprar(40);
        p1.Vender(5);
        Console.WriteLine(p1.ObterTexto());

        Produto P2 = new Produto("Laranja", 4.75);
        P2.Comprar(100);
        P2.Vender(20);
        Console.WriteLine(P2.ObterTexto());

        Produto P3 = new Produto("Abacaxi",  5.50);
        P3.Comprar (200);
        P3.Vender(5);
        Console.WriteLine(P3.ObterTexto());


        Produto p4 = new Produto ("Amora", 2.20);
        p4.Comprar(300);
        p4.Vender(100);
        Console.WriteLine(p4.ObterTexto());

        Produto P5 = new Produto ("Caju" , 1.20);
        P5.Comprar(150);
        P5.Vender(60);
        Console.WriteLine(P5.ObterTexto());

        Console.WriteLine("Faça já seu pedido , através do nosso WhatsApp (15)9999-9901 ou pelo nosso Instragram - FeirinhaOnline\n");
        Console.WriteLine("Obrigado por utilizar nosso sistema, Volte sempre!");


       
        


           
        }
    }
}
