namespace RobotGame;

class MainClass
{
    static void Main(string[] args)
    {
        //Creation of the board
        GameBoard boardGame = new(1, 1, 5, 5);
        //Creation of the input handler
        InputHandler inputHandler = new InputHandler();


        while (true)
        {
            string? command = Console.ReadLine();
            if (command != null)
                inputHandler.handleCommandsForGame(command);
        }
    }
}