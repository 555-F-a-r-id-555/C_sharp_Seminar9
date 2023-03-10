int x = 85;
string binary = "";
void ConvertToBin(int x)
{

    if (x > 0)
    {
        ConvertToBin(x / 2);
        binary += x % 2;
    }
}

ConvertToBin(x);
Console.WriteLine(binary);
Console.WriteLine("--------------------------");


int number = 44;
PrintNumber(number);

void PrintNumber(int n)
{
    if (n == 0) return;
    PrintNumber(n / 2);
    Console.Write($"{n % 2}");
}
Console.WriteLine($"\n--------------------------");


void ForPlus(int end, int step, int i = 0)
{
    if (i < end) ForPlus(end - step, step, i);
    Console.Write($"{end} ");
}
ForPlus(10, 2);
Console.WriteLine("\n" + "--------------------------");

void ForMinus(int end, int step, int i = 0)
{
    if (i < end) ForMinus(end, step, i + step);
    Console.Write($"{i} ");
}
ForMinus(10, 2);
Console.WriteLine("\n" + "--------------------------");