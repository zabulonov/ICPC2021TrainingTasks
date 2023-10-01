namespace Problems;

public static class ProblemB
{
    public static int BreadCrusts(int a, int b, int c)
    {
        return (int)(c / ((double)(a + b) / 8));
    }
}