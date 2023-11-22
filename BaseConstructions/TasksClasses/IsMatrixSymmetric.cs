using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConstructions.TasksClasses
{
    public static class IsMatrixSymmetric
    {
        public static void Start()
        {
            Console.Clear();
            Console.WriteLine("/// Симметрична ли матрица? \\\\\\");
            int n;
            bool trigger = true;
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
            } while (n > 100 || n < 0);


            int[,] nums = new int[n,n];

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    nums[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < n && trigger; i++)
            {
                for (int j = 0; j < n && trigger; j++)
                {
                    if (!(nums[i,j] == nums[j,i]))
                    {
                        trigger = false;
                    }
                }
            }

            Console.WriteLine(trigger ? "YES" : "NO");
        }
    }
}
