
using System;

namespace Clases_Ficha_738
{
    internal class CofreLegendario : Cofre
    {
        public override Objeto Abrir(ILlave llave)
        {
            if (llave is ILlaveLegendaria legendaria && abierto == false)
            {
                Console.WriteLine("El cofre legendario fue abierto");
                abierto = true;
                return new Objeto("Objeto legendario", 1);
            }
            else
            {
                Console.WriteLine("No se pudo abrir el cofre legendario");
                return null;
            }
        }
    }
}
