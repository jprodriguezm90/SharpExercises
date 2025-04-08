using SharpExercises.SimulationExcersises;
using SharpExercises.SimulationExcersises.Composition;
using SharpExercises.SimulationExcersises.Inheritance;
using SharpExercises.SimulationExcersises.Polymorphism.DBMS;
using SharpExercises.Utilities;
using SharpExercises.Utilities.Queues;
using System.Windows.Markup;

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



//Exercises 
#region Exercises 27 - C# Intermediate: Classes, Interfaces and OOP

var stack = new Stack();
stack.Push(1);
stack.Push(2);
stack.Push(3);
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());

#endregion

#region Exercises 32 - C# Intermediate: Classes, Interfaces and OOP

var dbCommand = new DbCommand(new SQLConnection("SQLConnectionString"), "Create Table Exercise");
dbCommand.Execute();

dbCommand = new DbCommand(new OracleConnection("OracleConnectionString"), "Create DATA2Table Exercise");
dbCommand.Execute();
#endregion


//End Main
