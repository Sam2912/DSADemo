using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSADemo.Sorting
{
  public class BubbleSortDemo
  {
    public void BubbleSort(int[] array)
    {
      var n = array.Length;

      for (int i = 0; i < n - 1; i++)
      {
        for (int j = 0; j < n - 1 - i; j++)
        {
          //swapping
          if (array[j] > array[j + 1])
          {
            var temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;

          }
        }
      }

      for (int i = 0; i < n; i++)
      {
        Console.WriteLine(array[i]);
      }
    }
    public void Test()
    {
      int[] array = { 7, 6, 5, 1 };
      int target = 4;

      // Call the function and get the result
      var result = FindDifference(array, target);

      if (result != null)
      {
        Console.WriteLine($"Numbers found: {result[0]} and {result[1]}");
      }
      else
      {
        Console.WriteLine("No such numbers found.");
      }
    }

    public decimal[] TwoSum(int[] nums, decimal target)
    {
      Dictionary<decimal, int> indices = new Dictionary<decimal, int>();

      for (int i = 0; i < nums.Length; i++)
      {
        decimal diff = target + nums[i];
        if (indices.ContainsKey(diff))
        {
          System.Console.WriteLine(diff);
          System.Console.WriteLine(nums[i]);
          return new decimal[] { indices[diff], i };
        }
        indices[nums[i]] = i;
      }
      return null;
    }

    static int[] FindDifference(int[] nums, int target)
    {
       var numDict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = nums[i] - target;

            if (numDict.ContainsKey(complement))
            {
                return new int[] { nums[i], complement };
            }

            numDict[nums[i]] = i; // Store the number with its index
        }

        return null; // No numbers found
    }
  }
}