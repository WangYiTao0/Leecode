public class Solution {
    public bool CanChange(string start, string target)
    {
        if (start.Length != target.Length) return false;

        if (start.Replace("_", "") != target.Replace("_", ""))
        {
            return false;
        }
        
        int length = start.Length;
        int j = 0;
        for (int i = 0; i < length; i++)
        {
            if(start[i] == '_')
                continue;
            while (target[j] == '_')
                j++;
            // 如果第一个是 L  且 i < j 为真， 因为 i<j L 不能往右平移，所以为假
            // 或者第一个是 R 且 i < j 为假， 因为 i>j R 不能往左平移，所以为假
            if(i != j && (start[i] == 'L') == (i<j))
                return false;
            j++;
        }

        return true;
    }
}