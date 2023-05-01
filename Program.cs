using System;

namespace Interfaces_Sawyer_Moira
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calls the Describe and PlayGame methouds and prints it to the console.
            Game myGame = new Game("E", "FPS", "ZombCube");
            Console.WriteLine(myGame.Describe());
            myGame.PlayGame();

            //Calls the Describe and PlayMovie methods on the movie object and prints it to the console.
            Movie myMovie = new Movie("PG", "Adventure/Comedy", "Sonic the Hedgehog 2");
            Console.WriteLine(myMovie.Describe());
            myMovie.PlayMovie();
        }
    }
}
