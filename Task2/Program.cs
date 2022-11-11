void FillArrayRundomNumbers(int[] array, int min = 1, int max = 100)
{
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SummOfOddPosNumInArr(int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i+=2)
    {
        sum+=array[i];
    }

    return sum;
}

int size = ReadInt("Введтие размер массива: ");
int[] numbers = new int[size];

FillArrayRundomNumbers(numbers, -10, 10);
WriteArray(numbers);
Console.WriteLine(SummOfOddPosNumInArr(numbers));