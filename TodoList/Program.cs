Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?");
Console.WriteLine("Press 'S' to see all TODOs ");
Console.WriteLine("Press 'A' to add a TODOs ");
Console.WriteLine("Press 'R' to remove a TODOs ");
Console.WriteLine("Press 'E' to exit");

//string userChoice = Console.ReadLine();
string userInput = Console.ReadLine();
int number = int.Parse(userInput);
System.Console.WriteLine(number);

Console.ReadKey();