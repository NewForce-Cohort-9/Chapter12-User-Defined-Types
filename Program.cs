using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test");
            // Create an instance of a company. Name it whatever you like.
            Company myCompany = new Company("Newforce", new DateTime(2020, 4, 1, 9, 0, 0));
            // Create three employees
            Employee employee1 = new Employee()
            {
                FirstName = "Mike",
                LastName = "Adkins",
                Title = "Photographer",
                StartDate = new DateTime(2020, 4, 2, 9, 0, 0)
            };

            Employee employee2 = new Employee("Ruston", "Seaman", "Manager", new DateTime(2020, 4, 3, 9, 0, 0));
            Employee employee3 = new Employee("Brooke", "Pardue", "Communications Manager", DateTime.Now);

            // Assign the employees to the company
            myCompany.employees.Add(employee1);
            myCompany.employees.Add(employee2);
            myCompany.employees.Add(employee3);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            //"Jane Doe works for Acme, Inc. as Lion Tamer since 3/23/15."

             myCompany.ListEmployees();


        }
    }
}