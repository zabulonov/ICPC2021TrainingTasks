using Problems;

namespace Tests;

public class Tests
{
    [TestCase(1.5, 2, 3.5, ExpectedResult = new double[] {0, 3, 4})]
    public double[] TestProblemA(double a, double b, double c)
    {
        return ProblemA.AverageThrice(a, b, c);
    }
    
    [TestCase(8, 13, 100, ExpectedResult = 38)]
    public int TestProblemB(int a, int b, int c)
    {
        return ProblemB.BreadCrusts(a, b, c);
    }
    
    [TestCase(2022, ExpectedResult = 20211912)]
    public long TestProblemС(long year)
    {
        return ProblemC.CurrentYearProblem(year);
    }
    
    [TestCase(4, 8, ExpectedResult = new int[] {2, 2, 0, 0, 0, 0, 2, 1, 1, 2})]
    public int[] TestProblemD(int n, int d)
    {
        return ProblemD.DynamicCinderella(n, d);
    }
    
    [TestCase(5, new int[] {3, 7, 5, 4, 8}, ExpectedResult = 1)]
    [TestCase(5, new int[] {1, 5, 4, 7, 6}, ExpectedResult = 2)]
    public int TestProblemF(int a, int[] b)
    {
        return ProblemF.FineSegments(a,b);
    }
    
    
}