namespace Sorting
{
	public class InsertionSort<T> : ISortable<T>
	{
		public T[] Sort(T[] arrayToSort, IComparer<T> comparer)
		{
			for (int i = 1; i < arrayToSort.Length; i++)
			{
				T current = arrayToSort[i];

				for (int j = i - 1; j >= 0; j--)
				{
					int comparison = comparer.Compare(arrayToSort[j], current);

					if (comparison < 0)
					{
						T previous = arrayToSort[j + 1];
						arrayToSort[j + 1] = arrayToSort[j];
						arrayToSort[j] = previous;
						break;
					}
				}
			}

			return arrayToSort;
		}
	}
}
