

public static class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        int[] nums = {3,2,1,5,6,4};
        int k = 2;
        int result = solution.FindKthLargest(nums,k);
        Console.WriteLine($"预期结果{5}");
        Console.WriteLine($"结果{result}");
        
        nums = new int[]{3,2,3,1,2,4,5,5,6};
        k = 4;
        result = solution.FindKthLargest(nums,k);
        Console.WriteLine($"预期结果{4}");
        Console.WriteLine($"结果{result}");
    }
}

public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        
        List<int> sortedNums = nums.ToList();
        sortedNums.Sort();
        foreach (var num in sortedNums)
        {
            Console.Write($"{num}, ");
        }
        return sortedNums[sortedNums.Count- k];
    }   
}