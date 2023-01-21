int InputInt(string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

bool Validate(int number)
{
    if (number > 99 && number < 1000)
    {
        return true;
    }
    System.Console.WriteLine("Число не трехзначное.");
    return false;
}

int number = InputInt("Введите трехзначное число");

if (Validate(number))
{
    int lastRank = ((number / 10) % 10);
    System.Console.WriteLine($"Вторая цифра числа {number} равна {lastRank} ");
}