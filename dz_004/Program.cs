// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.
// Например, задан массив:

// Метод заполнения матрицы


void FillArray(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = new Random().Next(0, 10);
        }
    }
}

// Метод печати матрицы

void PrintArray(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            Console.Write($"{matrix1[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Метод упорядочивания элементов по убыванию 

void SortArray(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int y = 0; y < matrix1.GetLength(1); y++)
        {
            for (int j = 0; j < matrix1.GetLength(1) - 1; j++)
            {
                if (matrix1[i, j] < matrix1[i, j + 1])
                {
                    int x = matrix1[i, j + 1];
                    matrix1[i, j + 1] = matrix1[i, j];
                    matrix1[i, j] = x;
                }
            }
        }

    }
}

int[,] Matrix1 = new int[5, 5];
FillArray(Matrix1);
PrintArray(Matrix1);
SortArray(Matrix1);

Console.WriteLine();

PrintArray(Matrix1);


/*
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// Метод заполнения матрицы

void FillArray(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = new Random().Next(0, 10);
        }
    }
}

// Метод печати матрицы

void PrintArray(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            Console.Write($"{matrix1[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Метод для нахождения суммы строчки (в последний элемент строки записывается сумма строки)

void SumOfRow(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1) - 1; j++)
        {
            matrix1[i, 3] += matrix1[i, j];
        }

    }
}

// Метод нахождения минимальной суммы строки

// void FindMinSumRow(int[,] matrix1)

// {
//     int min = 0;
//     for (int i = 0; i < matrix1.GetLength(0) - 1; i++)
//     {
//         min = matrix1[i, 3];
//         if (min > matrix1[i + 1, 3])
//         {
//             min = matrix1[i + 1, 3];
//         }

//     }
//     Console.WriteLine(min);
// }


int FindRow(int[,] matrix1)

{
    int min = 0;
    for (int i = 0; i < matrix1.GetLength(0) - 1; i++)
    {
        min = matrix1[i, 3];
        if (min > matrix1[i + 1, 3])
        {
            min = matrix1[i + 1, 3];
        }

    }
    return min;
}


int[,] Matrix1 = new int[4, 4];
FillArray(Matrix1);
PrintArray(Matrix1);
SumOfRow(Matrix1);

Console.WriteLine();

PrintArray(Matrix1);

int min2 = FindRow(Matrix1);

void FindMinRow(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        if (matrix1[i, 3] == min2)
        {
            Console.WriteLine($"Строка с наименьшей суммой элементов: {i}");
        }

    }
}

FindMinRow(Matrix1);

*/