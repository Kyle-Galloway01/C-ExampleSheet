static int[] GenerateFibonacciSequence(int numberOfTerms)
{
    if (numberOfTerms <= 0)
    {
        throw new ArgumentException("Number of terms must be greater than zero.", nameof(numberOfTerms));
    }

    int[] sequence = new int[numberOfTerms];

    if (numberOfTerms >= 1)
    {
        sequence[0] = 0;
    }
    if (numberOfTerms >= 2)
    {
        sequence[1] = 1;
    }

    for (int i = 2; i < numberOfTerms; i++)
    {
        sequence[i] = sequence[i - 1] + sequence[i - 2];
    }

    return sequence;
}
