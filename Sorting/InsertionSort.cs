//namespace Sorting
//{
//	public class InsertionSort : ISortable
//	{
//		public int[] Sort(int[] arrayToSort)
//		{
//			for (int i = 1; i < arrayToSort.Length; i++)
//			{
//				int current = arrayToSort[i];

//				for (int j = i - 1; j >= 0; j--)
//				{
//					if (arrayToSort[j] < current)
//					{
//						int previous = arrayToSort[j + 1];
//						arrayToSort[j + 1] = arrayToSort[j];
//						arrayToSort[j] = previous;
//						break;
//					}
//				}
//			}

//			return arrayToSort;
//		}
//	}
//}
