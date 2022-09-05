Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
Console.WriteLine("Чётные числа от 1 до " + n);
while (i <= n)
{
    if (i % 2 == 0)
    {
        Console.Write(i + ", ");
    }
    i++;
}

if (i % 2 == 1)
{
    Console.WriteLine("Нет чётных чисел!");
}