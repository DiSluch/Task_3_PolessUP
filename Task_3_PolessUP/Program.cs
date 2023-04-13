using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_PolessUP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива:");
            int n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];

            Console.WriteLine("Введите элементы массива:");

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Введите целевое значение:");
            int targ = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (nums[i] == targ)
                {
                    Console.WriteLine($"Индекс: {i}");
                }
                else
                {
                    if ((i != 0) && (nums[i] < nums[i-1]))
                    {
                        int savNam = nums[i-1];
                        nums[i - 1] = nums[i];
                        nums[i] = savNam;
                        int v = i -2;
                        i = v;
                    }
                }

            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(nums[i]);
            }
            Console.ReadKey();
        }
    }
}
