namespace ConsoleApp1
{
    // class declaration
    public class Person
    {
        // fields
        public Person(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string   EmailAddress { get; set; }


        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public int GetAge()
        {
            return (int)(DateTime.Now - this.BirthDate).TotalDays/365
        }
        public bool IsAdult()
        {
            return this.GetAge() >= 18;
        }
    }

}
