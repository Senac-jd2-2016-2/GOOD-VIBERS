using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game2
{
    class Mapa
    {
        public float ymin = 250 ;
        public float ymax = 0;
        
        public float x0;
        public float x1;

        public void LimitaChao(Personagem x)
        {
            if (x.posicaoY <= ymax)
            {
                x.posicaoY = ymax;
            }
            if (x.posicaoY >= ymin)
            {
                x.posicaoY = ymin;
            }
        }
    }
}
