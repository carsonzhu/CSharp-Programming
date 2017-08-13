using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wrox.ProCSharp.Delegates
{
    class BubbleSorter
    {

        static public void Sort<T>(IList<T> sortArray, Func<T, T, bool> comparison)
        {
            //冒泡排序的思想：重复遍历数组，比较每一对数字，交换位置，从而把最大或者最小的数字逐步移动到数组的最后！
            bool swapped = true;
            do
            {
                swapped = false;
                for (int i = 0; i < sortArray.Count - 1; i++)
                {
                    if (comparison(sortArray[i+1], sortArray[i]))
                    {
                        T temp = sortArray[i];
                        sortArray[i] = sortArray[i + 1];
                        sortArray[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);

       
        }
    }

}
