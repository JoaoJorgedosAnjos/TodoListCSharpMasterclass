string userChoice;
HashSet<string> validChoices = new HashSet<string> { "s", "a", "r", "e" };
List<string> todoList = new();

Console.WriteLine("Hello!");
ShowTodoOption();

void ShowTodoOption()
{
    do
    {
        Console.WriteLine("");
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("Press 'S' to see all TODOs ");
        Console.WriteLine("Press 'A' to add a TODOs ");
        Console.WriteLine("Press 'R' to remove a TODOs ");
        Console.WriteLine("Press 'E' to exit");

        userChoice = Console.ReadLine().ToLower();
        switch (userChoice)
        {
            case "s":
                SeeTodoList(todoList);
                ShowTodoOption();
                break;
            case "a":
                AddTodoItem();
                break;
            case "r":
                RemoveTodoItem(todoList);
                break;
            case "e":
                Console.WriteLine("Selected option:Exit");
                break;
            default:
                Console.WriteLine("Selected option:Invalid choice");
                break;
        }
    } while (!validChoices.Contains(userChoice));
}

void AddTodoItem()
{
    string userTodoText;
    bool uniqueOrNot = true;
    do
    {
        Console.WriteLine("Enter the TODO description:");
        userTodoText = Console.ReadLine();
        if (userTodoText == "")
        {
            Console.WriteLine("The description cannot be empty");
        }
        else if (todoList.Contains(userTodoText))
        {
            Console.WriteLine("The description must be unique");
            uniqueOrNot = false;
        }
        else
        {
            Console.WriteLine($"TODO successfully added:{userTodoText}");
            todoList.Add(userTodoText);
            ShowTodoOption();
            uniqueOrNot = true;
        }
    } while (!uniqueOrNot);
}
void RemoveTodoItem(List<string> list)
{
    if (list.Count == 0)
    {
        Console.WriteLine("No TODOs have been added yet.");
        return;
    }
    Console.WriteLine("Select the index of the TODO you want to remove");
    SeeTodoList(todoList);

    bool isParsingSuccessful, isValid = false;
    while (!isValid)
    {
        string userInput = Console.ReadLine();
        isParsingSuccessful = int.TryParse(userInput, out int number);
        if (isParsingSuccessful && number <= list.Count && number > 0)
        {
            var indexOfTodo = number - 1;
            string listValue = todoList[indexOfTodo];
            Console.WriteLine($"TODO removed: {listValue}");
            todoList.RemoveAt(indexOfTodo);
            ShowTodoOption();
            isValid = true;
        }
        else if (number > list.Count || number < 0)
        {
            Console.WriteLine("The given index is not valid");
        }
        else if (!isParsingSuccessful)
        {
            Console.WriteLine("Selected index cannot be empty\nSelect the index of the TODO you want to remove");
        }
    }
}

void SeeTodoList(List<string> list)
{
    int count = 1;
    if (list.Count == 0)
    {
        Console.WriteLine("No TODOs have been added yet.");
    }
    foreach (var word in list)
    {
        Console.WriteLine($"{count}. {word}");
        count++;
    }
}