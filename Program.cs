﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] numbers = { 5, 8, 7, 3, 4 };
Console.WriteLine(numbers[3]);

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

int[,] matrix = { { 1, 8, 7 }, { 2, 4, 6 } };
Console.WriteLine("Matrix");
Console.WriteLine(matrix[0, 1]);