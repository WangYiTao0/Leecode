public static class Program{
    
    public static void Main(){
        Console.WriteLine(23%10);
        
        int n = 234;
        Solution solution = new Solution();
        int result = solution.SubtractProductAndSum(n);
        Console.WriteLine($"预期结果{15}");
        Console.WriteLine($"结果{result}");
        
        n = 4421;
        result = solution.SubtractProductAndSum(n);
        Console.WriteLine($"预期结果{21}");
        Console.WriteLine($"结果{result}");
    }
}

//1281. 整数的各位积和之差
public class Solution {
    public int SubtractProductAndSum(int n) {
        int addAmount = 0;
        int mulAmount = 1;
        while(n != 0){
            //remainder 余数
            int remainder = n % 10;
            n/=10;
            addAmount += remainder;
            mulAmount *= remainder;
        }
        return mulAmount - addAmount;
    }
}