// Задача 69: Напишите программу, 
// которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int ReadNumber(string messageToUser)
{
    Console.Write(messageToUser);
    int value = Convert.ToUInt16(Console.ReadLine());
    return value;
}

int PowAToB(int a, int b)
{
    if (b == 0) return 1;
    return a * PowAToB(a, b - 1);
}


void PrintNumber()
{
    int a = ReadNumber("Введите A: ");
    int b = ReadNumber("Введите B: ");
    Console.WriteLine($"A = {a}; B = {b} -> {PowAToB(a, b)}");
}

PrintNumber();