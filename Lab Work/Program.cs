
// Принимаем число (типа ab)
string? ab_number = Console.ReadLine();

if (string.IsNullOrEmpty(ab_number)
    || string.IsNullOrWhiteSpace(ab_number)
    || ab_number.Length >= 3)
    Console.WriteLine("Введите число типа ab!");

else if (Int32.TryParse(ab_number, out int ab_numbers))
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 1; j++)
        {
            Console.Write(ab_number[i]);
            Console.Write(ab_number[i]);
        }

    }