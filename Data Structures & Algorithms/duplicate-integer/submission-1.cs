public class Solution {
    public bool hasDuplicate(int[] nums) {
        int n = nums.Length;

        if(n==0)
            return false;

        HashSet<int> set = [];

        for (int i = 0; i < n; i++)
        {
            if (set.Contains(nums[i]))
            {
                return true;
            }
            else
            {
                set.Add(nums[i]);
            }

        }
        return false;
    }
}