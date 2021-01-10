namespace Tests.csharp7
{
	public readonly struct Person
	{
		private protected readonly object syncObj;
		
		public string Name { get; }

		public string Surname { get; }

		public int Age { get; }

		public Person(string name, string surname, int age)
		{
			Name = name;
			Surname = surname;
			Age = age;
		}
    }
}