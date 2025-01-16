`CTRL + SHIFT + P` => `.NET new project` => `Console App`  => give the name to app  
##### Preview:  
![](../z_images/001.png)  

`Program.cs: `  
```C#
Console.WriteLine("What is your Name?");
var name = Console.ReadLine();
var curDate = DateTime.Now;
Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {curDate:d}");
Console.WriteLine($"{Environment.NewLine}Press any key to exit....");
Console.ReadKey(true);
```  
```bash
dotnet run
```  
##### Preview:  
![](../z_images/002.png)  