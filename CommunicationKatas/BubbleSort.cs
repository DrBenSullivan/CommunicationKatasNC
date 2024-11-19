namespace CommunicationKatas
{
	public class BubbleSort
	{
		public int[] Sort(int[] listToSort)
		{
			bool isListSorted = true;

			for (int i = 0; i < listToSort.Length - 2; i++)
			{
				int currentValue = listToSort[i];
				int nextValue = listToSort[i + 1];

				if (currentValue > nextValue)
				{
					isListSorted = false;
					listToSort[i] = nextValue;
					listToSort[i + 1] = currentValue;
				}
			}

			if (isListSorted) return listToSort;

			return (Sort(listToSort));
		}
	}
}
