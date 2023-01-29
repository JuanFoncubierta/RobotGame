namespace RobotGame;

class MainClass
{
    static void Main(string[] args)
    {
        //Creation of the board
        GameBoard boardGame = new(1, 1, 5, 5);

        while (true)
        {
            string? command = Console.ReadLine();
            if (command != null)
                InputHandler.handleCommandsForGame(command);
        }
    }
}