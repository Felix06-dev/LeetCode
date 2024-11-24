public class Solution {
    public int ClimbStairs(int n) 
    {
        int x = 0, y = 1, z = 0;
        for(int i = 1; i < n + 1; i++)
        {
            z = x + y;
            x = y;
            y = z;    
        }
        return z;
    }
}