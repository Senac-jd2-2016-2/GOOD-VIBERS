using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Content;

namespace Game2
{
    class Contexto
    {
        public static Personagem jogador = new Personagem(150, 240);
        public static Texture2D background ;
        public static Fisicas fisica = new Fisicas();
        public static Mapa Fas1 = new Mapa();

        public static void inicializar(ContentManager content)
        {
      
            jogador.textura = content.Load<Texture2D>("Kirby");
            background = content.Load<Texture2D>("Fundo");

        }
    }
}
