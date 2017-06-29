namespace WalkingGame
{
    using System;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using Microsoft.Xna.Framework.Input.Touch;

    class CharacterEntity
    {
        private static Texture2D characterSheetTexture;
        Animation walkDown;
        Animation walkUp;
        Animation walkLeft;
        Animation walkRight;

        Animation standDown;
        Animation standUp;
        Animation standLeft;
        Animation standRight;

        Animation currentAnimation;
        public float X { get; set; }
        public float Y { get; set; }

        public CharacterEntity(GraphicsDevice graphicsDevice)
        {
            if (characterSheetTexture == null)
            {
                using (var stream = TitleContainer.OpenStream("Content/charactersheet.png"))
                {
                    characterSheetTexture = Texture2D.FromStream(graphicsDevice, stream);
                }
            }
            walkDown = new Animation();
            walkDown.AddFrame(new Rectangle(0, 0, 16, 16), TimeSpan.FromSeconds(.25));
            walkDown.AddFrame(new Rectangle(16, 0, 16, 16), TimeSpan.FromSeconds(.25));
            walkDown.AddFrame(new Rectangle(0, 0, 16, 16), TimeSpan.FromSeconds(.25));
            walkDown.AddFrame(new Rectangle(32, 0, 16, 16), TimeSpan.FromSeconds(.25));

            walkUp = new Animation();
            walkUp.AddFrame(new Rectangle(144, 0, 16, 16), TimeSpan.FromSeconds(.25));
            walkUp.AddFrame(new Rectangle(160, 0, 16, 16), TimeSpan.FromSeconds(.25));
            walkUp.AddFrame(new Rectangle(144, 0, 16, 16), TimeSpan.FromSeconds(.25));
            walkUp.AddFrame(new Rectangle(176, 0, 16, 16), TimeSpan.FromSeconds(.25));

            walkLeft = new Animation();
            walkLeft.AddFrame(new Rectangle(48, 0, 16, 16), TimeSpan.FromSeconds(.25));
            walkLeft.AddFrame(new Rectangle(64, 0, 16, 16), TimeSpan.FromSeconds(.25));
            walkLeft.AddFrame(new Rectangle(48, 0, 16, 16), TimeSpan.FromSeconds(.25));
            walkLeft.AddFrame(new Rectangle(80, 0, 16, 16), TimeSpan.FromSeconds(.25));

            walkRight = new Animation();
            walkRight.AddFrame(new Rectangle(96, 0, 16, 16), TimeSpan.FromSeconds(.25));
            walkRight.AddFrame(new Rectangle(112, 0, 16, 16), TimeSpan.FromSeconds(.25));
            walkRight.AddFrame(new Rectangle(96, 0, 16, 16), TimeSpan.FromSeconds(.25));
            walkRight.AddFrame(new Rectangle(128, 0, 16, 16), TimeSpan.FromSeconds(.25));

            // Standing animations only have a single frame of animation:
            standDown = new Animation();
            standDown.AddFrame(new Rectangle(0, 0, 16, 16), TimeSpan.FromSeconds(.25));

            standUp = new Animation();
            standUp.AddFrame(new Rectangle(144, 0, 16, 16), TimeSpan.FromSeconds(.25));

            standLeft = new Animation();
            standLeft.AddFrame(new Rectangle(48, 0, 16, 16), TimeSpan.FromSeconds(.25));

            standRight = new Animation();
            standRight.AddFrame(new Rectangle(96, 0, 16, 16), TimeSpan.FromSeconds(.25));
        }

        public Point GetInput()
        {

            KeyboardState state = Keyboard.GetState();
            Point point = new Point();
            if (state.IsKeyDown(Keys.S))
            {
                // this.Y += 5;
                point.Y += 15;
            }
            if (state.IsKeyDown(Keys.W))
            {
                //this.Y -= 5;
                point.Y -= 15;
            }
            if (state.IsKeyDown(Keys.A))
            {

                // this.X -= 5;
                point.X -= 15;
            }
            if (state.IsKeyDown(Keys.D))
            {

                //this.X += 5;
                point.X += 15;
            }
            return point;
        }
        Vector2 GetDesiredVelocityFromInput()
        {
            Vector2 desiredVelocity = new Vector2();

            var newPoint = this.GetInput();


            if ((this.X + newPoint.X) + 5 < Globals.GLOBAL_WIDTH && (this.X + newPoint.X) + 13 >= 0 &&
                (this.Y + newPoint.Y) + 5 < Globals.GLOBAL_HEIGHT && (this.Y + newPoint.Y) + 13 >= 0)
            {
                desiredVelocity.X = newPoint.X;
                desiredVelocity.Y = newPoint.Y;

                if (desiredVelocity.X != 0 || desiredVelocity.Y != 0)
                {
                    desiredVelocity.Normalize();
                    const float desiredSpeed = 200;
                    desiredVelocity *= desiredSpeed;
                }
            }

            return desiredVelocity;
        }
        public void Update(GameTime gameTime)
        {

            //this.GetInput();
            Vector2 velocity = Vector2.Zero;
            if (this.currentAnimation != null)
            {
                velocity = GetDesiredVelocityFromInput();

                this.X += velocity.X * (float)gameTime.ElapsedGameTime.TotalSeconds;
                this.Y += velocity.Y * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }

            if (velocity != Vector2.Zero)
            {
                bool movingHorizontally = Math.Abs(velocity.X) > Math.Abs(velocity.Y);
                if (movingHorizontally)
                {
                    if (velocity.X > 0)
                    {
                        currentAnimation = walkRight;
                    }
                    else
                    {
                        currentAnimation = walkLeft;
                    }
                }
                else
                {
                    if (velocity.Y > 0)
                    {
                        currentAnimation = walkDown;
                    }
                    else
                    {
                        currentAnimation = walkUp;
                    }
                }
            }
            else
            {
                // If the character was walking, we can set the standing animation
                // according to the walking animation that is playing:
                if (currentAnimation == walkRight)
                {
                    currentAnimation = standRight;
                }
                else if (currentAnimation == walkLeft)
                {
                    currentAnimation = standLeft;
                }
                else if (currentAnimation == walkUp)
                {
                    currentAnimation = standUp;
                }
                else if (currentAnimation == walkDown)
                {
                    currentAnimation = standDown;
                }
                else if (currentAnimation == null)
                {
                    currentAnimation = standDown;
                }

                // if none of the above code hit then the character
                // is already standing, so no need to change the animation.
            }


            currentAnimation.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Vector2 topLeftPos = new Vector2(this.X, this.Y);
            Color tint = Color.White;

            var sourceRectangle = this.currentAnimation.CurrentRectangle;

            spriteBatch.Draw(characterSheetTexture, topLeftPos, sourceRectangle, tint);
        }
    }
}
