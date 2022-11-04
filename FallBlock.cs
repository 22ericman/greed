using Raylib_cs;
using System.Numerics;

class FallBlock : Falling

{
    public List<Rectangle> FallBlockList = new List<Rectangle>();
    MovementObjects Movement = new MovementObjects();
    public int GenerateFallBlock;

    public Color COLOR;
    Falling fall = new Falling();

   

    public FallBlock()
    {
        GenerateFallBlock = 0;
        Movement.MovementSpeed = 4;
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
    

    private void DisplayFallBlock()
    {
        if (GenerateFallBlock == 0)
        {
            UpdateAddFallBlockList();
        }
    }

    private void DisplayFallBlockList()
    {
                //A for loop for each item in the list that updates each falling trash object, if it is too low it deletes it, in this for loop we will also need to do
                //the hit detection for the player chracter (moselys head hehe)  
        var ListAmount = FallBlockList.Count;
        for(int i = 0; i < ListAmount; i++)
        {
        FallBlockList[i] = FallBlockFalling(FallBlockList[i]);
        Raylib.DrawRectangleRec(FallBlockList[i], Color.BLUE);
            if (FallBlockList[i].y >= 485)
            {
                FallBlockList.Remove(FallBlockList[i]);
                ListAmount = FallBlockList.Count;
            }
        
        }
    }

    //Counts the the frames and resets the counter to know when to create a trash object
    private void NumberResetter()
    {
        GenerateFallBlock += 1;
                if (GenerateFallBlock == 30)
                    {
                    GenerateFallBlock = 0;
                    }
    }
    public void DisplayFallingBlocksFull()
    {
        DisplayFallBlock();
        DisplayFallBlockList();
        NumberResetter();

    }
}

