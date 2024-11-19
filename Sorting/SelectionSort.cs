using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Sorting
{
    //change
    public class SelectionSort : ISortable
    {
        public int[] Sort(int[] arrayToSort)
        {
            List<int> unsortedList = new List<int>(arrayToSort);
            List<int> sortedList = new List<int>();

            while (unsortedList.Count > 0)
            {
                int smallestInt = unsortedList.Min();
                sortedList.Add(smallestInt);
                unsortedList.Remove(smallestInt);
            }

            return sortedList.ToArray();
        }
    }
}
