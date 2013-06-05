using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tetris
{
    class Block : DrawableGameComponent
    {
        public Color color { get; set; }
        public Rectangle rectangle { get; set; }
        public Tuple gridPosition { get; set; }
        public Vector2 position { get; set; }
        public static Texture2D texture { get; set; }
        public Double time { get; set; }
        public bool IsPartofShape { get; set; }

        public Block() : base(Static.game)
        {
            if (gridPosition == null)
            {
                gridPosition = new Tuple();
            }
            rectangle = new Rectangle(gridPosition.X, gridPosition.Y, 20, 20);
            color = Color.DarkRed;
            
        }
        public Block(int x, int y) : this()
        {
            gridPosition = new Tuple(x, y);
            rectangle = new Rectangle(gridPosition.X, gridPosition.Y, 20, 20);
            
        }
        public override void Draw(GameTime gameTime)
        {

            Static.spritebatch.Begin();
            Static.spritebatch.Draw(texture, rectangle, color);
            Static.spritebatch.End();
             base.Draw(gameTime);
        }

        public override void Update(GameTime gameTime)
        {

             time += gameTime.ElapsedGameTime.TotalMilliseconds;

             if (time < 1000)
             {
                 return;
             }
             else
             {
                 gridPosition.Y += 20;
                 time = 0.0;
             }
            
            rectangle = new Rectangle(gridPosition.X, gridPosition.Y , 20, 20);
             base.Update(gameTime);
        }
       
        
    }
}
