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
        canBeOverwritten = false;
    }

    public string move(GameBoard boardData)
    {
        Tuple<int, int> newCoordinates = calculateNewCoordinates(boardData);
        if (BoardChecker.CoordinateOcupied(newCoordinates.Item1,newCoordinates.Item2,boardData)) return "There is something blocking the robot";
        positionX = newCoordinates.Item1;
        positionY = newCoordinates.Item2;
        return "Robot moves";
    }

    public string left()
    {
        faceDirection = Directions.Left(faceDirection);
        return "Robot turns left";
    }

    public string right()
    {
        faceDirection = Directions.Right(faceDirection);
        return "Robot turns right";
    }

    private Tuple<int, int> calculateNewCoordinates(GameBoard boardData)
    {
        if (faceDirection == Directions.directions.NORTH)
        {
            int newYPosition = positionY + 1;
            if (newYPosition > boardData.maxY)
                newYPosition = newYPosition - boardData.maxY;
            return Tuple.Create(positionX, newYPosition);
        }

        if (faceDirection == Directions.directions.SOUTH)
        {
            int newYPosition = positionY - 1;
            if (newYPosition < boardData.minY)
                newYPosition = newYPosition + boardData.maxY;
            return Tuple.Create(positionX, newYPosition);
        }

        if (faceDirection == Directions.directions.EAST)
        {
            int newXPosition = positionX + 1;
            if (newXPosition > boardData.maxX)
                newXPosition = newXPosition - boardData.maxX;
            return Tuple.Create(newXPosition, positionY);
        }

        if (faceDirection == Directions.directions.WEST)
        {
            int newXPosition = positionX - 1;
            if (newXPosition < boardData.minX)
                newXPosition = newXPosition + boardData.maxX;
            return Tuple.Create(newXPosition, positionY);
        }
        return Tuple.Create(positionX, positionY);
    }
}
