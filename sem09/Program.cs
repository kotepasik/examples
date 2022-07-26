﻿// n до 30000
// нужно вычислить разложение первых n чисел на простые множители

//Простым называется любое натуральное число, которое больше единицы
//и имеет два конкретных делителя: себя и единицу.

for (int x = 30000; x < 31000; x++)
{
  int n = x;
  string s = $"{x} = "; ;
  int fs = 2;
  while (n != 1)
  {
    int mod = n % fs;
    if (mod == 0)
    {
      n = n / fs;
      s += $"{fs} ";
      fs = 2;
    }
    else
    {
      fs++;
    }
  }
  Console.WriteLine($"s: {s}");
}