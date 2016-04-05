using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game2
{
    class Fase1 : Mapa
    {

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
            if (x.posicaoX >= 380 && x.posicaoX <= 550 && x.posicaoY <= 300)
            {
                ymin = yminplataforma;
            }
            else
            {
                ymin = 370;
            }
        }
    }
}
