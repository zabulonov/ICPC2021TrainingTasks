namespace Problems;

public static class ProblemF
{
    public static int FineSegments(int n, int[] array) 
    {
        int ans = 0;
        
        for (int i = 0; i < array.Length-1; i++)
        {
            var context = new List<int>();
            for (int j = i; j < array.Length-i; j++)
            {
                context.Add(array[j]);
                int search = context[0] + context[context.Count-1];
                if (context.Contains(search) && context.Count>2)
                    ans++;
            }   
        }

        return ans;
    }
}