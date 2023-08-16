public class MyDequeue
{
    private LinkedList<int> _linkedList = new LinkedList<int>();

    /// <summary>
    /// 保持 第一个是最大的元素
    /// </summary>
    /// <param name="value"></param>
    public void Enqueue(int value)
    {
        // 从队列尾部 移除比当前值小的元素
        while (_linkedList.Count > 0 && _linkedList.Last.Value < value)
        {
            _linkedList.RemoveLast();
        }
        // 将当前值添加到队列尾部
        _linkedList.AddLast(value);
        
        Console.WriteLine($"当前队列: {string.Join(',', _linkedList)}");
    }

    public int Max()
    {
        return _linkedList.First.Value;
    }

    /// <summary>
    /// 移除队列中的元素 只有当队列头部元素等于当前值时才移除 别的值并不在队列中
    /// </summary>
    /// <param name="value"></param>
    public void Dequeue(int value)
    {
        if (_linkedList.First.Value == value)
        {
            _linkedList.RemoveFirst();
        }
    }
}