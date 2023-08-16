

Solution solution = new Solution();
int[] results= solution.MaxSlidingWindow(new int[]{1,3,-1,-3,5,3,6,7}, 3);


Console.WriteLine($"预期结果: 3 3 5 5 6 7");
Console.Write("结果: ");
foreach (var result in results)
{
    Console.Write($"{result} ");
}

Console.WriteLine("---- 分割线 ----");

results = solution.MaxSlidingWindow(new int[]{1}, 1);
Console.WriteLine($"预期结果: 1");
Console.Write("结果: ");
foreach (var result in results)
{
    Console.Write($"{result} ");
}

Console.WriteLine("---- 分割线 ----");
results = solution.MaxSlidingWindow(new int[]{1,-1}, 1);
Console.WriteLine($"预期结果: 1 -1");
Console.Write("结果: ");
foreach (var result in results)
{
    Console.Write($"{result} ");
}


// Console.WriteLine("---- 分割线 ----");
//
// string text = File.ReadAllText("data.txt");
// // 使用逗号分隔文本，并将每个元素转换为整数
// string[] textNumbers = text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
// int[] numbers = Array.ConvertAll(textNumbers, int.Parse);
//
// results = solution.MaxSlidingWindow(numbers, 1000);
// Console.WriteLine($"预期结果: 1 -1");
// Console.Write("结果: ");
// foreach (var result in results)
// {
//     Console.Write($"{result} ");
// }


