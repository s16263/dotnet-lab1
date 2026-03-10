public static int CalculateMin(int[] values)
{
    if (values.Length == 0)
        return 0;

    int min = values[0];

    foreach (var value in values)
    {
        if (value < min)
        {
            min = value;
        }
    }

    return min;
}