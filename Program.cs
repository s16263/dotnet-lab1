Console.WriteLine("Simple statistics app");
Console.Write("Enter a number: ");

string? input = Console.ReadLine();

Console.WriteLine($"You entered: {input}");

if (!double.TryParse(input, out double number))
{
    Console.WriteLine("Invalid input. Please enter a number.");
    return;
}

double result = StatisticsHelper.Square(number);

Console.WriteLine($"Square: {result}");

int[] sampleValues = { 4, 8, 2, 9, 1 };

int minValue = StatisticsHelper.CalculateMin(sampleValues);
Console.WriteLine($"Min: {minValue}");