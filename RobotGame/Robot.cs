namespace RobotGame;

public class Robot:BoardObject
{
    public Directions.directions faceDirection;
    public Robot(string _faceDirection, int _positionX, int _positionY)
    {
        FaceDirection = Directions.directions.Where(x => x.Value == _faceDirection).First().Key;
        positionX = _positionX;
        positionY = _positionY;
    }
}
