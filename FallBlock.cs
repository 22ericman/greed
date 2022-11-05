using Raylib_cs;
using System.Numerics;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;
using static Raylib_cs.PixelFormat;

class FallBlock : Falling

{
    public List<Rectangle> FallBlockList = new List<Rectangle>();
    MovementObjects Movement = new MovementObjects();
    public int GenerateFallBlock;

    public Vector2 updater = new Vector2();
    public bool current;
    public Color COLOR;
    public int score;
    Falling fall = new Falling();

    public Sound sound;
    public Sound sound2;
    public Wave wave2;
    public Wave wave; 


    public int TrashOrTreasure;
    //sound class that makes an umph sound
        //Sound sound = LoadSoundFromWave("img/MinecraftDamage.wav");
    


   

    public FallBlock()
    {
        GenerateFallBlock = 0;
        Movement.MovementSpeed = 4;
        current = true;
        TrashOrTreasure = 0;
        score = 0;
        
        
    }
// Creates a single falling FallBlock item
    private Rectangle CreateFallBlockObject()
    {
    
        var FallBlockObject = fall.FallingObject();
        return FallBlockObject;
    }
// Causes the FallBlock to fall
    public Rectangle FallBlockFalling(Rectangle FallBlockObject)
    {
        FallBlockObject.y = fall.FallingDown(FallBlockObject.y);
        return FallBlockObject;
    }

// Adds a single FallBlock object to the FallBlock list
    private List<Rectangle> AddFallBlockListObject(Rectangle FallBlockObject)
    {
        FallBlockList.Add(FallBlockObject);
        return FallBlockList;
    }

// Subtracts a single FallBlock item from the list
    private List<Rectangle> SubFallBlockListObject(Rectangle FallBlockObject)
    {
        FallBlockList.Remove(FallBlockObject);
        return FallBlockList;
    }

//Is the function used to call the AddFallBlockListObject Method
    public void UpdateAddFallBlockList()
    {
         AddFallBlockListObject(CreateFallBlockObject());
    }
//Is the function used to call the SubFallBlockListObject Method
    public void UpdateSubFallBlockList(Rectangle FallBlockObject)
    {
         SubFallBlockListObject(FallBlockObject);
    }
    

    public void DisplayFallBlock()
    {
        if (GenerateFallBlock == 0)
        {
            UpdateAddFallBlockList();
        }
    }

    public void DisplayFallBlockList(Vector2 VectorPosition)
    { 
                //A for loop for each item in the list that updates each falling trash object, if it is too low it deletes it, in this for loop we will also need to do
                //the hit detection for the player chracter (moselys head hehe)
        
        var ListAmount = FallBlockList.Count;
        for(int i = 0; i < ListAmount; i++)
        {
        FallBlockList[i] = FallBlockFalling(FallBlockList[i]);
        Raylib.DrawRectangleRec(FallBlockList[i], COLOR);
            
            if (CheckCollisionCircleRec(VectorPosition, 23, FallBlockList[i]))
            {
                FallBlockList.Remove(FallBlockList[i]);
                ListAmount = FallBlockList.Count;
                if (TrashOrTreasure == 1)
                {
                UpdatePositiveScore();
                wave2 = Raylib.LoadWave("img/yes.wav");
                sound2 = Raylib.LoadSoundFromWave(wave2);
                Raylib.PlaySound(sound2);
                }
                else if (TrashOrTreasure == 2)
                {
                UpdateNegativeScore();
                wave = Raylib.LoadWave("img/MinecraftDamage.wav");
                sound = Raylib.LoadSoundFromWave(wave);
                Raylib.PlaySound(sound);
                }
                
            }
            else if (FallBlockList[i].y >= 485)
            {
                FallBlockList.Remove(FallBlockList[i]);
                ListAmount = FallBlockList.Count;
            }
        }
    }

    //Counts the the frames and resets the counter to know when to create a trash object
    public void NumberResetter()
    {
        GenerateFallBlock += 1;
                if (GenerateFallBlock == 30)
                    {
                    GenerateFallBlock = 0;
                    }
    }
    public void DisplayFallingBlocksFull(Vector2 VectorPosition)
    {
        DisplayFallBlock();
        DisplayFallBlockList(VectorPosition);

        NumberResetter();

    }
    public void UpdatePositiveScore()
    {
        score += 25;
    }
    public void UpdateNegativeScore()
    {
        score -= 50;
    }


}

