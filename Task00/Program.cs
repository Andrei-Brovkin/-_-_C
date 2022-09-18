// 0. Демонстрация решения 
// Напишите программу, которая 
// 1. на вход приниммает  число 
// 2. Выдает его квадрат
// 3. Вывод результата


Console.Write("ведите целое число  ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number *number;
Console.WriteLine($"Квадрат числа {number} ={square}");
