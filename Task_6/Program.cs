

int[] arr = new int[] {
    11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
    21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

int k = 3, tmp, nextInd = 0;

Console.WriteLine(string.Join(" ", arr));

for (int i = 0; i < arr.Length - 1; ++i)
{
    nextInd += k;
    nextInd %= arr.Length;

    tmp = arr[nextInd];
    arr[nextInd] = arr[0];
    arr[0] = tmp;
}

Console.WriteLine(string.Join(" ", arr));
