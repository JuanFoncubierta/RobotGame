namespace RobotGameTests;

internal class TestsMove
{
    [Test]
    public void TestSimpleMove()
    {
        RobotGame.GameBoard board = new(1, 1, 5, 5);
        InputHandler.handleCommandsForGame("place_robot 1,1,NORTH",board);
        Robot robot = (Robot)board.ObjectsOnTheBoard.Where(x => x.boardObjectType == BoardObjectType.Robot).First();
        robot.move(board);
        Assert.True(robot.positionY == 2 && robot.positionX == 1);
    }

    [Test]
    public void TestWhenWallInFront()
    {
        RobotGame.GameBoard board = new(1, 1, 5, 5);
        InputHandler.handleCommandsForGame("place_robot 1,1,NORTH",board);
        InputHandler.handleCommandsForGame("place_wall 1,2",board);
        Robot robot = (Robot)board.ObjectsOnTheBoard.Where(x => x.boardObjectType == BoardObjectType.Robot).First();
        robot.move(board);
        Assert.True(robot.positionY == 1 && robot.positionX == 1);
    }

    [Test]
    public void TestWhenGettingOutOfTheBoardInYCoordinate()
    {
        RobotGame.GameBoard board = new(1, 1, 5, 5);
        InputHandler.handleCommandsForGame("place_robot 5,1,EAST", board);
        Robot robot = (Robot)board.ObjectsOnTheBoard.Where(x => x.boardObjectType == BoardObjectType.Robot).First();
        robot.move(board);
        Assert.True(robot.positionY == 1 && robot.positionX == 1);
    }

    [Test]
    public void TestWhenGettingOutOfTheBoardInXCoordinate()
    {
        RobotGame.GameBoard board = new(1, 1, 5, 5);
        InputHandler.handleCommandsForGame("place_robot 1,5,NORTH",board);
        Robot robot = (Robot)board.ObjectsOnTheBoard.Where(x => x.boardObjectType == BoardObjectType.Robot).First();
        robot.move(board);
        Assert.True(robot.positionY == 1 && robot.positionX == 1);
    }
}
