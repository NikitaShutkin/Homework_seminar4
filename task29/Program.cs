// Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с 
// клавиатуры и далее выводит массив на экран в одну строку.

Console.Clear();
void setValue(int[] mas, int n)
 {
     Console.WriteLine("Введите число: " + (n+1));
     mas[n] = Convert.ToInt32(Console.ReadLine());
 }
 int[] mas = new int[8];
 for (int n = 0; n < mas.Length; n++) 
    {
     setValue(mas, n);
    }
 string output = $"{mas[0]}";
 for (int n = 1; n < mas.Length - 1; n++)
  {
     output += $", {mas[n]}";
  }
 output += $", {mas[7]}]";
 Console.WriteLine("Ваш массив:[" + output);