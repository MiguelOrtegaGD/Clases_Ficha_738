namespace Clases_Ficha_738
{
    public abstract class Cofre
    {
        protected bool abierto = false;
        public abstract Objeto Abrir(ILlave llave);
    }
}
