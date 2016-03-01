using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace Game2
{
    class Personagem
    {
        private float posicaoX;
        private float posicaoY;
        private Texture2D textura;
        private bool estaVivo;

        //Encapsulamento
        public float getPosicaoX()
        {
            return posicaoX;
        }
        public void setPosicaoX(float posicaoX)
        {
            this.posicaoX = posicaoX;
        }
        public float getPosicaoY()
        {
            return posicaoY;
        }
        public void setPosicaoY(float posicaoY)
        {
            this.posicaoY = posicaoY;
        }
        public Texture2D getTextura()
        {
            return textura;
        }
        public void setTextura(Texture2D textura)
        {
            this.textura = textura;
        }

        public bool getEstaVivo()
        {
            return estaVivo;
        }
        public void setEstaVivo(bool estaVivo)
        {
            this.estaVivo = estaVivo;
        }


    
    }
}
