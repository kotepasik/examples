//Реализовать программу переворота матрицы

// 0000
// 0010
// 0011
// 0010

// 0000
// 0000
// 0111
// 0010



//заполняет массив
void ArrayFill(int[,] matrix1)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            matrix1[i, j] = new Random().Next(1, 10);
        }
    }
}

//выводит матрицу в консоль
void ArrayPrint(int[,] matrix1)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write($"{matrix1[i, j]} ");
        }
        Console.WriteLine();
    }
}

// метод поворота матрицы

void ArrayRound(int[,] matrix2, int[,] matrix3)
{
for (int i = 0; i <= 3; ++i)
{
    for (int j = 0, t = 3; j <= 3; ++j, --t)
    {
        matrix2[i, j] = matrix3[t, i];
        Console.Write(matrix2[i, j] + " ");
    }
    Console.WriteLine();
}
}

// Сама программа

int[,] matrix = new int[4, 4];
int[,] matrix1 = new int[4, 4];
ArrayFill(matrix);
ArrayPrint(matrix);

Console.WriteLine();

ArrayRound(matrix1, matrix);


