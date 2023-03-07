int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int MakeArray(int a, int b)
{
int result = 0;
    if (b < 2)
    {
        Console.Write("Второй цифры нет");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 2; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}