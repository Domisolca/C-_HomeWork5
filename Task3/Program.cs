void FillArrayRundomDNumbers(double[] array)
{
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.Next(-1000, 1000) * 0.01, 2);
    }
}

void WriteDArray(double[] array)
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

double DiffBetweenMaxMinArrEl(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }

        if (array[i] < min)
        {
            min = array[i];
        }
    }

    return max - min;
}

int size = ReadInt("Введтие размер массива: ");
double[] numbers = new double[size];

FillArrayRundomDNumbers(numbers);
WriteDArray(numbers);
Console.WriteLine(Math.Round(DiffBetweenMaxMinArrEl(numbers), 2));