﻿int startNum = int.Parse(Console.ReadLine());
int endNum = int.Parse(Console.ReadLine());

for (int i = startNum; i <= endNum; i++)
{
    int primeCounter = 0;
    for (int j = 1; j <= i; j++)
    {
        if (i % j == 0) { 
        primeCounter++;
    }
    }
    if (primeCounter == 2)
    {
        Console.Write($"{i} ");
    }
}

