public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        for (int i = 0; i < nums.Length; i++)
        {
                for(int j = 0; j != i && j < nums.Length; j++)
                {
                    if (nums[j] + nums[i] == target)
                    {
                        int[] TwoSum = {j, i};
                        return TwoSum;
                    }
                    else
                    {
                        continue;
                    }
                }
        }
        int[] NoMatch = {};
        return NoMatch;
    }
}