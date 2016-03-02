using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game2
{
  //alt
    //alt2
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

  
        protected override void Initialize()
        {
   

            base.Initialize();
            Contexto.inicializar(Content);
            
          
        }

  
        protected override void LoadContent()
        {
            
            spriteBatch = new SpriteBatch(GraphicsDevice);

          
        }

  
        protected override void UnloadContent()
        {
        }

       
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            Keys[] keys = Keyboard.GetState().GetPressedKeys();

            foreach(Keys a in keys)
            {
                if (a.Equals(Keys.Right) || a.Equals(Keys.D))
                {
                    Contexto.jogador.moverX(2);
                }
                if (a.Equals(Keys.Left) || a.Equals(Keys.A))
                {
                    Contexto.jogador.moverX(-2);
                }
                if (a.Equals(Keys.Space))
                {
                    Contexto.jogador.moverY(-2);
                }
            }

            Fisicas.AdicionarGravidade(Contexto.jogador);      

            base.Update(gameTime);
        }


        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            spriteBatch.Draw(Contexto.background, new Rectangle(0, 0, 800, 480), Color.White);
            spriteBatch.Draw(Contexto.jogador.textura, Contexto.jogador.getVector2(), Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
