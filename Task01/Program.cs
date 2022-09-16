Console.Write("ведите первое число   ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("ведите  число, которе нужно проверить  ");
int number1 = Convert.ToInt32(Console.ReadLine());

// bool b = number == square;
if(number1 == number * number)
{
Console.WriteLine($"да, число {number} является квадратом числа {number1}");
}
else
{
Console.WriteLine($"нет число {number} не является квадратом числа {number1}");
}