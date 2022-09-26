public static class GridTraveller
{
    public static int gridTravellerMemo(int m, int n, Dictionary<string, int>? memo = null)
    {
        if (memo == null) memo = new Dictionary<string, int>();
        string key = n + "," + m;
        if (memo.ContainsKey(key)) return memo[key];
        if (m == 1 && n == 1) return 1;
        if (m == 0 || n == 0) return 0;

        memo[key] = gridTravellerMemo(m - 1, n, memo) + gridTravellerMemo(m, n - 1, memo);

        return memo[key];
    }

    public static int gridTravellerTabulation(int m, int n)
    {
        int[,] table = new int[m + 1, n + 1];
        table[1, 1] = 1;
        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                int current = table[i, j];
                if (j + 1 <= n) table[i, j + 1] += current;
                if (i + 1 <= m) table[i + 1, j] += current;
            }
        }

        return table[m, n];
    }
}