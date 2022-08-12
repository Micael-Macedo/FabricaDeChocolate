using System;
using System.Collections;
using System.Collections.Generic;

namespace FabricaDeChocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            Chocolate chocolate = new Chocolate();
            chocolate.Nome = "Operetaaaaaaaaaaa";
            chocolate.Peso = 0.25f;
            chocolate.Calorias = 100;
            chocolate.Validade = DateTime.Now;

            Chocolate chocolate2 = new Chocolate();
            chocolate2.Nome = "Batom";
            chocolate2.Peso = 0.50f;
            chocolate2.Calorias = 100;
            chocolate2.Validade = DateTime.Now;

            Console.WriteLine("------------ Informações do chocolate --------------");
            Console.WriteLine("Nome: " + chocolate.Nome);
            Console.WriteLine("Peso: " + chocolate.Peso);
            Console.WriteLine("Calorias: " + chocolate.Calorias);
            Console.WriteLine("Validade: " + chocolate.Validade);

            Console.WriteLine("Nome: " + chocolate2.Nome);
            Console.WriteLine("Peso: " + chocolate2.Peso);
            Console.WriteLine("Calorias: " + chocolate2.Calorias);
            Console.WriteLine("Validade: " + chocolate2.Validade);

            List<Chocolate> chocolates = new List<Chocolate>();
            chocolates.Add(chocolate);
            chocolates.Add(chocolate2);
            Caixa caixa = new Caixa();
            caixa.Tamanho = "30x50";
            caixa.Chocolates = chocolates;
            Console.WriteLine("Peso da caixa: " + caixa.PesoTotal);
        }
    }
}
