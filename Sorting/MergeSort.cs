namespace Sorting
{
	public class MergeSort<T> : ISortable<T>
	{
		private static int currentSubarraySize = 1;

		public T[] Sort(T[] arrayToSort, IComparer<T> comparer)
		{
			if (arrayToSort.Length == 1) return arrayToSort;

			int middleIndex = arrayToSort.Length / 2;
			
			var left = new ArraySegment<T>(arrayToSort, 0, middleIndex);
			var right = new ArraySegment<T>(arrayToSort, middleIndex, arrayToSort.Length - middleIndex);

			left = new ArraySegment<T>(Sort(left.ToArray(), comparer));
			right = new ArraySegment<T>(Sort(right.ToArray(), comparer));

			return Merge(left.ToArray(), right.ToArray(), comparer);
        }

		private T[] Merge(T[] left, T[] right, IComparer<T> comparer)
		{
			var leftQueue = new Queue<T>(left);
			var rightQueue = new Queue<T>(right);
			List<T> result = [];

			while (leftQueue.Count > 0 && rightQueue.Count > 0)
			{
				int comparison = comparer.Compare(leftQueue.Peek(), rightQueue.Peek());

				T element = comparison <= 0 ? leftQueue.Dequeue() : rightQueue.Dequeue();

				result.Add(element);
			}

			while (leftQueue.Count > 0)
			{
				result.Add(leftQueue.Dequeue());
			}

			while (rightQueue.Count > 0)
			{
				result.Add(rightQueue.Dequeue());
			}

			return result.ToArray();
		}
	}
}
