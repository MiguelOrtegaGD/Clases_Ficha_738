using System;
using System.Collections.Generic;

namespace Clases_Ficha_738
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CofreComun cofreComun1 = new CofreComun();
            CofreComun cofreComun2 = new CofreComun();

            CofreDorado cofreDorado = new CofreDorado();
            CofreLegendario cofreLegendario = new CofreLegendario();

            Aventurero aventurero = new Aventurero();
            Ladron ladron = new Ladron();
            Mago mago = new Mago();


            mago.AgregarObjeto(cofreComun1.Abrir(mago));
            mago.AgregarObjeto(cofreComun2.Abrir(mago));

            mago.MostrarObjetos();
        }
    }
}
