
Solution solution = new Solution();
string[] pizza = {"A..", "AAA", "..."};
int k = 3;
int result = solution.Ways(pizza, k);
Console.WriteLine($"预期结果: 3");
Console.WriteLine($"结果: {result}");

Console.WriteLine("------------------------");

pizza = new[] {"A..", "AA.", "..."};
k = 3;
result = solution.Ways(pizza, k);
Console.WriteLine($"预期结果: 1");
Console.WriteLine($"结果: {result}");

Console.WriteLine("------------------------");

pizza = new[] {"A..", "A..", "..."};
k = 1;
result = solution.Ways(pizza, k);
Console.WriteLine($"预期结果: 1");
Console.WriteLine($"结果: {result}");