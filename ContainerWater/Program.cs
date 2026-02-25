public class Solution
{
    public int MaxArea(int[] height)
    {
        int maxArea = 0;
        int leftPointer = 0;
        int rightPointer = height.Length - 1;

        while (leftPointer < rightPointer)
        {

                int minHeight =  Math.Min(height[leftPointer], height[rightPointer]);
                int width = rightPointer - leftPointer;
                int currentArea = width * minHeight;

                if(currentArea > maxArea)
                {
                    maxArea = currentArea;
                }

            if (height[leftPointer] <= height[rightPointer])
            {
                leftPointer++;
            }
            else
            {
                rightPointer--;
            }
        }

        return maxArea;
    }

    static void Main(string[] args)
    {
        Solution solution = new Solution();
        Console.WriteLine(string.Join(", ", solution.MaxArea(new int[] { 2, 3, 4, 3, 2 })));
    }
}