public interface ISortable<T>
{
	public T[] Sort(T[] arrayToSort, IComparer<T> comparer);
}
