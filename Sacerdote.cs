using System;
using System.Collections.Generic;

namespace Clases_Ficha_738
{
    internal class Sacerdote : Personaje
    {
        public Sacerdote(string nombre) : base(150, nombre, 40)
        {
        }
        public override void Atacar(Personaje objetivo)
        {
            if (vivo)
            {
                Console.WriteLine(Nombre + " lanzo un Rayo de luz a " + objetivo.Nombre + " y le causo " + daño + " de daño");
                objetivo.RecibirDaño(daño);
            }
            else
            {
                Console.WriteLine(Nombre + " esta muerto y no puede atacar");
            }
        }
        public void Curar(Personaje objetivo, int cura)
        {
            if (objetivo is ICurable curable)
            {
                curable.RecibirCura(cura);
                Console.WriteLine(Nombre + " curo a " + objetivo.Nombre + " " + cura + " puntos de vida");
            }
            else
            {
                Console.WriteLine(Nombre + " intento curar a  " + objetivo.Nombre + " pero no fue posible");
            }
        }
    }
}
