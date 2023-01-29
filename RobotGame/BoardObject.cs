namespace RobotGame;

public enum BoardObjectType
{
    Wall = 1,
    Robot = 2
}

public class BoardObject
{
    public int positionX { get; set; }
    public int positionY { get; set; }
    public BoardObjectType boardObjectType { get; set; }
}
