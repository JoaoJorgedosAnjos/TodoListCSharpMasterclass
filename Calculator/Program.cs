Console.WriteLine("Hello!");
int firstNumber = Services.GetValidNumber("Input the first number:"), secondNumber = Services.GetValidNumber("Input the second number:");

System.Console.WriteLine("What do you want to do?");
Console.WriteLine("Press 'A' to add numbers  ");
Console.WriteLine("Press 'S' to subtract numbers ");
Console.WriteLine("Press 'M' to multiply numbers");
Console.WriteLine("Press 'D' to divide numbers");

string letterPressed = Console.ReadLine().ToLower();
Services.Calculate(firstNumber,secondNumber,letterPressed);

Services.exitApp();
