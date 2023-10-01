namespace Problems;

public static class ProblemD
{
    public static int[] DynamicCinderella(int n, int d)
    {
        int[] ans = new int[10];

        int[][] heap = new int[n][];
        for (int i = 0; i < n; i++)
        {
            heap[i] = new int[i + 1];
        }

        heap[0][0] = d;
        ans[d]++;

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < heap[i].Length; j++)
            {
                if (j == 0)
                {
                    heap[i][j] = (heap[i - 1][j] + 1) % 10;
                    ans[heap[i][j]]++;
                }
                else
                {
                    heap[i][j] = (heap[i][j - 1] + heap[i - 1][j - 1]) % 10;
                    ans[heap[i][j]]++;
                }
            }
        }
        return ans;
    }
}