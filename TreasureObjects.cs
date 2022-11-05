using Raylib_cs;
using System.Numerics;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;
using static Raylib_cs.PixelFormat;

class TreasureObject: FallBlock
{

    public TreasureObject()
    {
        COLOR = Color.GREEN;
        TrashOrTreasure = 1;
    }

    public void DisplayFallingBlocksFull(Vector2 VectorPosition)
    {
        DisplayFallBlock();
        DisplayFallBlockList(VectorPosition);
        NumberResetter();
    }


}
