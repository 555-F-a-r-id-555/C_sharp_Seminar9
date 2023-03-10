// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

uint ReadNumber(string messageToUser)
{
    Console.Write(messageToUser);
    uint value = Convert.ToUInt16(Console.ReadLine());
    return value;
}

uint SumNumber(uint stop, uint start)
{
    if (start >= stop)
    {
        uint sum = start + SumNumber(stop, start - 1);
        return sum;
    }
    return 0;
}

void PrintNumber()
{
    uint stop = ReadNumber("Введите M: ");
    uint start = ReadNumber("Введите N: ");
    Console.WriteLine($"M = {stop}; N = {start} -> {SumNumber(stop, start)}");
}

PrintNumber();