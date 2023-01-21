
int[] numbers = new int[] { 13, 2, 13, 4, 5, 6, 7, 8, 9, 3, 11 };
bool dn = false;


for (int i = 0; i < numbers.Length; i++)
{
    if (i > 0 && numbers[i - 1] <= numbers[i])
        dn = false;
}

if (dn)
    Console.WriteLine("УБЫВАЕТ\n");
else
    Console.WriteLine("Упорядочен по неубыванию\n");

for (int i = 0; i < numbers.Length; i++)
{ Console.WriteLine(numbers[i]); }
