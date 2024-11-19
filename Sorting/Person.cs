namespace Sorting
{
	public class Person
	{
		public int Id { get; set; }
		public float Height { get; set; }
		public int Age { get; set; }
	}

	public class HeightComparison : Comparer<Person>
	{
		public override int Compare(Person? x, Person? y)
		{
			if (x == null && y == null) return 0;
			if (x == null) return -1;
			if (y == null) return 1;

			return x.Height.CompareTo(y.Height);
		}
	}

	public class AgeComparison : Comparer<Person>
	{
		public override int Compare(Person? x, Person? y)
		{
			if (x == null && y == null) return 0;
			if (x == null) return -1;
			if (y == null) return 1;

			return x.Age.CompareTo(y.Age);
		}
	}

	public class IdComparison : Comparer<Person>
	{
		public override int Compare(Person? x, Person? y)
		{
			if (x == null && y == null) return 0;
			if (x == null) return -1;
			if (y == null) return 1;

			return x.Id.CompareTo(y.Id);
		}
	}
}
