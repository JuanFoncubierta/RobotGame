namespace RobotGameTests;

internal class TestsPlaceRobot
{
    [Test]
    public void TestEmptyString()
    {
        RobotGame.GameBoard board = new(1, 1, 5, 5);
        board.placeRobot("");
        Assert.True(board.ObjectsOnTheBoard.Count() == 0);
    }

    [Test]
    public void TestNoDataForRobot()
    {
        RobotGame.GameBoard board = new(1, 1, 5, 5);
        board.placeRobot("place_robot");
        Assert.True(board.ObjectsOnTheBoard.Count() == 0);
    }

    [Test]
    public void TestOutOfBoardSuperior()
    {
        RobotGame.GameBoard board = new(1, 1, 5, 5);
        board.placeRobot("place_robot 6,6,NORTH");
        Assert.True(board.ObjectsOnTheBoard.Count() == 0);
    }

    [Test]
    public void TestOutOfBoardInferior()
    {
        RobotGame.GameBoard board = new(1, 1, 5, 5);
        board.placeRobot("place_robot 0,0,SOUTH");
        Assert.True(board.ObjectsOnTheBoard.Count() == 0);
    }

    [Test]
    public void TestWithWrongFacing()
    {
        RobotGame.GameBoard board = new(1, 1, 5, 5);
        board.placeRobot("place_robot 1,1,A");
        Assert.True(board.ObjectsOnTheBoard.Count() == 0);
    }

    [Test]
    public void TestCorrectCommand()
    {
        RobotGame.GameBoard board = new(1, 1, 5, 5);
        board.placeRobot("place_robot 1,1,NORTH");
        Robot robot = (Robot)board.ObjectsOnTheBoard.First();
        Assert.True(robot.positionX == 1 && robot.positionY == 1 && robot.faceDirection == Directions.directions.NORTH);
    }

    [Test]
    public void Test1()
    {
        RobotGame.GameBoard board = new(1, 1, 5, 5);
        board.placeRobot("place_robot 5,3,EAST");
        Robot robot = (Robot)board.ObjectsOnTheBoard.First();
        Assert.True(robot.positionX == 5 && robot.positionY == 3 && robot.faceDirection == Directions.directions.EAST);
    }
}
