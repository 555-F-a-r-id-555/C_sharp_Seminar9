// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


uint ReadNumber()
{
    Console.WriteLine("Введите число");
    uint value = Convert.ToUInt16(Console.ReadLine());
    return value;
}

string LineNumber(uint n)
{
    if (n > 0)
    {
        string line = n + " " + LineNumber(n - 1);
        return line;
    }
    return "";
}

void PrintNumber()
{
    uint number = ReadNumber();
    Console.WriteLine($"{LineNumber(number)}");
}

PrintNumber();