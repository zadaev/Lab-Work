
int[] numbers = new int[] { 20, 12, 13, 4, 5, 6, 28, 8, 9, 3, 11 };

for (int i = 0; i < numbers.Length; i++)
    for (int j = 0; j < numbers.Length - i - 1; j++)
    {
        if (numbers[j] < numbers[j + 1])
        {
            int k = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = k;
        }
    }

for(int i = 0; i < numbers.Length;i++)
{
    Console.WriteLine($"Элемент [{i}] = {numbers[i]}");
}