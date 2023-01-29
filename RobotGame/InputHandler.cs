namespace RobotGame;

public static class InputHandler
{
    public static void handleCommandsForGame(string command)
    {
        if (command.ToLower().StartsWith("place_robot"))
            placeRobot(command);

        if (command.ToLower().StartsWith("place_wall"))
            placeWall(command);

        //if is not one of the above we need the robot to exist
        if (ObjectsOnTheBoard.Where(x => x.GetType().Name == "ClassRobot").Count() < 1) return;

        if (command.ToLower() == "report")
            ((ClassRobot)(ObjectsOnTheBoard.Where(x => x.GetType().Name == "ClassRobot").First())).report();

        if (command.ToLower() == "move")
            ((ClassRobot)(ObjectsOnTheBoard.Where(x => x.GetType().Name == "ClassRobot").First())).move(this);

        if (command.ToLower() == "left")
            ((ClassRobot)(ObjectsOnTheBoard.Where(x => x.GetType().Name == "ClassRobot").First())).left();

        if (command.ToLower() == "right")
            ((ClassRobot)(ObjectsOnTheBoard.Where(x => x.GetType().Name == "ClassRobot").First())).right();
    }
}
