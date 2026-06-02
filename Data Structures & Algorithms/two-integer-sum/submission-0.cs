public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> keys = new();

        for (int i = 0; i < nums.Length; i++)
        {
            var finding = target - nums[i];

            if (keys.ContainsKey(finding))
                return new int[] { keys[finding], i };


            keys[nums[i]] = i;
        }

        return new int[0];
    }
}
