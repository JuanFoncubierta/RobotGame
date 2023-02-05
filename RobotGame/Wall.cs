namespace RobotGame;

public class Wall:BoardObject
{
    public Wall(int _positionX, int _positionY)
    {
        positionX = _positionX;
        positionY = _positionY;
        boardObjectType = BoardObjectType.Wall;
        canBeOverwritten = true;
    }
}
