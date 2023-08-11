public static class Program{
    
    public static void Main()
    {

        Solution solution = new Solution();
        int[] arr = new int[]{1,2,2,1,1,3};
        bool result = solution.UniqueOccurrences(arr);
        Console.WriteLine($"预期结果{true}");
        Console.WriteLine($"结果{result}");
        
        arr = new int[]{1,2};
        result = solution.UniqueOccurrences(arr);
        Console.WriteLine($"预期结果{false}");
        Console.WriteLine($"结果{result}");

        arr = new[] {-3, 0, 1, -3, 1, 1, 1, -3, 10, 0};
        result = solution.UniqueOccurrences(arr);
        Console.WriteLine($"预期结果{true}");
        Console.WriteLine($"结果{result}");


    }
}

public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int,int> countDict = new Dictionary<int,int>();
        foreach(int num in arr){
            if(countDict.ContainsKey(num)){
                countDict[num] += 1;
            }
            else{
                countDict.Add(num,1);
            }
        }
        // foreach(int count in countDict.Values){
        //     if(countDict.Values.Count(x => x == count) > 1){
        //         return false;
        //     }
        // }
        
        // 使用 HashSet 来检查是否有重复的次数
        HashSet<int> seenCounts = new HashSet<int>();
        foreach (int count in countDict.Values) {
            if (seenCounts.Contains(count)) {
                return false;
            }
            seenCounts.Add(count);
        }
        return true;
    }
}