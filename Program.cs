// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// System.Console.WriteLine("Введите первое число (A): ");
// double a = Convert.ToDouble(System.Console.ReadLine());

// System.Console.WriteLine("Введите второе число (B): ");
// double b = Convert.ToDouble(System.Console.ReadLine());

// if (b > 0 && b%1 == 0)
// {
//     double c = Math.Pow(a, b);
//     System.Console.WriteLine($"число {a} в степени {b} = {c}");
// }
// else 
// {
//     System.Console.WriteLine("Введенное Вами число В не является натуральным");
// }

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Введите число: ");
string a = System.Console.ReadLine();
int b = 0;
if (Convert.ToDouble(a)%1 == 0)
{
    for (int i = 0; i < a.Length; i++)
    {
        b += Convert.ToInt32(a.Substring(i, 1));
    }
    System.Console.WriteLine($"Сумма всех цифр в числе = {b}");
}
else
{
    System.Console.WriteLine("Вы ввели не целое число");
}

