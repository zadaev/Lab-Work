
bool examinationStop = true;
do
{
    Console.WriteLine("Ввести целое число не более чем из 10 разрядов");
    // Принимаем число не более чем из 10 разрядов!
    string? numbers = Console.ReadLine();

    Console.WriteLine("Ввести одно целое число");
    // Принимаем одно целое число!
    string? number = Console.ReadLine();

    if (string.IsNullOrEmpty(numbers) || string.IsNullOrEmpty(numbers)
        || string.IsNullOrWhiteSpace(numbers) || string.IsNullOrWhiteSpace(number)
        || numbers.Length >= 11 || number.Length >= 2
        || !Int32.TryParse(numbers, out int a) || !Int32.TryParse(number, out int b))
        Console.WriteLine("Ошибка!");
    else if (numbers.Contains(number))
    {
        Console.WriteLine("Цифра входит в число");
        examinationStop = false;
    }
}
while (examinationStop);



