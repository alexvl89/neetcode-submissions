public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {

        List<int[]> A = [];

        //проходим по массиву
        for (int dx = 0; dx < nums.Length; dx++)
        {
            A.Add(new int[] { nums[dx], dx });
        }

        A.Sort((a, b) => a[0].CompareTo(b[0]));

        int i = 0;
        int j = nums.Length - 1;

        while (i < j)
        {

            int t = A[i][0] + A[j][0];

            if (t == target)
            {
                return new int[]
                {
                    int.Min(A[i][1],A[j][1]),
                    int.Max(A[i][1],A[j][1])
                };
            }
            else if (t < target)
            {
                i++;
            }
            else
            {
                j--;
            }
        }

        return new int[0];
    }
}
