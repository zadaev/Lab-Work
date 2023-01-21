Console.WriteLine("Ввести предложение");
string words = Console.ReadLine();
if (string.IsNullOrEmpty(words))
    Console.WriteLine("Ошибка!");

int count = words!.Split(' ').Length; // количество слов

Console.WriteLine($"Количество слов: {count}");