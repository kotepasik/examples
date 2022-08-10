// 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа

// 1.1 Вариант без функции

/*
Console.Clear(); //очистка консоли
int number = new Random().Next(10, 100);
Console.WriteLine($"number: {number}");
int x = number / 10;
int y = number % 10;
if (x > y)
{
    Console.WriteLine($"максимальная цифра = {x}");
}
else
{
    Console.WriteLine($"максимальная цифра = {y}");
}
*/

// 2. Задать массив из8-и элементов и вывести его на экран.
// Уточнения: Пусть это будут случайные буквы алфавита

// Будем использовать следующие методы

// 1.Метод создания массива
// 2.Метод печати масиива
// 3.Метод заполнения массива
// 4.Метод получения случайного символа

// 1.Метод создания массива


char[] CreateArray(int count)
{
    return new char[count];
}

// 2.Метод печати массива

void PrintArray(char[] array)
{
    int len = array.Length;
    int i = 0;
    while (i < len)
    {
        Console.Write($"{array[i]} ");
        i++;
    }
 
    Console.WriteLine();
}

// 3.Метод заполнения масиива

void FillArray(char[] array)
{
    int lenght = array.Length;
    int i = 0;
    while (i < lenght)
    {
        array[i] = GetChar();
        i++;
    }

}

// 4.Метод получения случайного символа

char GetChar()
{
    return Convert.ToChar(new Random().Next(64, 64 + 22));
}


/*
int lenght=8;
char[] arg = new char[lenght];
int i=0;
while (i<lenght)
{
    int sc = Convert.ToInt32('а');
    int ec = Convert.ToInt32('z');
    arg[i]=Convert.ToChar(new Random().Next(sc,ec+1));
    Console.WriteLine(arg[i]);
    i++;
}
*/

// Сам текст задачи с применением созданных методов
char[] arg=CreateArray(8);
FillArray(arg);
PrintArray(arg);


// 3.Написать программу замены элементов массива на противоположные

