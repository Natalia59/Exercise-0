﻿Console.Write("Введите первое число: ");
string userInput1 = Console.ReadLine() ?? "";
int userNumber1 = int.Parse(userInput1);

Console.Write(userNumber1 + " -> ");

if (userNumber1 % 2 == 0) Console.WriteLine("Четное");
else Console.WriteLine("Не четное");
