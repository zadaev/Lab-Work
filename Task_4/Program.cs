
int[] num = new int[] {
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
    11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
    21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

int sum = 0;

for (int i = 0; i < num.Length; i++)
    sum += num[i];

int arithmeticmean = sum / 2;

Console.WriteLine(arithmeticmean);