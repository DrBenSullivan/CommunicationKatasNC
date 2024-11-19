//namespace Sorting
//{
//	public class SelectionSort : ISortable
//	{
//		public int[] Sort(int[] arrayToSort)
//		{
//			for (int i = 0; i < arrayToSort.Length - 1; i++)
//			{
//				int minimumIndex = i;
				
//				for (int j = i + 1; j < arrayToSort.Length; j++)
//				{
//					if (arrayToSort[j] < arrayToSort[minimumIndex])
//					{
//						minimumIndex = j;
//					}
//				}

//				if (minimumIndex != i)
//				{
//					int previousValue = arrayToSort[i];
//					arrayToSort[i] = arrayToSort[minimumIndex];
//					arrayToSort[minimumIndex] = previousValue;
//				}
//			}

//			return arrayToSort;
//		}
//	}
//}
