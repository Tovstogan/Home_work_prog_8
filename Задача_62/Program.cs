/*Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7*/ 

Console.Clear();
Console.WriteLine("Задача 62");
int n = 4;
int[,] spiralMatrix = new int[n, n];

int point = 1;
int i = 0;
int j = 0;

while (point <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
{
  spiralMatrix[i, j] = point;
  point++;
  if (i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= spiralMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > spiralMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

void PrintSpiralMatrix (int[,] spiralMatrix)
{
  for (int i = 0; i < spiralMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < spiralMatrix.GetLength(1); j++)
    {
      if (spiralMatrix[i,j] / 10 <= 0)
      Console.Write($" {spiralMatrix[i,j]} ");

      else Console.Write($"{spiralMatrix[i,j]} ");
    }
    Console.WriteLine();
  }
}

PrintSpiralMatrix(spiralMatrix);
