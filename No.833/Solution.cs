public class Solution {
    public string FindReplaceString(string s, int[] indices, string[] sources, string[] targets) {
        
        int length = indices.Length;
        

        for (int i = 0; i < length; i++)
        {
            //如果需要替换的字符串长度超过源字符串长度，则跳过
            if(sources[i].Length + indices[i] > s.Length)
                continue;
            //需要替换的字符串
            string checkedString = s.Substring(indices[i],sources[i].Length);
            //如果需要替换的字符串与源字符串相同，则进行替换
            if (checkedString == sources[i])
            {
                //替换
                s = s.Remove(indices[i],sources[i].Length);
                s = s.Insert(indices[i],targets[i]);
                //更新索引
                for (int j = i; j < length-1; j++)
                {
                    if (indices[j + 1] >= indices[i])
                    {
                        indices[j+1] = indices[j+1] + targets[i].Length - sources[i].Length;
                    }
                }
                
            }
        }
        return s;
    }
}