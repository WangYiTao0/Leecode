public class Solution {
    public int[] CircularGameLosers(int n, int k) {
        Dictionary<int,int> players = new Dictionary<int, int>();
        for (int i = 1; i <= n; i++)
        {
            players.Add(i,0);
        }
        int passCount = 1;
        int index = 1;
        int preIndex = 1;
        while (players[preIndex] != 2)
        {
            preIndex = index;
            players[index] += 1;
            index = GetNewIndex(index + passCount * k,n);
            passCount++;
        }
        
        return players.Where(x => x.Value == 0).Select(x => x.Key).ToArray();
    }
    
    private int GetNewIndex(int index, int n)
    {
        while (index > n)
        {
            index -= n;
        }
        return index;
    }
}