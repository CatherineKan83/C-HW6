void PrintArray(int[]arr)
{
    Console.Write("[");
    for(int i=0; i<arr.GetLength(0); i++)
    {
        Console.Write($"{arr[i]}");
        if(i<arr.GetLength(0)-1)
        {
            Console.Write(",");
        }
    }
Console.WriteLine("]");
}
void FillArray(int[]arr)
{
    Console.WriteLine("Введите числа массива:");
    for(int i=0;i<arr.GetLength(0); i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
Console.WriteLine();
}
void Count(int[]arr)
{
    int count = 0;
    for(int i=0;i<arr.GetLength(0);i++)
    {
        if(arr[i]>0)
        {
            count ++;
        }
    }
    Console.WriteLine($"Количество положительных чисел в заданном массиве: {count} ");    
}
Console.Write("Введите размер массива: ");
int c = Convert.ToInt32(Console.ReadLine());
int[]array = new int[c];
FillArray(array);
PrintArray(array);
Count(array);
