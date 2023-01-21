int InputInt(string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int numIn = InputInt ("Введите число:");

if (numIn / 100 == 0)
    {
    Console.WriteLine ("Третьей цифры нет");
    }
    else
    {
        while (numIn > 1000)
        {
            numIn = numIn / 10;
        }
        Console.WriteLine ($"Третья цифра: {numIn % 10}"); 
    }