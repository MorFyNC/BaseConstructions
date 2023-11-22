using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConstructions.TasksClasses
{
    public static class OppositeElements
    {
        public static void Start()
        {
            Console.Clear();
            Console.WriteLine("/// Противоположные элементы \\\\\\");
            int n;
            bool trigger = true;
            
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
            } while (n > 100 || n < 0);

            int[] nums = new int[n];

            for (int i = 0; i < n; i++) 
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n && trigger; i++)
            {
                for (int j = 0; j < n && trigger; j++)
                {
                    if (nums[i] + nums[j] == 0)
                    {
                        Console.WriteLine($"{i} {j}");
                        trigger = false;
                    }
                }
            }
        }
    }
}
