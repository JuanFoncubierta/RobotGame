namespace RobotGameTests;

internal class TestsPlaceWall
{
    [Test]
    public void TestEmptyString()
    {
        RobotGame.GameBoard board = new(1, 1, 5, 5);
        board.placeWall("");
        Assert.True(board.objectsOnTheBoard.Count() == 0);
    }

    [Test]
    public void TestNoDataForWall()
    {
        RobotGame.GameBoard board = new(1, 1, 5, 5);
        board.placeWall("place wall");
        Assert.True(board.objectsOnTheBoard.Count() == 0);
    }

    [Test]
    public void TestOutOfBoardInferior()
    {
        RobotGame.GameBoard board = new(1, 1, 5, 5);
        board.placeWall("place wall 0,0");
        Assert.True(board.objectsOnTheBoard.Count() == 0);
    }

    [Test]
    public void TestOutOfBoardSuperior()
    {
        RobotGame.GameBoard board = new(1, 1, 5, 5);
        board.placeWall("place wall 6,3");
        Assert.True(board.objectsOnTheBoard.Count() == 0);
    }

    [Test]
    public void TestCreateCorrectWall()
    {
        RobotGame.GameBoard board = new(1, 1, 5, 5);
        board.placeWall("place_wall 1,1");
        Assert.True(board.objectsOnTheBoard.Where(x => x.boardObjectType == BoardObjectType.Wall).Any() && board.objectsOnTheBoard.First().positionX == 1 && board.ObjectsOnTheBoard.First().positionY == 1);
    }

    [Test]
    public void TestTryPutAWallOverARobot()
    {
        RobotGame.GameBoard board = new(1, 1, 5, 5);
        board.placeRobot("place_robot 1,1,NORTH");
        board.placeWall("place_wall 1,1");
        Assert.True(board.objectsOnTheBoard.Count() == 1 && board.objectsOnTheBoard.First().boardObjectType == BoardObjectType.Robot);
    }
}
