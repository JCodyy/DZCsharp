// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите 2 целых числа ");
int num1 = Convert.ToInt32( Console.ReadLine() );
int num2 = Convert.ToInt32( Console.ReadLine() );

if (num1 > num2)
{
    Console.WriteLine("Максимальное число = " + num1);
    Console.WriteLine("Минимальное число = " + num2);
}
else
{
    Console.WriteLine("Максимальное число = " + num2);
    Console.WriteLine("Минимальное число = " + num1);
}
