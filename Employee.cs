namespace Classes
{
    public class Employee
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Title { get; set; }

        public DateTime StartDate { get; set; }

        public Employee() {

        }

        public Employee(string fName, string lName, string jobTitle, DateTime firstDay) 
        {
            FirstName = fName;
            LastName = lName;
            Title = jobTitle;
            StartDate = firstDay;

        }
    }

}