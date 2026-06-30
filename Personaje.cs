using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Ficha_738
{
    public class Personaje
    {
        string nombre;

        List<Objeto> objetos = new List<Objeto>();

        public void AgregarObjeto(Objeto objeto)
        {
            if (objeto != null)
            {
                objetos.Add(objeto);
            }
        }
        public void MostrarObjetos()
        {
            foreach (var item in objetos)
            {
                Console.WriteLine(item.nombre + " cantidad:" + item.cantidad);
            }
        }
    }
}
