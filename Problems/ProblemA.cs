namespace Problems;

public static class ProblemA
{
    public static double[] AverageThrice(double x , double y, double z)
    {

        List<double> ans = new List<double>();
        ans.Add(x - z + y);
        ans.Add(2 * y - ans[0]);
        ans.Add(2 * z - ans[1]);
        ans.Sort();
        return ans.ToArray();
    }
}