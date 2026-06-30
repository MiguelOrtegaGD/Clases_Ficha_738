using System;

namespace Clases_Ficha_738
{
    internal class CofreComun : Cofre
    {
        public override Objeto Abrir(ILlave llave)
        {
            if (abierto == false)
            {
                Console.WriteLine("El cofre comun fue abierto");
                abierto = true;
                return new Objeto("Monedas", 100);
            }
            else
            {
                Console.WriteLine("No se pudo abrir el cofre comun");
                return null;
            }
        }
    }
}
