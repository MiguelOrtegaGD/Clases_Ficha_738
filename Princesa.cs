using System;
using System.Collections.Generic;

namespace Clases_Ficha_738
{
    internal class Princesa : Personaje, ICongelable
    {
        public Princesa(string nombre) : base(nombre)
        {
        }
        public void Congelar()
        {
            Console.WriteLine(Nombre + " la princesa se ha congelado");
        }
    }
}
