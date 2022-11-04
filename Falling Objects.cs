using Raylib_cs;
using System.Numerics;


//This class will create falling objects for both treasure and trash.
class Falling : MovementObjects
{
    Random rnd = new Random();
    MovementObjects falling = new MovementObjects();
    
    public Falling()
    {
    falling.MovementSpeed = 4;
    }

    //Takes a single falling object and causes it to fall down continually
    public float FallingDown(float CurrentObject)
    {
        CurrentObject = falling.MovePositive(CurrentObject);
        return CurrentObject;
    }

    //Generates a single falling object at a random point on the top of the screen
    public Rectangle FallingObject()
    {
        Rectangle FallingObject = new Rectangle(rnd.Next(0, 750), 10, 10, 10);

        return FallingObject;
    }
    
    
}
