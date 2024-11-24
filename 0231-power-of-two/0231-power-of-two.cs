public class Solution {
    public bool IsPowerOfTwo(int n) 
    {
        double x = Math.Log(n)/Math.Log(2);
        if(n <= 0)
        {
            return false;
        }    
        return (n & (n - 1)) == 0;
    }
}