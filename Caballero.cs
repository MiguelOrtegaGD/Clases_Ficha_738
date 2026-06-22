using System;
using System.Collections.Generic;

namespace Clases_Ficha_738
{
    internal class Caballero : Personaje, ICongelable
    {
        public Caballero(string nombre) : base(nombre)
        {
        }
        public void Congelar()
        {
            Console.WriteLine(Nombre + " el caballero se ha congelado");
        }
    }
}
