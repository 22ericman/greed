class MovementObjects
{
public float MovementSpeed;


// Moves x or y positively.
public float MovePositive(float CurrentObject)
{
 CurrentObject += MovementSpeed;
 return CurrentObject;
}

//Moves x or y negativelty
public float MoveNegative(float CurrentObject)
{
 CurrentObject -= MovementSpeed;
 return CurrentObject;
}


}

 

//Just a small note, raylib for some reason has it when Y increases, it actually moves down. Keep that in mind.


