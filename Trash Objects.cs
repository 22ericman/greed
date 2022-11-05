
using Raylib_cs;
using System.Numerics;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;
using static Raylib_cs.PixelFormat;

class TrashObject : FallBlock


{
    public TrashObject()
    {
        COLOR = Color.RED;
        TrashOrTreasure = 2;
    }
    public void DisplayFallingBlocksFull(Vector2 VectorPosition)
    {
        DisplayFallBlock();
        DisplayFallBlockList(VectorPosition);
        NumberResetter();
    }
    public void NumberResetter()
    {
        GenerateFallBlock += 1;
                if (GenerateFallBlock == 15)
                    {
                    GenerateFallBlock = 0;
                    }
    }
}