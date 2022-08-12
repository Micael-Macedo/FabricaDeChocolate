using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FabricaDeChocolate
{
    public class Chocolate
    {
        private string nome;
        public float Peso { get; set; }
        public float Calorias { get; set; }
        public DateTime Validade { get; set; }

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                string newNome = value;
                if (ValidarNome(newNome))
                {
                    this.nome = newNome;
                }
                else
                {
                    throw new ArgumentException("Invalid name size");
                }
            }
        }
        public bool ValidarNome(string nome)
        {
            if (nome.Length <= 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}