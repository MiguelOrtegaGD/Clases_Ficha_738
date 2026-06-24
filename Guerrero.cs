using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Ficha_738
{
    internal class Guerrero : Personaje, ICurable
    {
        public Guerrero(string nombre) : base(200, nombre, 50)
        {
        }
        public override void Atacar(Personaje objetivo)
        {
            if (vivo)
            {
                Console.WriteLine(Nombre + " lanzo un Espadazo a " + objetivo.Nombre + " y le causo " + daño + " de daño");
                objetivo.RecibirDaño(daño);
            }
            else
            {
                Console.WriteLine(Nombre + " esta muerto y no puede atacar");
            }
        }
        public void RecibirCura(int cura)
        {
            if (vivo)
            {
                vida += cura;
            }
            else
            {
                Console.WriteLine(Nombre + " esta muerto y no se puede curar");
            }
        }
    }
}
