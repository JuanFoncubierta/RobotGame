namespace RobotGame;

class MainClass
{
    static void Main(string[] args)
    {
        //Creation of the board
        GameBoard boardGame = new(1, 1, 5, 5);

        Console.WriteLine("This game is about a robot moving in a 5x5 board, there are walls that this robot can't walk through");
        Console.WriteLine("You can quit the game typing \"quit\" and restart the game by typing \"reset\"");
        Console.WriteLine("The different commands for this game can be found in the read me with an example of how to play it \n");

        while (true)
        {
            Console.WriteLine("Write an action:");
            string? command = Console.ReadLine();
            if (command != null)
                InputHandler.handleCommandsForGame(command,boardGame);
        }
    }
}