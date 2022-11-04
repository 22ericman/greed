using Raylib_cs;
using System.Numerics;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;
using static Raylib_cs.PixelFormat;

class Player : MovementObjects
{
    public float xValue;
    public float yValue;

    
    public Vector2 CircleCenter = new Vector2();

    MovementObjects Movement = new MovementObjects();
    public Player()
{

     xValue = 380;
     yValue = 420;
     Movement.MovementSpeed = 5;
     CircleCenter.X = 380+27;
     CircleCenter.Y = 420+27;

}


// Loads in the mosely texture and returns it to the functions
    public Texture2D playerImage() 
    {
        Image image = LoadImage("img/broMosely.png");
        ImageResize(ref image, 50, 50);
       
        Texture2D texture = LoadTextureFromImage(image);
        UnloadImage(image);
        return texture;
    }
    //sound class that makes an umph sound
    /*public Sound playerSound() {
        Wave wave = Raylib.LoadWave("img/MinecraftDamage.wav");
            Sound sound = Raylib.LoadSoundFromWave(wave);
            Wave wave2 = Raylib.LoadWave("img/yes.wav");
            Sound sound2 = Raylib.LoadSoundFromWave(wave2);
        //Sound sound = LoadSoundFromWave("img/MinecraftDamage.wav");
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE)) {
                    Raylib.PlaySound(sound);
                }

    }*/

// Takes the loaded texture and moves around the x and y values according to the arrow keys pressed. 
// Only allows you to move to certain values so you are kept in a box.
    public void PlayerCharacter(Texture2D texture)
    {
                
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT) && xValue != 760) {
                    xValue = Movement.MovePositive(xValue);
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT) && xValue != 0) {
                    xValue = Movement.MoveNegative(xValue);
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP)&& yValue != 420) {
                    yValue = Movement.MoveNegative(yValue);
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN) && yValue !=475) {
                    yValue = Movement.MovePositive(yValue);
                }
                int NewX = (int) xValue;
                int NewY = (int) yValue;
                CircleCenter.X = (NewX+27);
                CircleCenter.Y = (NewY+27);
                DrawCircleV(CircleCenter, 23, BLACK);
                DrawTexture(texture, NewX, NewY, WHITE);
                
                
                
    }

    
}



