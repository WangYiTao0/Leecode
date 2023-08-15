
public static class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        string s = "abcd";
        int[] indices = {0, 2};
        string[] sources = {"a", "cd"};
        string[] targets = {"eee", "ffff"};
        string result = solution.FindReplaceString(s, indices, sources, targets);
        Console.WriteLine($"预期结果: eeebffff");
        Console.WriteLine($"结果: {result}");

        s = "abcd";
        indices = new[] {0, 2};
        sources = new[] {"ab", "ec"};
        targets = new[] {"eee", "ffff"};
        result = solution.FindReplaceString(s, indices, sources, targets);
        Console.WriteLine($"预期结果: eeecd");
        Console.WriteLine($"结果: {result}");

        s = "vmokgggqzp";
        indices = new[] {3, 5, 1};
        sources = new[] {"kg", "ggq", "mo"};
        targets = new[] {"s", "so", "bfr"};
        result = solution.FindReplaceString(s, indices, sources, targets);
        //vmo kg ggqzp => vmo s ggqzp
        //vmos ggq zp => vmos so zp
        //v mo ssozp => v bfr ssozp
        Console.WriteLine($"预期结果: vbfrssozp");
        Console.WriteLine($"结果: {result}");

        s = "wqzzcbnwxc";
        indices = new[] {5, 2, 7};
        sources = new[] {"bn", "zzc", "wxc"};
        targets = new[] {"t", "lwb", "nee"};
        result = solution.FindReplaceString(s, indices, sources, targets);
        //wqzzc bn wxc => wqzzc t wxc
        //wq zzc twxc => wq lwb twxc
        //wqlwbt wxc => wqlwbt nee
        Console.WriteLine($"预期结果: wqlwbtnee");
        Console.WriteLine($"结果: {result}");

        s = "abcde";
        indices = new[] {2, 2};
        sources = new[] {"cdef", "bc"};
        targets = new[] {"f", "fe"};
        result = solution.FindReplaceString(s, indices, sources, targets);
        //abcde => abcde
        Console.WriteLine($"预期结果: abcde");
        Console.WriteLine($"结果: {result}");
        
    }
}
