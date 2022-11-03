using Raylib_cs;
using System.Numerics;

class Trash : Falling

{
    public List<Rectangle> TrashList = new List<Rectangle>();
    MovementObjects Movement = new MovementObjects();
    public int GenerateTrash;
    Falling fall = new Falling();

   

    public Trash()
    {
        GenerateTrash = 0;
        Movement.MovementSpeed = 4;
    }
// Creates a single falling trash item
    private Rectangle CreateTrashObject()
    {
    
        var TrashObject = fall.FallingObject();
        return TrashObject;
    }
// Causes the trash to fall
    public Rectangle TrashFalling(Rectangle TrashObject)
    {
        
        TrashObject.y = fall.FallingDown(TrashObject.y);
        return TrashObject;
    }

// Adds a single trash object to the trash list
    private List<Rectangle> AddTrashListObject(Rectangle TrashObject)
    {
        TrashList.Add(TrashObject);
        return TrashList;
    }

// Subtracts a single trash item from the list
    private List<Rectangle> SubTrashListObject(Rectangle TrashObject)
    {
        TrashList.Remove(TrashObject);
        return TrashList;
    }

//Is the function used to call the AddTrashListObject Method
    public void UpdateAddTrashList()
    {
         AddTrashListObject(CreateTrashObject());
    }
//Is the function used to call the SubTrashListObject Method
    public void UpdateSubTrashList(Rectangle TrashObject)
    {
         SubTrashListObject(TrashObject);

    }
    

}