namespace Sorting
{
	public class BubbleSort<T> : ISortable<T>
	{
		public T[] Sort(T[] arrayToSort, IComparer<T> comparer)
		{
			bool isListSorted = true;

			for (int i = 0; i < arrayToSort.Length - 2; i++)
			{
				T currentValue = arrayToSort[i];
				T nextValue = arrayToSort[i + 1];

				int comparison = comparer.Compare(currentValue, nextValue);
				if (comparison > 0)
				{
					isListSorted = false;
					arrayToSort[i] = nextValue;
					arrayToSort[i + 1] = currentValue;
				}
			}

			if (isListSorted) return arrayToSort;

			return Sort(arrayToSort, comparer);
		}
	}
}
