namespace Tests.csharp7
{
	public readonly struct Person
	{
		public string Name { get; set; }

		public string Surname { get; set; }

		public int Age { get; set; }

		public Person(string name, string surname, int age)
		{
			Name = name;
			Surname = surname;
			Age = age;
		}

		public void Replace(Person other)
		{
			this = other;
		}
	}
}