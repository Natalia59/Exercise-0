﻿Console.Write("Введите первое число: ");
string userInput1 = Console.ReadLine() ?? "";
int userNumber1 = int.Parse(userInput1);

Console.Write("Введите второе число: ");
string userInput2 = Console.ReadLine() ?? "";
int userNumber2 = int.Parse(userInput2);

Console.Write("Введите третье число: ");
string userInput3 = Console.ReadLine() ?? "";
int userNumber3 = int.Parse(userInput3);

int Max = userNumber1;

if (userNumber1 > userNumber2) Max = userNumber1;
else Max = userNumber2;
if (userNumber3 > Max) Max = userNumber3;

Console.WriteLine(userNumber1 + ", " + userNumber2 + ", " + userNumber3 + " -> " + Max);
