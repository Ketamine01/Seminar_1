Console.Write("Введите целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if(numberB > max)
{
    max = numberB;
}
if (numberC > max)
{
    max = numberC;
}
Console.Write("Максимальное число: ");
Console.WriteLine(max);