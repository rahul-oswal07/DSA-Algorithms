public static class Fibonacci
{
    /// <summary>
    /// Returns the 'nth' fibonacci
    /// </summary>
    /// <param name="n">position</param>
    /// <returns>Value</returns>
    public static int RecursiveFibonnaci(int n)
    {
        if (n == 1) return 1;
        if (n < 1) return 0;

        return RecursiveFibonnaci(n - 1) + RecursiveFibonnaci(n - 2);

    }

    /// <summary>
    /// Returns the nth fibonnaco number using memoization
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static int RecursiveFibonnaciMemo(int n, Dictionary<int, int>? memo = null)
    {
        if (memo == null) memo = new Dictionary<int, int>();
        if (memo.ContainsKey(n)) return memo[n];
        if (n <= 2) return 1;
        memo[n] = RecursiveFibonnaciMemo(n - 1, memo) + RecursiveFibonnaciMemo(n - 2, memo);
        return memo[n];
    }

    /// <summary>
    /// Returns the nth fibonnaco number using Tabulization
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static long FibonacciTabulization(long n)
    {
        long[] table = new long[n + 1];
        table[1] = 1;
        for (long i = 0; i <= n; i++)
        {
            if (i + 1 < table.Length)
                table[i + 1] += table[i];
            if (i + 2 < table.Length)
                table[i + 2] += table[i];
        }
        return table[n];
    }

    /// <summary>
    /// Returns the nth fibonnaco number using Iterative
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static long FibonacciIterative(long n)
    {
        long a = 0, b = 1, c = 0;
        if (n == 1) return b;
        for (int i = 2; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        return c;
    }
}