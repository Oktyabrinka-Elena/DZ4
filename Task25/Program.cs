﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// цикл вместо int result = Math.Pow(A, B);
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int result = 1; // пляшем от нулевой степени (А в степени "0" равна 1)
for(int i=1; i <= B; i++)
{
    result = result * A; 
}

Console.WriteLine($"'{A}' в степени '{B}': {result}");
