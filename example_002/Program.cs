// ___________ 1 Сложение двух случайно сгенерированных целых чисел и показать арифметическое выражение

/*
int x = new Random().Next(-10, 11);
int y = new Random().Next(-10, 11);

Console.Write(x);                                                  // первый способ вывода
Console.Write("+");
Console.Write(y);
Console.Write("=");
Console.WriteLine(x + y);

Console.WriteLine(x + "+" + y + "=" + (x + y));                    // второй способ вывода

Console.WriteLine("{0}+{1}={2}", x, y, x + y);                     // третий способ

Console.WriteLine(String.Format("{0}+{1}={2}", x, y, x + y));      // Четвёртый способ (в отличии от 3-го работает не только в консоли)  

Console.WriteLine($"{x,3}+{y}={x + y}");                           // Пятяй способ, интерполяция строк. {x,3} - 3 это оотступ
*/

// __________ 2. Показать числа от -N до N

int N = new Random().Next(10, 20);
int M = -N;

while (M <= N)
{
    Console.Write(M + " ");
    M++;
}
