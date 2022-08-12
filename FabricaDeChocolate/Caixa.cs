using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FabricaDeChocolate
{
    public class Caixa
    {
        public string Tamanho { get; set; }
        private float pesoTotal;
        public ICollection<Chocolate> Chocolates { get; set; }

        public float PesoTotal
        {
            get
            {
                pesoTotal = 0;
                foreach(var chocolate in Chocolates){
                    pesoTotal += chocolate.Peso;
                }
                return pesoTotal;
            }
        }
    }
}