// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int A = 2;
int B = 10;

int max = A;
int min = B;

if(A > max) max = A;
if(B > max) max = B;
if (A < max) min = A;
if (B < max) min = B;

Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);