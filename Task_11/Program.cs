
int[,] numbers = {
    { 11, 20, 13, 47, 35 },{ 45, 32, 28, 26, 10} };


int rows = numbers.GetUpperBound(0) + 1;    // количество строк
int columns = numbers.Length / rows;        // количество столбцов

int num = int.MinValue;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {

        if (numbers[i, j] % 2 == 0)
        {
            numbers[i, j] = 0;
        }
        else
        {
            numbers[i, j] = 1;
        }

        Console.Write($"{numbers[i, j]} \t");
    }
    Console.WriteLine();
}