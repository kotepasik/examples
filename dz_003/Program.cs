// Задача 41: Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь.

// 0, 7, 8, -2, -2 ---> 2
// 1, -7, 567, 89, 223 ---> 4

void Print(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();

}

int CountSym(string s, char c)
{
    int length = s.Length;
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (s[i] == c) count++;
    }
    return count;
}

int IndexSep(string s, char c)
{
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == c) return i;
    }
    return -1;
}

string SubStr(string s, int pos)
{
    string NewString = string.Empty;
    for (int i = pos; i < s.Length; i++)
    {
        NewString += $"{s[i]}";
    }
    return NewString;
}

string SubStrLeng(string s, int pos, int size)
{
    string NewString = string.Empty;
    for (int i = pos; i < pos + size; i++)
    {
        NewString += $"{s[i]}";
    }
    return NewString;
}

int[] NewString(string s)
{
    int[] array = new int[CountSym(s, ',') + 1];
    s += ',';
    int index = 0;
    string newS = string.Empty;
    while (s.Length != 0)
    {
        int PosSep = IndexSep(s, ',');
        // Console.WriteLine($"pos: {PosSep}");
        string newStr1 = SubStrLeng(s, 0, PosSep);
        // Console.WriteLine($"newStr1: {newStr1}");
        string newStr = SubStr(s, PosSep + 1);
        newS = newS + newStr1;
        // Console.WriteLine($"newStr: {newS} ");
        s = newStr;
        array[index] = Convert.ToInt32(newStr1);
        index++;
    }
    return array;
}

int CountPlus(int[] array)
{
    int s = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            s++;
        }
    }
    return s;
}


Console.Write($"Введите числа через запятую: ");
string f = Console.ReadLine()!;
int[] arr = NewString(f);
Print(arr);
int c = CountPlus(arr);
Console.WriteLine($"Количество чисел больше 0: {c}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

/*
Console.Write($"Введите данные уравнения к1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите данные уравнения b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите данные уравнения к2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите данные уравнения b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

void Print(double[] array)                 // метод печати
{
    Console.Write($"Координаты точки пересечения: (  ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]:f2} ");
    }
    Console.Write($")");
}

double[] IntersecLine(double[] array)      // метод нахождения точки пересечения двух прямых
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) array[i] = (b2 - b1) / (k1 - k2);
        if (i == 1) array[i] = k1 * (b2 - b1) / (k1 - k2) + b1;
    }
    return array;
}


double[] z = new double[2];
IntersecLine(z);
Print(z);
*/