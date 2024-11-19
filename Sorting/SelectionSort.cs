namespace Sorting
{
	public class SelectionSort<T> : ISortable<T>
	{
		public T[] Sort(T[] arrayToSort, IComparer<T> comparer)
		{
			for (int i = 0; i < arrayToSort.Length - 1; i++)
			{
				int minimumIndex = i;

				for (int j = i + 1; j < arrayToSort.Length; j++)
				{
					int comparison = comparer.Compare(arrayToSort[j], arrayToSort[minimumIndex]);
					if (comparison < 0)
					{
						minimumIndex = j;
					}
				}

				if (minimumIndex != i)
				{
					T previousValue = arrayToSort[i];
					arrayToSort[i] = arrayToSort[minimumIndex];
					arrayToSort[minimumIndex] = previousValue;
				}
			}

			return arrayToSort;
		}
	}
}
