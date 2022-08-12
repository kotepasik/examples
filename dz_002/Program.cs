// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Метод создания массива

void create(int[] array)
{
    int index = 0;
    int length = array.Length;
    while (index < length)
    {
        array[index] = new Random().Next(0, 1000);
        index++;
    }
}

// Метод печати масиива в консоль

void print(int[] mass)
{
    int i = 0;
    int l = mass.Length;
    while (i < l)
    {
        Console.Write(mass[i] + " ");
        i++;
    }
    Console.WriteLine();
}

// Метод определения количества чётных элементов в массиве

void Chet(int[] collection)
{
    int idx = 0;
    int len = collection.Length;
    int result = 0;
    while (idx < len)
    {
        if (collection[idx] % 2 == 0)
        {
            result = result + 1;
        }
        idx++;
    }
    Console.WriteLine(result);

}

int[] array1 = new int[7];
create(array1);
print(array1);
Chet(array1);


//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/*
Console.WriteLine("Введите кол-во элементов массива");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный элемент массива");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный элемент массива");
int C = Convert.ToInt32(Console.ReadLine());
int[] array = new int[A];

void ArrayFill(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(B, C);
    }
}
void ArrayPrint(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]},");
    }
}
ArrayFill(array);
int sum = 0;
{
    for (int z = 0; z < array.Length; z++)
        if (z != 0 && z % 2 == 0) sum = sum + array[z];
}
Console.Write($"[");
ArrayPrint(array);
Console.Write($"]-> {sum} ");
*/

//Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

/*
Console.WriteLine("Введите количество элементов массива");
int A = Convert.ToInt32 (Console.ReadLine());

double[] array = new double[A];

void ArrayFill (double[] array)
{
    for(int i = 0; i < array.Length; i ++)
    {
        array[i] = new Random().Next(-100, 101);
    }
}
void ArrayPrint (double[] array)
{
    for(int j = 0; j < array.Length; j ++)
    {
        Console.Write($"{array[j]} ");
    }
}
ArrayFill(array);

double min = 0;
{
    for (int z = 0; z < array.Length; z++)
    if (array[z] < min) min = array[z];
}

double max = 0;
{
    for (int y = 0; y < array.Length; y++)
    if (array[y] > max) max = array[y];
}
double x = max - min;

//Console.WriteLine($"Минимальный элемент массива {min}" );
//Console.WriteLine($"Максимальный элемент массива {max}");
Console.Write($"[");
ArrayPrint(array);
Console.Write($"]-> {x} ");
*/



