using System.IO.Pipes;

namespace RobotGame;

public static class InputHandler
{
    public static string handleCommandsForGame(string command,GameBoard board)
    {
        string answer = "";
        if (command.ToLower().StartsWith("place_robot"))
            answer = board.placeRobot(command);

        if (command.ToLower().StartsWith("place_wall"))
            answer = board.placeWall(command);

        //if is not one of the above we need the robot to exist
        if (!BoardChecker.IsThereARobot(board)) return "You need a robot first, try placing one";

        Robot robot = (Robot)(board.objectsOnTheBoard.Where(x => x.boardObjectType == BoardObjectType.Robot).First());

        if (command.ToLower() == "report")
            answer = report(board);

        if (command.ToLower() == "reset")
            answer = board.ResetGame();

        if (command.ToLower() == "quit")
            System.Environment.Exit(1);

        if (command.ToLower() == "move")
            answer = robot.move(board);

        if (command.ToLower() == "left")
            answer = robot.left();

        if (command.ToLower() == "right")
            answer = robot.right();

        return answer;
    }

    

    public static string report(GameBoard board)
    {
        Robot robot = (Robot)board.objectsOnTheBoard.Where(x => x.boardObjectType == BoardObjectType.Robot).First();
        return robot.positionX + "," + robot.positionY + "," + robot.faceDirection.ToString();
    }
}
