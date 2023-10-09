using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPT_1lab
{
    public class Lab_1
    {
        public static int MultiplyNonZeroValues(int[] v, int[] ind)
        {
            int result = 1;
            foreach (int index in ind)
            {
                if (index >= 0 && index < v.Length && v[index] != 0)
                {
                    result *= v[index];
                }
            }
            return result;
        }
        public static Tuple<int, int> FindMinValueAndIndex(int[] array)
        {
            int min = array[0];
            int minIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minIndex = i;
                }
            }

            return new Tuple<int, int>(min, minIndex);
        }
        public static void ReverseArray(double[] array)
        {
            Array.Reverse(array);
        }
    }

}
