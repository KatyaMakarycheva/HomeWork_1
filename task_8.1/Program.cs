﻿//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int a = 5;
int index = 1;

while(a % 2 == 0)
{
    Console.WriteLine(index);
    index = index + 1; 
}