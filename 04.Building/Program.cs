﻿int floors = int.Parse(Console.ReadLine()); 
int count = int.Parse(Console.ReadLine());

for (int i = floors; i >= 1; i--)
{
    for (int j = 0; j < count; j++)
    {
        if (floors == i)
        {
            Console.Write($"L{i}{j} ");
        }
        else if (i % 2 == 0)
        {
            Console.Write($"O{i}{j} ");

        }
        else  
        {
            Console.Write($"A{i}{j} ");
        }
    }
    Console.WriteLine();
}

