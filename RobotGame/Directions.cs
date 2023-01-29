namespace RobotGame;

public static class Directions
{
    public enum directions
    {
        NORTH = 1,
        WEST = 2,
        SOUTH = 3,
        EAST = 4
    }

    public static directions Left(directions actualFacing)
    {
        int facing = ((int)actualFacing + 1);
        if (facing > 4)
            facing = facing % 4;
        return (directions)facing;
    }

    public static directions Right(directions actualFacing)
    {
        int facing = ((int)actualFacing - 1);
        if (facing < 1)
            facing = facing + 4;
        return (directions)facing;
    }

    public static directions GetFacing(string _facing)
    {
        directions directionFacing;
        Enum.TryParse<directions>(_facing, out directionFacing);
        return directionFacing;
    }
}
