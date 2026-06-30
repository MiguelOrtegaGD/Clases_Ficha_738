using System;

namespace Clases_Ficha_738
{
    public class AdministradorJuego
    {
        public Action JuegoIniciado;
        public Action JuegoPausado;
        public void IniciarJuego()
        {
            Console.WriteLine("El juego ha iniciado");
            JuegoIniciado?.Invoke();
        }
        public void PausarJuego()
        {
            Console.WriteLine("El juego ha sido pausado");
            JuegoPausado?.Invoke();
        }
    }
}
