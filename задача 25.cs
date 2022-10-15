// Напишите цикл который принимает на вход два числа (А и В) 
// и возводит число А в натуральное число В.

Console.WriteLine("Введите число A");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine()!);

int X = a;

for (int i = 1; i < b; i++)
{
X = X * a;
}
Console.WriteLine("A в степени B равно: " + X);