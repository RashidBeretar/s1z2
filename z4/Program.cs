Console.WriteLine("Введите числа");
int a1 = int.Parse(Console.ReadLine());
int a2 = int.Parse(Console.ReadLine());
int a3 = int.Parse(Console.ReadLine());
Console.WriteLine("Максимальное число " + Math.Max(a1, Math.Max(a2, a3)));