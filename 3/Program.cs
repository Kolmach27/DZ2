int InputInt(string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int numberDay = InputInt ("Введите день недели:");

if (numberDay == 7 || numberDay == 6)
{
    Console.WriteLine ("Выходной.");
}
    else
{
    Console.WriteLine ("Рабочий день.");
}