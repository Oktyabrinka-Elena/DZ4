// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int[] IntToArray(int num) // метод преобразует число в массив
{
    string numstr = num.ToString();
    int[] array = new int[numstr.Length];
    for (int i = 0; i < numstr.Length; i++)
    {
        array[i] = int.Parse(numstr[i].ToString()); 
    }
    return array;
}

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] resultN = IntToArray(N);

int sum = 0;
for (int j = 0; j < resultN.Length; j++)
{
    sum += resultN[j];
}

Console.WriteLine($"Сумма цифр в числе = {sum}");