
int[] numbers = new int[] { 20, 12, 13, 4, 5, 6, 28, 8, 9, 3, 11 };

for (int i = 0; i < numbers.Length; i++)
{
    int minIndex = i;

    for (int j = i; j < numbers.Length; j++)
    {
        if (numbers[minIndex] < numbers[j])
        {
           minIndex= j;
        }
    }
    int k = numbers[i];
    numbers[i] = numbers[minIndex]; 
    numbers[minIndex] = k;

}

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Элемент [{i}] = {numbers[i]}");
}