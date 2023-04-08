Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
for (int i = 2; i <= N; i += 2)
{
    if (i < N - 1)
        Console.Write($"{i}, ");
    else
        Console.Write($"{i}.");
}