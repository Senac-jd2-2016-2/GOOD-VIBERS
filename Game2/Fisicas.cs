using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game2
{
    class Fisicas
    {
        public float grav = 3;
        public float alturaMax = 150;
        public float impulso = -(15 / 6);
        public float deslocamento;

        public void AdicionarGravidade(Personagem x)
        {
            x.posicaoY = x.posicaoY + grav;


        }
        public void Pular(Personagem x,bool y)
        {   
            x.posicaoY = x.posicaoY + impulso;
            
            if((alturaMax -x.posicaoY)== 150){
                 y = false;

            }
        }


    }
}
