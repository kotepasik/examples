// 1. Найти максимальное из 9-и чисел
// 1.1 Стихийно

/*
int a1 = 34;
int b1 = 230;
int c1 = 2;
int a2 = 67;
int b2 = 3;
int c2 = 98;
int a3 = 3;
int b3 = 13;
int c3 = 0;

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;
if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;
if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine(max);
*/

// 1.2 Используя функции (используем алгоритм разделения на тройки и последующего нахождения "финалиста")

/*
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 34;
int b1 = 230;
int c1 = 2;
int a2 = 67;
int b2 = 3;
int c2 = 98;
int a3 = 3000;
int b3 = 13;
int c3 = 0;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);
Console.WriteLine(max);
*/

// 1.3 Применим для задачки массив)

/*
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = { 41, 12, 30, 4, 95, 46, 7, 78, 92 };

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

Console.WriteLine(max);
*/

// __________ 2. Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find

/*
int[] array = { 11, 12, 73, 14, 56, 73, 88 };
int n = array.Length;
int find = 73;
int index = 0;

while (index < n)
{
if(array[index]==find)
{
    Console.WriteLine(index);
    break;
} 
index++;
}
*/

// ____________ 3.Вывести в консоль массив из случайных чисел заданной длины 
//                и найти позицию заданного элемента массива используя методы 


void FillArray(int[] collection) // метод заполнения массива случайными числами
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) // метод вызова масиива в консоль
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) // метод нахождения позиции в массиве
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // если вдруг искомое число не будет входить в масиив будет выдаваться -1
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // определение массива
FillArray(array); // обращение к методу FillArray
PrintArray(array); // обращение к методу PrintArray
Console.WriteLine();

int pos=IndexOf(array,7); // задаём искомый элемент
Console.WriteLine(pos);



