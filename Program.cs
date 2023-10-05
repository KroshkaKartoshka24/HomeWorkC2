// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine("Введите первое число (A): ");
double a = Convert.ToDouble(System.Console.ReadLine());

System.Console.WriteLine("Введите второе число (B): ");
double b = Convert.ToDouble(System.Console.ReadLine());

if (b > 0 && b%1 == 0)
{
    double c = Math.Pow(a, b);
    System.Console.WriteLine($"число {a} в степени {b} = {c}");
}
else 
{
    System.Console.WriteLine("Введенное Вами число В не является натуральным");
}