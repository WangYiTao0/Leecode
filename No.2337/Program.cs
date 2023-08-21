Solution solution = new Solution();
string start = "_L__R__R_", target = "L______RR";
Console.WriteLine("预期结果是：True");
Console.WriteLine("实际结果是：" + solution.CanChange(start, target));

start = "R_L_";
target = "__LR";
Console.WriteLine("预期结果是：False");
Console.WriteLine("实际结果是：" + solution.CanChange(start, target));

start = "_R";
target = "R_";

Console.WriteLine("预期结果是：False");
Console.WriteLine("实际结果是：" + solution.CanChange(start, target));