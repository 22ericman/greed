using Raylib_cs;
using System.Numerics;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;
using static Raylib_cs.PixelFormat;


namespace Greed
{
static class Program
    {
        public static void Main()
        {   
            Character mosley = new Character(); 
            int screenWidth = 1000;
            int screenHeight = 500;
            Raylib.InitWindow(screenWidth, screenHeight, "GREED");
            Raylib.SetTargetFPS(60);
            var texture = mosley.playerImage();
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);
                

                DrawTexture(texture, screenWidth / 4 - texture.width / 4, screenHeight / 4 - texture.height / 4, WHITE);

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}






public class fallmovement
{
        int fallspeed = 4;
        Random rndY = new Random();
        Random rndX = new Random();
    
}






//character
public class Character {
    public void Player() {
            
            
            
            /*var player = playerImage();
            var playerSpeed = 50;
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
                    shipPosition.X += playerSpeed;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
                    shipPosition.X -= playerSpeed;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP)) {
                    shipPosition.Y -= playerSpeed;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)) {
                    shipPosition.Y  += playerSpeed;
                }

                Raylib.DrawRectangleRec(player, Color.GOLD);*/
}
    public Texture2D playerImage() {
        Image image = LoadImage("img/broMosely.png");
        ImageResize(ref image, 50, 50);
        Texture2D texture = LoadTextureFromImage(image);
        UnloadImage(image);
            
        return texture;
    }
}
