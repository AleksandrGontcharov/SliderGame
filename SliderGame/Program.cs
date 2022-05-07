using SliderGame.Game;


// Welcome Message


Console.WriteLine("Welcome to the SliderGame!");
Console.WriteLine();
Console.WriteLine("The exciting adventure for pressing buttons!");
Console.WriteLine("Choose between integers 1 through 4 and try to line up the buttons.");
Console.WriteLine();
Console.WriteLine("------------------------------------------------------------------");
Console.WriteLine("<<<<<<<<<<<<<<<<<LEVEL ONE>>>>>>>>>>>>>>>>>");
Console.WriteLine("------------------------------------------------------------------");

// Create Stage one
var slider1 = new Slider(5, 3, false);
var slider2 = new Slider(7, 4, true);
var slider3 = new Slider(3, 2, false);
var slider4 = new Slider(4, 3, true);



var listOfSliders = new List<Slider>()
                                                {
                                                    slider1, slider2, slider3, slider4,
                                                };


var game = new Stage(listOfSliders);

bool didYouWin = false;

while (!didYouWin)
{
    // print the current stage
    game.Print();

    // Ask user for input
    Console.Write("Next move: ");
    string userInput = Console.ReadLine();

    // execute stage.ExecuteTurn
    game.ExecuteTurn(Int32.Parse(userInput));

    // figure out if you won:
    didYouWin = game.IsWinning();

    // if yes -> go back to line 13
    // if no --> print the stage and congratulate the played for winning
}
// print the current stage
game.Print();


Console.WriteLine("Congratulations, you have solved the mystery of SliderGame!!!");
Console.ReadLine();
