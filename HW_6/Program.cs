Console.Write("Введите число:  ");
int num = int.Parse(Console.ReadLine()!);

if (num%2 > 0)
{
    Console.Write($"Число {num} нечетное");
}
else 
{
    Console.Write($"Число {num} четное");
}