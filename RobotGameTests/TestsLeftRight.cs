namespace RobotGameTests;

internal class TestsLeftRight
{
    [Test]
    public void TestLeftWhenRobotWasNorth()
    {
        RobotGame.GameBoard board = new(1, 1, 5, 5);
        InputHandler.handleCommandsForGame("place_robot 1,1,NORTH",board);
        Robot robot = (Robot)board.objectsOnTheBoard.Where(x => x.boardObjectType == BoardObjectType.Robot).First();
        robot.left();
        Assert.True(robot.faceDirection == Directions.directions.WEST);
    }

    [Test]
    public void TestLeftWhenRobotWasEast()
    {
        RobotGame.GameBoard board = new(1, 1, 5, 5);
        InputHandler.handleCommandsForGame("place_robot 1,1,EAST", board);
        Robot robot = (Robot)board.objectsOnTheBoard.Where(x => x.boardObjectType == BoardObjectType.Robot).First();
        robot.left();
        Assert.True(robot.faceDirection == Directions.directions.NORTH);
    }

    [Test]
    public void TestRightWhenRobotWasNort()
    {
        RobotGame.GameBoard board = new(1, 1, 5, 5);
        InputHandler.handleCommandsForGame("place_robot 1,1,NORTH", board);
        Robot robot = (Robot)board.objectsOnTheBoard.Where(x => x.boardObjectType == BoardObjectType.Robot).First();
        robot.right();
        Assert.True(robot.faceDirection == Directions.directions.EAST);
    }

    [Test]
    public void TestRightWhenRobotWasSouth()
    {
        RobotGame.GameBoard board = new(1, 1, 5, 5);
        InputHandler.handleCommandsForGame("place_robot 1,1,SOUTH", board);
        Robot robot = (Robot)board.objectsOnTheBoard.Where(x => x.boardObjectType == BoardObjectType.Robot).First();
        robot.right();
        Assert.True(robot.faceDirection == Directions.directions.WEST);
    }
}
