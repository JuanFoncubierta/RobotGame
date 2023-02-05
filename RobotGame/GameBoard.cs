namespace RobotGame;

public class GameBoard
{
    public List<BoardObject> objectsOnTheBoard;
    public int minX;
    public int minY;
    public int maxX;
    public int maxY;

    public GameBoard(int _minX, int _minY, int _maxX, int _maxY)
    {
        objectsOnTheBoard = new();
        minX = _minX;
        minY = _minY;
        maxX = _maxX;
        maxY = _maxY;
    }

    public void ResetGame()
    {
        objectsOnTheBoard.Clear();
    }

    public void placeRobot(string command)
    {
        //we make sure the data is correct
        string[] splitCommand = command.Split(' ');
        if (splitCommand.Length < 2) return;

        string[] splitData = splitCommand[1].Split(",");
        if (splitData.Length < 3) return;

        int x, y;
        Directions.directions faceDirection;
        if (!Int32.TryParse(splitData[0], out x)) return;
        if (!Int32.TryParse(splitData[1], out y)) return;
        if (!Enum.TryParse<Directions.directions>(splitData[2],out faceDirection)) return;

        if (x < minX || x > maxX || y < minY || y > maxY) return;

        //if there is a wall we remove it
        if (BoardChecker.CoordinateOcupied(x, y, this))
            objectsOnTheBoard.Remove(objectsOnTheBoard.Where(obj => obj.positionX == x && obj.positionY == y).First());

        if (objectsOnTheBoard.Where(x => x.GetType().Name == "ClassRobot").Count() > 0)
        {
            Robot robot = (Robot)(objectsOnTheBoard.Where(x => x.GetType().Name == "ClassRobot").First());
            robot.positionX = x;
            robot.positionY = y;
            robot.faceDirection = faceDirection;
        }
        else
        {
            objectsOnTheBoard.Add(new Robot(splitData[2], x, y));
        }
    }

    public void placeWall(string command)
    {
        string[] splitCommand = command.Split(' ');
        if (splitCommand.Length < 2) return;

        string[] splitData = splitCommand[1].Split(",");
        if (splitData.Length < 2) return;

        int x, y;
        if (!Int32.TryParse(splitData[0], out x)) return;
        if (!Int32.TryParse(splitData[1], out y)) return;

        if (x < minX || x > maxX || y < minY || y > maxY) return;

        if (BoardChecker.CoordinateOcupied(x, y,this)) return;

        objectsOnTheBoard.Add(new Wall(x, y));
    }

}
