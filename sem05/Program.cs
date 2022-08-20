/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
сумма отрицательных равна -20.
*/

// Метод создания массива

void create(int[] array)
{
    int index = 0;
    int length = array.Length;
    while (index < length)
    {
        array[index] = new Random().Next(-9, 10);
        index++;
    }
}

// Метод определения отрицательных и положительных чисел и получения их сумм

void Method1(int[] collection)
{
    int idx = 0;
    int len = collection.Length;
    int sumPol = 0;
    int sumOtr = 0;
    while (idx < len)
    {
        if (collection[idx] > 0)
        {
            sumPol += collection[idx];
        }
        else
        {
            sumOtr += collection[idx];
        }
        idx++;
    }
    Console.WriteLine(sumPol);
    Console.WriteLine(sumOtr);
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

int[] array1 = new int[12];
create(array1);
print(array1);
Method1(array1);






