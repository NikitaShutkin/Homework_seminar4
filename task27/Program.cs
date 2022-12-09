// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
// Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int s = summa(n);
Console.WriteLine($"Сумма всех цифр числа равна: {s}");

// функция
int summa(int n)
{
    int result = 0;
    while (n > 0)
    {
        int m = n % 10;
        result = result + m;
        n = n / 10;
    }
    Console.WriteLine(result);
    return result;
}
