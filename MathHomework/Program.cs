namespace MathHomework;

public static class Program
{
    // Func takes in X and returns Y
    private static Dictionary<int, Func<float, float>> _problems = new()
    {
        { 3, (x) => ((-(3f/2f)) * x) - 4f },
        { 5, (x) => (2f * x) - 5f },
        { 7, (x) => (-3f * x) - 5f },
        { 9, (x) => (-3.5f * x) + 5f },
        { 11, (x) => (0.25f * x) - 3f },
        { 15, (x) => 3f },
    };

    private static float[] xValues = new float[] { 5f, 4f, 3f, 2f, 1f, 0f, -1f, -2f, -3f, -4f, -5f };

    public static void Main()
    {
        foreach (var problem in _problems)
        {
            foreach (float xValue in xValues)
            {
                float yValue = problem.Value.Invoke(xValue);
                Console.WriteLine($"Problem #{problem.Key}: X={xValue}, Y={yValue}");
            }

            Console.WriteLine();
        }
    }
}