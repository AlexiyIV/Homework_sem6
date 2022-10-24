int[] InputArray(string msg)
{
    Console.WriteLine(msg);
    int[] arr = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    return arr;
}

void Output(int[] arr)
{ 
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length-1] + "]");
}

int CountPositiveNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    if (arr[i] > 0) count ++;
    return count;
}

int[] Arr = InputArray("Введите элементы массива");
int Count = CountPositiveNumber(Arr);
Output(Arr);
Console.WriteLine("Количество положительных элементов в массиве " + Count);