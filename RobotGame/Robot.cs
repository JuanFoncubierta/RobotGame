namespace RobotGame;

public class Robot:BoardObject
{
    public Directions.directions faceDirection;
    public Robot(string _faceDirection, int _positionX, int _positionY)
    {
        faceDirection = Directions.GetFacing(_faceDirection);
        positionX = _positionX;
        positionY = _positionY;
        boardObjectType = BoardObjectType.Robot;
    }

    public void move()
    {

    }

    public void left()
    {

    }

    public void right()
    {

    }
}
