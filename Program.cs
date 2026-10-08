Main();

void Main()
{
    PrintMenu();

    int option = InputOption();

    string message = GetMessage(option);

    Console.WriteLine(message);
}
void PrintMenu()
{
    Console.WriteLine("Please enter a valid option from below:");
    Console.WriteLine("1. Hello in French");
    Console.WriteLine("2. Hello in Spanish");
    Console.WriteLine("3. Hello in German");
    Console.WriteLine("4. Hello in Italian");
    Console.WriteLine("5. Exit Application");
}

int InputOption()
{
    try
    {
        int option = Convert.ToInt32(Console.ReadLine());
        return option;
    }
    catch
    {
        Console.WriteLine("Please enter a valid number");
        return 0;

    }
}

string GetMessage(int language)

{
    switch (language)
    {
        case 1:
            return "Bonjour!";

        case 2:
            return "Hola!";

        case 3:
            return "Hallo!";

        case 4:
            return "Ciao!";

        case 5:
            return "Goodbye!";

        default:
            return "Invalid option";
    }
}