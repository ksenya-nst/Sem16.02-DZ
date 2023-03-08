// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
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
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

double[] matrix = new double[matrix.GetLength(1)];

for (int j = 0; j < matrix.GetLength(1); j++)
{
    double result = 0.0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        result += matrix[i, j];
    }
    matrix[j] = result / matrix.GetLength(0);
}

int rows = ReadInt("Введите количество строк в матрице: ");
int cols = ReadInt("Введите количество столбцов в матрице: ");


System.Console.WriteLine();
var myMatrix = GenerateMatrix(rows, cols); 
PrintMatrix(myMatrix);

