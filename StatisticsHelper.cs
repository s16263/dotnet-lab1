public static double CalculateAverage(int[] values)
{
    if (values.Length == 0)
        return 0;

    int sum = 0;

    foreach (var value in values)
    {
        sum += value;
    }

    return (double)sum / values.Length;
}