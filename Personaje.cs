using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Ficha_738
{
    public abstract class Personaje
    {
        protected int vida;
        public string Nombre;
        protected int daño;
        protected bool vivo;
        public Personaje(int vida, string nombre, int daño)
        {
            this.vida = vida;
            this.daño = daño;
            Nombre = nombre;
            vivo = true;
        }
        public abstract void Atacar(Personaje objetivo);
        public void RecibirDaño(int daño)
        {
            if (vivo)
            {
                vida -= daño;

                if (vida <= 0)
                {
                    vida = 0;
                    vivo = false;
                    Console.WriteLine(Nombre + " acaba de morir");
                }
            }
            else
            {
                Console.WriteLine(Nombre + " ya esta muerto");
            }
        }
        public void MostrarDatos()
        {
            Console.WriteLine(Nombre + " tiene " + vida + " puntos de vida");
        }
    }
}
