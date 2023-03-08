﻿// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int ReadInt(string text) 
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine()); 
}

double[,] GenerateMatrix(int rows, int cols)
{
    Random rand = new Random();
    double[,] matrix = new double [rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(0,11);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}


int rows = ReadInt("Введите количество строк в матрице: ");
int cols = ReadInt("Введите количество столбцов в матрице: ");


System.Console.WriteLine();
var myMatrix = GenerateMatrix(rows, cols); 
PrintMatrix(myMatrix);
