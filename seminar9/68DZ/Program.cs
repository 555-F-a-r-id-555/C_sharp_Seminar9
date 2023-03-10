// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9


uint ReadNumber(string messageToUser)
{
    Console.Write(messageToUser);
    uint value = Convert.ToUInt32(Console.ReadLine());
    return value;
}

uint AckermannFunction(uint m, uint n)
{
    if (m == 0) return n + 1; //A(m,n) = n + 1, m == 0
    else if (m > 0 && n == 0) // A(m,n) = A(m-1,1), m > 0,n == 0
    {
        uint sum = AckermannFunction(m - 1, 1);
        return sum;
    }
    else if (m > 0 && n > 0)  //A(m,n) =  A(m-1,A(m,n-1)), m > 0,n > 0
    {
        uint sum = AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        return sum;
    }
    return 0;
}

void PrintNumber()
{
    uint m = ReadNumber("Введите m: ");
    uint n = ReadNumber("Введите n: ");
    Console.WriteLine($"m = {m}; n = {n} -> A(m,n) = {AckermannFunction(m, n)}");
}

PrintNumber();