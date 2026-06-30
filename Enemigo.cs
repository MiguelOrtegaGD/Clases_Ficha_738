using System;
namespace Clases_Ficha_738
{
    internal class Enemigo
    {
        string nombre;
        public Enemigo(string nombre)
        {
            this.nombre = nombre;
        }
        public void HabilitarMovimiento()
        {
            Console.WriteLine("El enemigo " + nombre + " empezo a moverse");
        }
    }
}
