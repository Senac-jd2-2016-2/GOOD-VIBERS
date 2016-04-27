using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
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
        public Vector2 retornaPosicao(Personagem x)
        {
            
            return new Vector2(x.posicaoX, x.posicaoY);
            
           
        }        

        public bool pulo(Personagem x,bool pulando,float[] posicaoAtual, Mapa fase)
        {
           
                float alturaMax = posicaoAtual[1] - 200;
                x.posicaoY = x.posicaoY - 7;
               

                if (x.posicaoY <= alturaMax || x.posicaoY <= fase.ymax)
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
