using SharpExercises.SimulationExcersises;
using SharpExercises.Utilities;

//Start Main

//Stopwatch call
var stopwatch = new Stopwatch();

if (!stopwatch.IsRunning)
{
    stopwatch.Start();
}
await Task.Delay(2000);

stopwatch.Stop();

Console.WriteLine($"Stopwatch: ");
Console.WriteLine($"Duration {stopwatch.GetDuration()}\n");


//Post call

var post = new Post("Post Hello World!", "This is my first post happy the let you vote for me");

for(int i = 0; i < 13; i++)
{
    post.UpVote();
}

for (int i = 0; i < 3; i++)
{
    post.DownVote();
}

Console.WriteLine($"StackOverFlow Post Simulation: ");
post.DisplayPost();

//End Main
