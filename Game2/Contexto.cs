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
        public static Personagem jogador = new Personagem(150, 50);
        public static Texture2D background ;
        public static Personagem inimigo = new Personagem(600, 260);
        public static Fisicas fisica = new Fisicas();
        public static Fase1 Fas1 = new Fase1();

        public static void inicializar(ContentManager content)
        {
      
            jogador.textura = content.Load<Texture2D>("Kirby");
            inimigo.textura = content.Load<Texture2D>("ms5");
            
            background = content.Load<Texture2D>("Fundo");

        }
  
    }
}
