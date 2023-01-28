/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1, 7 -> такого числа в массиве нет*/

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

    void FindindElementInMassiv(int[,] array, int row, int column)
    {
        if (row < array.GetLength(0) & column < array.GetLength(1))
        {
            Console.WriteLine("Искомый элемент в массиве" + array[row, column]);
        }
        else Console.WriteLine("Такого элемента в массиве нет");
    }
    
    int[,] arr = CreateArray(4, 5);
    PrintArray(arr);
    FindindElementInMassiv(arr, 0, 4);


