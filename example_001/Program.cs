// __________ 1.Приветствие. Ввод данных из консоли и вывод в консоль

/*
Console.Write("Введите ваше имя: ");
string username = Console.ReadLine();
Console.Write("Приветствуем вас, ");
Console.Write(username);
*/

// __________ 2.Сложение двух чисел

/*
int numberA = 3;
int numberB = 4;
int result = numberA + numberB;
Console.WriteLine(result);
*/

// __________ 3.Частное двух чисел

/*
double numberA = 12;
double numberB = 5;
Console.WriteLine(numberA / numberB);
*/

// __________ 4.Сумма двух случайных чисел

/*
int numberA = new Random().Next(-10, 11);
Console.WriteLine(numberA);
int numberB = new Random().Next(-10, 11);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);
*/

// __________ 5.Приветствуем любичика

/*
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Уау, Машенька привет!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
*/

// __________ 6. Перетаскивание гири (определение самой тяжёлой гири)

/*
int a = 2;
int b = 5;
int c = 723434;
int d = 9;
int e = 315324657;
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e; 

Console.Write("max = ");
Console.WriteLine(max);
*/

// __________ Задача про три точки и середину

Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");
int xa = 40;
int ya = 1;
int xb = 1;
int yb = 20;
int xc = 80;
int yc = 20;

Console.SetCursorPosition(xa, ya);
Console.Write("*");
Console.SetCursorPosition(xb, yb);
Console.Write("*");
Console.SetCursorPosition(xc, yc);
Console.Write("*");

int x = xa, y = ya;
int count = 0;

while (count < 10000)
{
    int what = new Random().Next(0, 3); //[0;3) 0 1 2
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");
    count = count + 1; //count+=1 или count++
}
