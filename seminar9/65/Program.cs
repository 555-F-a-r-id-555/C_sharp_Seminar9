// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5-> "1, 2, 3, 4, 5"
// M = 4; N = 8-> "4, 6, 7, 8"

uint ReadNumber(string messageToUser)
{
    Console.Write(messageToUser);
    uint value = Convert.ToUInt16(Console.ReadLine());
    return value;
}

string LineNumber(uint stop, uint start)
{

    if (start >= stop)
    {
        string line = LineNumber(stop, start - 1) + " " + start;
        return line;
    }
    return "";
}

void PrintNumber()
{
    uint stop = ReadNumber("Введите M: ");
    uint start = ReadNumber("Введите N: ");
    Console.WriteLine($"M = {stop}; N = {start} -> {LineNumber(stop, start)}");
}

PrintNumber();