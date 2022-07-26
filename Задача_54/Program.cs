﻿/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

В итоге получается вот такой массив:

1 2 4 7

2 3 5 9

2 4 4 8*/

Console.Clear();
Console.WriteLine("Задача 54");
int[,] InitMatrix(int m, int n)
{
int[,] matrix = new int[m, n];
Random randomizer = new Random();

for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
{
matrix[i, j] = randomizer.Next(1, 10);
}
}
return matrix;
}

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write($"{matrix[i, j]} ");
}
Console.WriteLine();
}
}

void  ChangeMatrix(int[,] matr)
{
    int temp=0;
for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int x = j + 1; x < matr.GetLength(1); x++)
            {
                if (matr[i,j] > matr[i,x])
                {
                temp = matr[i,x];
                matr[i,x] = matr[i,j];
                matr[i,j] = temp;
                }
            }
        }
    }
    PrintMatrix(matr);
}



Console.WriteLine("Введите число m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = int.Parse(Console.ReadLine());

int[,] matrix = InitMatrix(m, n);
Console.WriteLine($"Матрица размером {m}x{n}:");
Console.WriteLine();

PrintMatrix(matrix);
Console.WriteLine("Измененная матрица: ");
ChangeMatrix(matrix);