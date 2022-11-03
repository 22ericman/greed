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
            Trash Trash = new Trash();
            var ScreenHeight = 520;
            var ScreenWidth = 800;
            Raylib.InitWindow(ScreenWidth, ScreenHeight, "Greed");
            Raylib.InitAudioDevice();
            Raylib.SetTargetFPS(60);
           


            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);

                // Adds a new trash object every tick (that is a lot, we will want to turn that down to maybe like once every 60 ticks? 
                // still once a second but a lot less then currently)
                Trash.UpdateAddTrashList();

                //A for loop for each item in the list that updates each falling trash object, if it is too low it deletes it, in this for loop we will also need to do
                //the hit detection for the player chracter (moselys head hehe)  
                var ListAmount = Trash.TrashList.Count;
                for( int i = 0; i < ListAmount; i++)
                {
                
                Trash.TrashList[i] = Trash.TrashFalling(Trash.TrashList[i]);
                Raylib.DrawRectangleRec(Trash.TrashList[i], Color.BLUE);
                    if (Trash.TrashList[i].y >= 485)
                    {
                        Trash.TrashList.Remove(Trash.TrashList[i]);
                        ListAmount = Trash.TrashList.Count;
                    }
                
                }

                //These two lines add mosleys texture into the game, and then moves it around with the arrowkeys.
                var TextureReturn = Player.playerImage();
                Player.PlayerCharacter(TextureReturn);

                


                Raylib.EndDrawing();
            }
            Raylib.CloseAudioDevice();
            Raylib.CloseWindow();
        }
    }
}

