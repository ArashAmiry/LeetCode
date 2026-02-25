namespace TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> mappedTarget = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (mappedTarget.ContainsKey(complement))
                {
                    // Use the indexer to get the value, then return the pair
                    return new int[] { mappedTarget[complement], i };
                }

                // Add the current number and its index if not found
                if (!mappedTarget.ContainsKey(nums[i]))
                {
                    mappedTarget.Add(nums[i], i);
                }
            }

            // Return this AFTER the loop finishes without a match
            return Array.Empty<int>();
        }
    }

}