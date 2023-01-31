namespace RobotGameTests;

internal class TestsCommandHandler
{
    [Test]
    public void TestIncorrectCommand()
    {
        RobotGame.GameBoard board = new(1, 1, 5, 5);
        InputHandler.handleCommandsForGame("fallar",board);
        Assert.True(board.ObjectsOnTheBoard.Count() == 0);
    }

    [Test]
    public void TestEmptyCommand()
    {
        RobotGame.GameBoard board = new(1, 1, 5, 5);
        InputHandler.handleCommandsForGame("",board);
        Assert.True(board.ObjectsOnTheBoard.Count() == 0);
    }

    [Test]
    public void TestMoveWithNoRobots()
    {
        RobotGame.GameBoard board = new(1, 1, 5, 5);
        InputHandler.handleCommandsForGame("move",board);
        Assert.True(board.ObjectsOnTheBoard.Count() == 0);
    }

    [Test]
    public void TestLeftWithNoRobots()
    {
        RobotGame.GameBoard board = new(1, 1, 5, 5);
        InputHandler.handleCommandsForGame("left",board);
        Assert.True(board.ObjectsOnTheBoard.Count() == 0);
    }

    [Test]
    public void TestRightWithNoRobots()
    {
        RobotGame.GameBoard board = new(1, 1, 5, 5);
        InputHandler.handleCommandsForGame("right", board);
        Assert.True(board.ObjectsOnTheBoard.Count() == 0);
    }
}
