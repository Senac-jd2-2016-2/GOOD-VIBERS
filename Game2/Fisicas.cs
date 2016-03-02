using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game2
{
    class Fisicas
    {
        public float grav = 10;
        
        public void AdicionarGravidade(Personagem x)
        {
            x.posicaoY = x.posicaoY + grav;


        }


    }
}
