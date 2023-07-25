string[] array1 = { "Hello", "2", "world", ":-)" };
string[] array2 = { "1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };

string[] arrayWorking = new string[array1.Length];

void ArrayWithValuesOfNoMoreThanThreeCharacters(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length < 4)
        {
            array2[count] = array1[i];
            count++;
        }
    }

    PrintArray(array2);
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

ArrayWithValuesOfNoMoreThanThreeCharacters(array1, arrayWorking);
