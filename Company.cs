using System;

namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string? Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> employees = new List<Employee>();
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */

        public Company(string name, DateTime dateCreated)
        {
            Name = name;
            CreatedOn = dateCreated;
        }

        public void ListEmployees()
        {
            employees.ForEach(currentEmployee =>
            {
                Console.WriteLine(
                    $"{currentEmployee.FirstName} {currentEmployee.LastName} works for {Name} as {currentEmployee.Title} since {currentEmployee.StartDate.ToShortDateString()}");
            });

        }

    }
}