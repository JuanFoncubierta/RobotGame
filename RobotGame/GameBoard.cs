namespace RobotGame;

public class GameBoard
{
    public List<BoardObject> ObjectsOnTheBoard;
    private int minX;
    private int minY;
    private int maxX;
    private int maxY;
    public GameBoard(int _minX, int _minY, int _maxX, int _maxY)
    {
        ObjectsOnTheBoard = new();
        minX = _minX;
        minY = _minY;
        maxX = _maxX;
        maxY = _maxY;
    }
}
