using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining
{
    public static class Sort
    {
        public static void Bubble(int[] arr)
        {
            for (var i = 0; i < arr.Length - 1; i++)
            {
                for (var j = 0; j < arr.Length - (1 + i); j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static void Selection(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int jMin = i;



                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[jMin])
                    {
                        jMin = j;
                    }
                }

                if (jMin != i)
                {
                    var temp = arr[i];
                    arr[i] = arr[jMin];
                    arr[jMin] = temp;
                }
            }
        }

        public static void Insertion(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        public static int[] MergeSort(int[] arr)
        {
            if (arr.Length <= 1) return arr;

            decimal midpoint = arr.Length / 2;
            var mid = Convert.ToInt32(Math.Ceiling(midpoint));

            var bot = arr.Take(mid).ToArray();
            var top = arr.Skip(mid).ToArray();

            var botOut = MergeSort(bot);
            var topOut = MergeSort(top);

            var Combined = Combine(botOut, topOut);

            return Combined;
        }

        private static int[] Combine(int[] bottom, int[] top) //Example
        {
            var i = 0;
            var j = 0;
            var k = 0;
            var arr = new int[bottom.Length + top.Length];

            while (i < bottom.Length && j < top.Length)
            {
                if(bottom[i] < top[j])
                {
                    arr[k] = bottom[i];
                    i++;
                }
                else
                {
                    arr[k] = top[j];
                    j++;
                }
                k++;
            }
            while (i < bottom.Length)
            {
                arr[k] = bottom[i];
                i++;
                k++;
            }
            while (j < top.Length)
            {
                arr[k] = top[j];
                j++;
                k++;
            }
            return arr;
        }
    }
}

