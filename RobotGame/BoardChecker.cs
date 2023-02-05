namespace RobotGame;

public static class BoardChecker
{
    public static bool IsThereARobot(GameBoard board)
    {
        if (board.objectsOnTheBoard.Where(x => x.boardObjectType == BoardObjectType.Robot).Any()) return true;
        return false;
    }

    public static bool CoordinateOcupied(int _x, int _y, GameBoard board)
    {
        if (board.objectsOnTheBoard.Where(x => x.positionX == _x && x.positionY == _y).First().boardObjectType == BoardObjectType.Wall) return true;
        return false;
    }
}
