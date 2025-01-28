string input = Console.ReadLine();    

while (input != "End")
{
  int num = int.Parse(input);
    int sum = 0;
    
    while (num > 0) {
        int lastNum = num % 10;
        sum += lastNum;
        num /= 10;
    }
    Console.WriteLine($"Sum of digits = {sum}");
    input = Console.ReadLine();

    }
Console.WriteLine("Goodbye");