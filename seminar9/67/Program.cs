// Задача 67: Напишите программу, 
// которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


int ReadNumber(string messageToUser)
{
    Console.Write(messageToUser);
    int value = Convert.ToUInt16(Console.ReadLine());
    return value;
}

int SumDigits(int number)
{
    if (number == 0) return 0;
    return number % 10 + SumDigits(number / 10);
}


void PrintNumber()
{
    int a = ReadNumber("Введите число: ");
    Console.WriteLine($"{a} -> {SumDigits(a)}");
}


PrintNumber();
