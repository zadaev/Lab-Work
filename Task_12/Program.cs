int a, b, c;

Console.WriteLine("Введите a");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите b");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите c");
c = Convert.ToInt32(Console.ReadLine());

if (a < b + c && b < a + c && c < a + b)
    Console.WriteLine("Треугольник существует.");
else
    Console.WriteLine("Треугольник не существует.");