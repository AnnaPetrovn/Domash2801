/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    var rnd = new Random();
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = rnd.Next(1, 100);
            }
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MiddleAriphmeticOfColumn(int[,] array)
{
    double middleAriphmetic = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            {
                middleAriphmetic = middleAriphmetic + array[i, j];
                

            }
        }
        middleAriphmetic = middleAriphmetic/array.GetLength(0);
        Console.WriteLine(middleAriphmetic);
        middleAriphmetic = 0;
    }
}

int[,] arr = CreateArray(4, 5);
PrintArray(arr);
MiddleAriphmeticOfColumn(arr);
