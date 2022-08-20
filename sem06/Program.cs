//clear
//создаем 2 матрицы 5*5
//печать матриц
//складывание матриц по элементам- 

//заполняет массив
void ArrayFill (int[,] matrix1)
{
    for (int i = 0; i < 5; i++)
    {
    for (int j = 0; j < 5; j++)
        {
        matrix1[i, j] = new Random().Next(1, 10);
        }
    }
}

//выводит матрицу в консоль
void ArrayPrint (int[,] matrix1)
{
   for (int i = 0; i < 5; i++)
    {
    for (int j = 0; j < 5; j++)
        {
        Console.Write($"{matrix1[i, j] } ");
        }
    Console.WriteLine();
    }
}



int[,] matrix1 = new int[5, 5];
int[,] matrix2 = new int[5, 5];
int[,] matrix3 = new int[5, 5];

ArrayFill(matrix1);
ArrayPrint(matrix1);
System.Console.WriteLine();

ArrayFill(matrix2);
ArrayPrint(matrix2);

void ArrayFilll(int[,] matrix3)
{
    for (int i = 0; i < 5; i++)
    {
    for (int j = 0; j < 5; j++)
        {
        matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
        }
    }
}
System.Console.WriteLine();
ArrayFilll(matrix3);
ArrayPrint(matrix3);