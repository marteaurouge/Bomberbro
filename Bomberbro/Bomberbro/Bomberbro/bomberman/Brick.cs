﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bomberbro.Helpers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Bomberbro.bomberman
{
    public abstract class Brick : GamefieldItem
    {
        protected Rectangle _brickRectangle;
        protected Texture2D _brickTextures;
        protected SpriteHelper _brick;



     

        public override void Update(GameTime gameTime)
        {
            //dummy, abstract blocks do nothing
        }

        public override void Draw(int positionX, int positionY, GameTime gameTime)
        {
            _brick.Render(positionX, positionY);
        }
    }
}
