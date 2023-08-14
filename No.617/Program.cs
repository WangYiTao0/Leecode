public static class Program{
    
    public static void Main()
    {
        Solution solution = new Solution();
        
        Console.WriteLine("--------case 1---------");
        int?[] l1 = {1, 3, 2, 5};
        int?[] l2 = {2, 1, 3, null, 4, null, 7};

        TreeNode root1 = ConvertToTreeNode(l1);
        TreeNode root2 = ConvertToTreeNode(l2);
        
        TreeNode resultTreeNode = solution.MergeTrees(root1,root2);
        int?[] expectedResult = {3, 4, 5, 5, 4, null, 7};
        foreach (var value in expectedResult)
        {
            if (value == null)
            {
                Console.Write("null, ");
                continue;
            }
            Console.Write(value + ", ");
        }
        Console.WriteLine(("\n--"));
        
        int?[] result = ConvertToArray(resultTreeNode);
        foreach (var value in result)
        {
            if (value == null)
            {
                Console.Write("null, ");
                continue;
            }
            Console.Write(value + ", ");

        }
        

        Console.WriteLine("\n--------case 2---------");
        l1 = new int?[]{1};
        l2 = new int?[]{1,2};
        root1 = ConvertToTreeNode(l1);
        root2 = ConvertToTreeNode(l2);
        resultTreeNode = solution.MergeTrees(root1,root2);
        result = ConvertToArray(resultTreeNode);

        expectedResult = new int?[]{2,2};
        foreach (var value in expectedResult)
        {
            if (value == null)
            {
                Console.Write("null, ");
                continue;
            }
            Console.Write(value + ", ");
        }
        Console.WriteLine(("\n--"));
        
        result = ConvertToArray(resultTreeNode);
        foreach (var value in result)
        {
            if (value == null)
            {
                Console.Write("null, ");
                continue;
            }
            Console.Write(value + ", ");

        }
    }
    
    public static TreeNode ConvertToTreeNode(int?[] array)
    {
        if (array == null || array.Length == 0 || array[0] == null)
        {
            return null;
        }

        TreeNode root = new TreeNode(array[0]);
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        int i = 1;
        while (i < array.Length)
        {
            //
            TreeNode current = queue.Dequeue();

            if (array[i] != null)
            {
                current.left = new TreeNode(array[i]);
                queue.Enqueue(current.left);
            }
            i++;

            if (i < array.Length && array[i] != null)
            {
                current.right = new TreeNode(array[i]);
                queue.Enqueue(current.right);
            }
            i++;
        }

        return root;
    }
    
    public static int?[] ConvertToArray(TreeNode root)
    {
        if (root == null)
        {
            return new int?[0];
        }

        List<int?> result = new List<int?>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        // 用于跟踪最后一个非空节点的位置
        int lastNotNullIndex = 0;

        int index = 0;
        while (queue.Count > 0)
        {
            TreeNode current = queue.Dequeue();
            if (current != null)
            {
                result.Add(current.val);
                queue.Enqueue(current.left);
                queue.Enqueue(current.right);
                if (current.val != null)
                {
                    lastNotNullIndex = index;
                }
            }
            else
            {
                result.Add(null);
            }
            index++;
        }

        // 移除尾部的null值
        return result.Take(lastNotNullIndex + 1).ToArray();
    }


}

//Definition for a binary tree node.
public class TreeNode {
    public int? val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int? val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution {
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2) {

        if (root1 == null)
        {
            return root2;
        }

        if (root2 == null)
        {
            return root1;
        }

        TreeNode newTreeNode = new TreeNode(
            root1.val + root2.val,
            MergeTrees(root1.left, root2.left),
            MergeTrees(root1.right, root2.right));

        return newTreeNode;
    }
}