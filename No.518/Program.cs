public static class Program
{

    public static void Main()
    {
        Solution solution = new Solution();
        int[] coins = {1,2,5};
        int amount = 5;
        int result = solution.Change(amount,coins);
        Console.WriteLine($"预期结果{4}");
        Console.WriteLine($"结果{result}");
        
        coins = new[]{2};
        amount = 3;
        result = solution.Change(amount,coins);
        Console.WriteLine($"预期结果{0}");
        Console.WriteLine($"结果{result}");
        
        coins = new[]{10};
        amount = 10;
        result = solution.Change(amount,coins);
        Console.WriteLine($"预期结果{1}");
        Console.WriteLine($"结果{result}");
        
    }
}

public class Solution {
    public int Change(int amount, int[] coins)
    {
        // dp[i] 表示金额之和等于 i 的硬币组合数
        int[] dp = new int[amount + 1];
        //金额为0时，只有一种组合，即不选取任何硬币
        dp[0] = 1;
        //
        foreach (int coin in coins)
        {
            //当前硬币的金额必须小于等于总金额
            for (int i = coin; i <= amount; i++)
            {
                dp[i] += dp[i - coin];
            }

            // for (int i = 0; i < dp.Length; i++)
            // {
            //     Console.Write($"dp[{i}] : {dp[i]}, ");
            // }
            // Console.WriteLine("-----");
        }

        return dp[amount];
    }
}