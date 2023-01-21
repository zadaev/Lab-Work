
int[,] numbers = {
    { 11, 20, 13, 47, 35, 45, 32, 28, 26, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 },
    { 16, 62, 35, 45, 52, 36, 22, 23, 65, 23, 87, 65, 34, 76, 34, 29, 63, 62, 84, 26, 42, 97, 99, 86, 65 } };

int max = int.MinValue;
foreach (var i in numbers)
{
    if (i > max)
    {

        max = i;
    }
}
int rows_element = 0, columns_element = 0;


int rows = numbers.GetUpperBound(0) + 1;    // количество строк
int columns = numbers.Length / rows;        // количество столбцов


for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        if (numbers[i, j] == max)
        {
            columns_element = j;
            rows_element = i;
        }
        Console.Write($"{numbers[i, j]} \t");
    }
    Console.WriteLine();
}

Console.WriteLine($"\n\n\nномер строки  = {rows_element}\t номер столбца = {columns_element}\t максимальный элемент = {max}");
