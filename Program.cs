﻿using Raylib_cs;
using System.Numerics;


namespace Greed
{
static class Program
    {
        public static void Main()
        {    
            Raylib.InitWindow(2000, 1000, "GREED");
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);


                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}













//character
public class Character {
    public void Player() {
            var posHeight = 1500;
            var posWidth = 1000;
            var shipPosition = new Vector2(posHeight, posWidth);
            var player = new Rectangle(100, 100, 50, 50);
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

                Raylib.DrawRectangleRec(player, Color.GOLD);
}
}
