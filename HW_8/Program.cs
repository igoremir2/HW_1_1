

Console.Write("Введите число  ");
int number = int.Parse(Console.ReadLine())!;
int start = 2;
while(start <= number)
{
    Console.Write(start);
    if(start != number)
    {
        if (start%2<=0)
        {
            Console.Write(", ");
            start++;   
        }
        else if(start%2>0)
        {

        }    
    }
    start++;
}