using SharpExercises.SimulationExcersises;
using SharpExercises.SimulationExcersises.Composition;
using SharpExercises.SimulationExcersises.Inheritance;
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


//Inheritance

var text = new Text();
text.Width = 100;
text.Copy();

//Composition

var dbMigrator = new DbMigrator(new Logger());
var logger = new Logger();
var installer = new Installer(logger);
await dbMigrator.MigrateAsync();
await installer.InstallAsync();


//End Main
