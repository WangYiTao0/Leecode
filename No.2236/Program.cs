Solution solution = new Solution();
TreeNode root = new TreeNode(10,new TreeNode(4),new TreeNode(6));
solution.CheckTree(root);
Console.WriteLine("预期结果是：True");
Console.WriteLine("实际结果是：" + solution.CheckTree(root));
