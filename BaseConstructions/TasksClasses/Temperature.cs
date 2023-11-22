using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConstructions.TasksClasses
{
    public static class Temperature
    {
        public static void Start()
        {
            Console.Clear();
            Console.WriteLine("/// Температура на улице - локальные максимумы и минимумы \\\\\\");
            int n;
            Dictionary<int[], string> MaxMin = new Dictionary<int[], string>();

            do
            {
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 3);

            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 1; i < n-1; i++)
            {
                if ( (nums[i-1] < nums[i] && nums[i] > nums[i+1]) || (nums[i-1] > nums[i] && nums[i] < nums[i+1]) )
                {
                    MaxMin.Add(new int[] {i+1, nums[i]}, nums[i] > nums[i-1] ? "(max)" : "(min)");
                }
            }

            foreach(var KeyValue in MaxMin)
            {
                Console.WriteLine($"day {KeyValue.Key[0]}: {KeyValue.Key[1]} {KeyValue.Value}");
            }
        }
    }
}
