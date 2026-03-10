public static int CalculateMax(int[] values)
{
    if (values.Length == 0)
        return 0;

    int max = values[0];

    foreach (var value in values)
    {
        if (value > max)
        {
            max = value;
        }
    }

    return max;
}