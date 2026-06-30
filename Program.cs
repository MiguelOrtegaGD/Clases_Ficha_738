using System;
using System.Collections.Generic;

namespace Clases_Ficha_738
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdministradorJuego admin = new AdministradorJuego();

            Enemigo e1 = new Enemigo("Elian");
            Enemigo e2 = new Enemigo("Arismendy");
            Enemigo e3 = new Enemigo("Simon");

            GeneradorSorpresas g1 = new GeneradorSorpresas();
            GeneradorSorpresas g2 = new GeneradorSorpresas();
            GeneradorSorpresas g3 = new GeneradorSorpresas();

            Jugador j1 = new Jugador();

            admin.JuegoIniciado += e1.HabilitarMovimiento;
            admin.JuegoIniciado += e2.HabilitarMovimiento;
            admin.JuegoIniciado += e3.HabilitarMovimiento;

            admin.JuegoIniciado += g1.GenerarSorpresa;
            admin.JuegoIniciado += g2.GenerarSorpresa;
            admin.JuegoIniciado += g3.GenerarSorpresa;

            admin.JuegoIniciado += j1.HabilitarMovimiento;

            admin.PausarJuego();

            Console.ReadLine();

            admin.IniciarJuego();


            admin.JuegoIniciado -= e1.HabilitarMovimiento;
            admin.JuegoIniciado -= e2.HabilitarMovimiento;
            admin.JuegoIniciado -= e3.HabilitarMovimiento;

            admin.JuegoIniciado -= g1.GenerarSorpresa;
            admin.JuegoIniciado -= g2.GenerarSorpresa;
            admin.JuegoIniciado -= g3.GenerarSorpresa;

            admin.JuegoIniciado -= j1.HabilitarMovimiento;
        }
    }
}
