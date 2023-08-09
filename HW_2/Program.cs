Console.Write("Введите первое число:  ");
int num_1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число:  ");
int num_2 = int.Parse(Console.ReadLine()!);
if (num_1 >= num_2)
{
    Console.Write($"Max={num_1}");
}
else 
{
    Console.Write($"Max={num_2}");
}