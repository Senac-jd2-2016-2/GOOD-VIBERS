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
          
        }

  
        protected override void LoadContent()
        {
            Jogador j1 = new Jogador();
            j1.setTextura(Content.Load<Texture2D>("Kirby"));
            spriteBatch = new SpriteBatch(GraphicsDevice);

          
        }

  
        protected override void UnloadContent()
        {
        }

       
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

      

            base.Update(gameTime);
        }


        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            SpriteBatch.Begin();

            base.Draw(gameTime);
        }
    }
}
