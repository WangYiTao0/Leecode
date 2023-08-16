public static class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        int[] results= solution.CircularGameLosers(5, 2);
        Console.WriteLine($"预期结果: 4 5");
        Console.Write("结果: ");
        foreach (var result in results)
        {
            Console.Write($"{result} ");
        }
        
        Console.WriteLine("---- 分割线 ----");
        results = solution.CircularGameLosers(4, 4);
        Console.WriteLine($"预期结果: 2 3 4");
        Console.Write("结果: ");
        foreach (var result in results)
        {
            Console.Write($"{result} ");
        }
        
        Console.WriteLine("---- 分割线 ----");
        results = solution.CircularGameLosers(3, 2);
        Console.WriteLine($"预期结果: 2");
        Console.Write("结果: ");
        foreach (var result in results)
        {
            Console.Write($"{result} ");
        }
    }
}