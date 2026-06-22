using System;

namespace Clases_Ficha_738
{
    internal class BolaHielo
    {
        public void Congelar(ICongelable objetivo)
        {
            objetivo.Congelar();
        }
    }
}
