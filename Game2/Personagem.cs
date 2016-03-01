using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Game2
{
    class Personagem
    {
        public float posicaoX;
        public float posicaoY;
        public Texture2D textura;
        public bool estaVivo;

        public Personagem(int x1, int y1)
        {
            posicaoX = x1;
            posicaoY = y1;
        }

        public Vector2 getVector2() 
        {
            return new Vector2(posicaoX, posicaoY);
        }

        public void moverX(int quantidadeDePassos)
        {
            posicaoX += quantidadeDePassos;
        }
        public void moverY(int quantidadeDePassos)
        {
            posicaoY += quantidadeDePassos;
        }
    
    }
}
