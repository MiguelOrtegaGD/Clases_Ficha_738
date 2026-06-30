using System;

namespace Clases_Ficha_738
{
    internal class CofreDorado : Cofre
    {
        public override Objeto Abrir(ILlave llave)
        {
            if (llave is ILlaveDorada dorada && abierto == false)
            {
                Console.WriteLine("El cofre dorado fue abierto");
                abierto = true;
                return new Objeto("Monedas", 500);
            }
            else
            {
                Console.WriteLine("No se pudo abrir el cofre dorado");
                return null;
            }
        }
    }
}
