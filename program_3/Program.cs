﻿//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.Clear();
int AddInteger(int ver)
{
    
    Console.Write($"ВВедите число: ");
    ver = int.Parse(Console.ReadLine());
    return ver;
   
}
void SquareNumb(int ver)
{
    int count = 1;
    Console.Write($"{ver} -> ");
    while (count <= ver) 
    {
        int temp = count*count*count;
        Console.Write($"{temp}, ");
        count++;
    }
}
int sqare = 0;
sqare = AddInteger(sqare);
SquareNumb(sqare);