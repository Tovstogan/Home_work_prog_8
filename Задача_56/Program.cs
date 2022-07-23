/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 
1 строка*/

Console.Clear();
Console.WriteLine("Задача 56");
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
void MinSum(int[,] matr)
{
int[]sum = new int[matr.GetLength(0)];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum[i]=sum[i]+matr[i,j];
        }
    }

int minIndex=0;
int min=sum[0];
for(int i = 0 ; i < matr.GetLength(0); i++)
    {
        if(min > sum[i])
        {
            min=sum[i];
            minIndex=i;
        }
    }

Console.WriteLine($"Строка с наименьшей суммой элементов №{minIndex+1}");
}



Console.WriteLine("Введите число m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = int.Parse(Console.ReadLine());

int[,] matrix = InitMatrix(m, n);
Console.WriteLine($"Матрица размером {m}x{n}:");
Console.WriteLine();

PrintMatrix(matrix);
MinSum(matrix);