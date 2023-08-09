Console.Write("Введите первое число:  ");
int num_1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число:  ");
int num_2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число:  ");
int num_3 = int.Parse(Console.ReadLine()!);
int MaxNum = num_1;


if (num_1 < num_2)
{
    MaxNum = num_2;
}
if(MaxNum <= num_3)
{
    MaxNum = num_3;
}
Console.Write($"Максимальное число = {MaxNum}");