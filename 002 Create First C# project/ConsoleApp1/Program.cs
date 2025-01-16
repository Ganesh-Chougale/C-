Console.WriteLine("What is your Name?");
var name = Console.ReadLine();
var curDate = DateTime.Now;
Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {curDate:d}");
Console.WriteLine($"{Environment.NewLine}Press any key to exit....");
Console.ReadKey(true);