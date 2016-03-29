using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game2
{
    class Fisicas
    {
        public float grav = 5;       
        public float impulso = -(15 / 6);
        public float deslocamento;

        public void AdicionarGravidade(Personagem x)
        {
            x.posicaoY = x.posicaoY + grav;


        }
        /*
        public void LimitaPulo(Personagem x, bool pulando)
        {
            float alturaMax =  200;

            if (x.posicaoY <= alturaMax)
            {
                x.posicaoY = alturaMax;
                pulando = false;
                
            }
            
        }
         */
        public bool pulo(Personagem x,bool pulando)
        {
                float alturaMax =200;
                x.posicaoY = x.posicaoY - 7;
               

                if (x.posicaoY <= alturaMax)
                {
                    x.posicaoY = alturaMax;
                    pulando = false;

                }
                return pulando;
         

        }
 /* 
        public void Pular(Personagem x,bool y)
        {   
            x.posicaoY = x.posicaoY + impulso;
            
            if((alturaMax -x.posicaoY)== 150){
                 y = false;

            }
        }
        */

    }
}
