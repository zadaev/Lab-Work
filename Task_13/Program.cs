
double l, R, D, S;

Console.WriteLine("Введите длину\n");
l = Convert.ToDouble(Console.ReadLine());

R = l / (2 * 3.14);
D = R * R;
S = (D * D) / 2;

Console.WriteLine($"Площадь квадрата равна {Convert.ToString(S)}");
Console.ReadKey();