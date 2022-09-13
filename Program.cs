using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[8] { 2, -14, 5, 86, 43, 12, -54, 7 };

            int[] numbers = QuickSort(nums, 0, nums.Length - 1);

            Console.WriteLine($"Sorted array:{string.Join(", ",numbers)}");

            Console.ReadLine();
        }


        static int[] QuickSort(int[] array , int minIndex,int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            int pivot = FindPivot(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivot-1);
            QuickSort(array, pivot + 1, maxIndex);
            return array;
        }

       static int FindPivot(int[] nums, int minIndex,int maxIndex) 
        {
            int pivot = minIndex - 1;
            int temp = 0;
         

            for(int i = minIndex; i < maxIndex; i++)
            {
                if (nums[i] < nums[maxIndex])
                {
                    pivot++;
                    temp = nums[pivot];
                    nums[pivot] = nums[i];
                    nums[i] = temp;
                    
                }
               

            }
            pivot++;
            temp = nums[pivot];
            nums[pivot] = nums[maxIndex];
            nums[maxIndex] = temp; 
            return pivot;
        }
    }
}
