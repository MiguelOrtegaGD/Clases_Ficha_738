using System;
using System.Collections.Generic;

namespace Clases_Ficha_738
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guerrero g1 = new Guerrero("Arturito");
            Mago m1 = new Mago("Merlin");
            Sacerdote s1 = new Sacerdote("Chucho");

            g1.Atacar(m1);
            m1.Atacar(g1);

            s1.Curar(m1, 30);
            g1.Atacar(m1);
            g1.Atacar(s1);
            s1.Atacar(g1);
            g1.Atacar(m1);
            m1.Atacar(g1);
            s1.Curar(s1, 50);

            m1.MostrarDatos();
            g1.MostrarDatos();
            s1.MostrarDatos();
        }
    }
}
