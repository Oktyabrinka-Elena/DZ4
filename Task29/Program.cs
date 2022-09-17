// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GetBinaryArray (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива {i} - ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}
Console.Write("Введите количество элементов массива - ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] resultArray = GetBinaryArray(sizeArray);
Console.WriteLine($"Результат: [{String.Join(";" , resultArray)}]");
