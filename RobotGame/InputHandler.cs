namespace RobotGame;

public static class InputHandler
{
    public static void handleCommandsForGame(string command,GameBoard board)
    {
        if (command.ToLower().StartsWith("place_robot"))
            board.placeRobot(command);

        if (command.ToLower().StartsWith("place_wall"))
            board.placeWall(command);

        //if is not one of the above we need the robot to exist
        if (!BoardChecker.IsThereARobot(board)) return;

        if (command.ToLower() == "report")
            report(board);

        if (command.ToLower() == "move")
            ((Robot)(board.objectsOnTheBoard.Where(x => x.boardObjectType == BoardObjectType.Robot).First())).move(board);

        if (command.ToLower() == "left")
            ((Robot)(board.objectsOnTheBoard.Where(x => x.boardObjectType == BoardObjectType.Robot).First())).left();

        if (command.ToLower() == "right")
            ((Robot)(board.objectsOnTheBoard.Where(x => x.boardObjectType == BoardObjectType.Robot).First())).right();

        if (command.ToLower() == "reset")
            board.ResetGame();

        if (command.ToLower() == "quit")
            System.Environment.Exit(1);
    }

    

    public static void report(GameBoard board)
    {
        Robot robot = (Robot)board.objectsOnTheBoard.Where(x => x.boardObjectType == BoardObjectType.Robot).First();
        Console.WriteLine(robot.positionX + "," + robot.positionY + "," + robot.faceDirection.ToString());
    }
}
