namespace Task6
{
    public class Person
    {
        public Person() { }
        public Person(string name, string lastName, string city, int age)
        {
            Name = name;
            LastName = lastName;
            City = city;
            Age = age;
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public int Age { get; set; }        
    }
}
