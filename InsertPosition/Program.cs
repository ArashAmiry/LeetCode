namespace InsertPosition
{
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    return i;
                }
                else if (i == nums.Length - 1)
                {
                    return nums.Length;
                }
                else if (nums[i] > target)
                {
                    return i;
                }
            }

            return 0;
        }
    }
}
