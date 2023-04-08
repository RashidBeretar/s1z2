Console.WriteLine("Введите числа");
int a1 = int.Parse(Console.ReadLine());
int a2 = int.Parse(Console.ReadLine());
// Console.WriteLine(${max = Math.Max(a1, a2), min = Math.Min(a1, a2)}); - почему-то не работает
Console.WriteLine("max = " + Math.Max(a1, a2) + ", min = " + Math.Min(a1, a2));