public class Solution {
    
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        MyDequeue window = new MyDequeue();
        List<int> result = new List<int>();
        
        //初始化第一个窗口
        for (int i = 0; i < k; i++)
        {
            window.Enqueue(nums[i]);
        }
        //添加最大值
        result.Add(window.Max());

        for (int i = k; i < nums.Length; i++)
        {
            //移除左侧数字
            window.Dequeue(nums[i-k]);
            //添加右侧数字
            window.Enqueue(nums[i]);
            //添加当前窗口的最大值
            result.Add(window.Max());
        }

        return result.ToArray();

    }
    // public int[] MaxSlidingWindow(int[] nums, int k)
    // {
    //     // 创建一个优先级队列，其中的元素按降序排列
    //     PriorityQueue<int,int> priorityQueue = new PriorityQueue<int,int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
    //     int length = nums.Length;
    //     int[] results = new int[length - k + 1];
    //     int index = 0;
    //     for (int i = 0; i < length - k + 1; i++)
    //     {
    //         // 将窗口内的元素添加到优先级队列中
    //         for (int j = i; j < i + k; j++)
    //         {
    //             priorityQueue.Enqueue(nums[j], nums[j]);
    //         }
    //         
    //         // 取出优先级队列中的最大值
    //         results[index++] = priorityQueue.Dequeue();
    //         priorityQueue.Clear();
    //     }
    //
    //     return results;
    // }
    
    // 超出时间限制
    // public int[] MaxSlidingWindow(int[] nums, int k)
    // {
    //     List<int> maxValueList = new List<int>();
    //     int maxValue = 0;
    //     int length = nums.Length;
    //     for (int i = 0; i <=  length - k ; i++)
    //     {
    //         maxValueList.Add(GetMaxValue(nums, i, i + k));
    //     }
    //
    //     return maxValueList.ToArray();
    // }
    //
    // private int GetMaxValue(int[] nums, int start, int end)
    // {
    //     int maxValue = int.MinValue;
    //     for (int i = start; i < end; i++)
    //     {
    //         if (nums[i] > maxValue)
    //         {
    //             maxValue = nums[i];
    //         }
    //     }
    //
    //     return maxValue;
    // }
}