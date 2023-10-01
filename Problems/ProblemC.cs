namespace Problems;

public static class ProblemC
{
    public static long CurrentYearProblem(long n)
    {
        long ans = 20210;
        byte step = 1;
        if (n % 2 == 0)
            step = 2;
            
        while (ans % n != 0 || !ans.ToString().StartsWith("2021"))
        {
            ans+=step;
        }
        return ans;
    }
}