using Raylib_cs;
using System.Numerics;
using static Raylib_cs.Raylib;

namespace Greed
{
     class Program : MovementObjects
    {
    
        public static void Main()
        {
            //sets things up.
            Player Player = new Player();
            TrashObject TrashObject = new TrashObject();
            TreasureObject TreasureObject = new TreasureObject();
            FallBlock FallBlock = new FallBlock();
            var ScreenHeight = 520;
            var ScreenWidth = 800;
            Raylib.InitWindow(ScreenWidth, ScreenHeight, "Greed");
            Raylib.InitAudioDevice();
            Raylib.SetTargetFPS(60);
           

        

           


            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);
                var score = TreasureObject.score + TrashObject.score;
                Raylib.DrawText($"Collect the circles and avoid the squares!        Your score is {score}", 12, 12, 18, Color.WHITE);
                // TreasureObject.UpdatePositiveScore();
                //These two lines add mosleys texture into the game, and then moves it around with the arrowkeys.
                var TextureReturn = Player.playerImage();
                Player.PlayerCharacter(TextureReturn);
                PlaySound(FallBlock.sound);
                 
                TrashObject.DisplayFallingBlocksFull(Player.CircleCenter);

                TreasureObject.DisplayFallingBlocksFull(Player.CircleCenter);

                Raylib.EndDrawing();
            }
            Raylib.CloseAudioDevice();
            Raylib.CloseWindow();
        }
    }
}

