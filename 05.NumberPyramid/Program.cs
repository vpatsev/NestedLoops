
int num = int.Parse(Console.ReadLine()); 
int count = 1; 
int rowCount = 1;

while (count <= num)
{
    rowCount++; 
    count += rowCount; 
}


count = 1;
int printed = 0;

for (int i = 1; i <= rowCount; i++)
{
    for (int j = 1; j <= i && printed < num; j++)
    {
        Console.Write(count + " ");
        count++;
        printed++;
    }
    Console.WriteLine();
}