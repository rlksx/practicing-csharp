using System;
class Program
{
    public static void Main(string[] args)
    {
        int[] nums = {3, 6, 1, 12, 13, 5, 4, 7, 10, 14, 2};
        var rnd = new Random();
        int target = rnd.Next(1, 15);
        // Console.WriteLine(target);

        int result = binarySearch(nums, target);
        if(result == -1) {
            Console.WriteLine($"O numero {target} não está na lista!");
        } else
        {
            Console.WriteLine($"O numero {result} está na lista");
        }
    }

    static int binarySearch(int[] nums, int target)
    {
        // nums = nums.OrderBy(x => x).ToArray();
        Array.Sort(nums);

        int low = 0;
        int height = nums.Length - 1;
        int middle = 0;

        while(low <= height)
        {
            middle = (low + height)/2;
            if(target == nums[middle])
            {
                return nums[middle];
            } else if (target < nums[middle])
            {
                height = middle - 1;
            } else {
                low = middle + 1;
            }
        }
        return target == nums[low] ? nums[low] : -1;
    }
}