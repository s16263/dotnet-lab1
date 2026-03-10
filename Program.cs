Console.WriteLine("Simple statistics app");
Console.Write("Enter a number: ");

string? input = Console.ReadLine();

Console.WriteLine($"You entered: {input}");

if (!double.TryParse(input, out double number))
{
    Console.WriteLine("Invalid number.");
    return;
}