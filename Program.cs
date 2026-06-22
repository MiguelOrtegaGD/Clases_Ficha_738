using System;
using System.Collections.Generic;

namespace Clases_Ficha_738
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Personaje> personajes = new List<Personaje>()
            {
                 new Princesa("Lauren"),
                 new Minero("Taysir"),
                 new Caballero("Elian")
            };

            BolaHielo bola = new BolaHielo();

            foreach (var item in personajes)
            {
                if (item is ICongelable congelable)
                {
                    bola.Congelar(congelable);
                }
            }
        }
    }
}
