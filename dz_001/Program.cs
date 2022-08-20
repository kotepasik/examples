// 25.  Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int num(int A, int B)
{
  int res = 1;
  for(int i=1; i <= B; i++)
  {
    res = res * A;
  }
    return res;
}
int number =  num(A, B);
Console.WriteLine("Ответ: " +  number);
*/


// 27. Напишите метод, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

int summa(int A)
{
    int counter = Convert.ToString(A).Length;
    int num = 0;
    int res = 0;

  for(int i=0; i < counter; i++)
  {
    num = A - A % 10;
    res = res + (A - num);
    A = A / 10;
  }
    return res;
}
int sum = summa(A);
Console.WriteLine("Ответ: " +  sum);
*/

// 29. Напишите метод, которай задаёт массив из 8 элементов и выводит их на экран.

// Уточнения: Пусть это будут случайные буквы алфавита

// Будем использовать следующие методы:

// 1.Метод создания массива
// 2.Метод печати масиива
// 3.Метод заполнения массива
// 4.Метод получения случайного символа

// ___1.Метод создания массива


char[] CreateArray(int count)
{
    return new char[count];
}

// ___2.Метод печати массива

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

// ___3.Метод заполнения масиива

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

// ___4.Метод получения случайного символа

char GetChar()
{
    return Convert.ToChar(new Random().Next(64, 64 + 22));
}


// ___Сам текст задачи с применением созданных методов
char[] arg = CreateArray(8);
FillArray(arg);
PrintArray(arg);