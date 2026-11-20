using System; // Provides Console.WriteLine for displaying text.

namespace EmployeeQuittable
{
    // Defines the behavior required of any object that can quit.
    public interface IQuittable
    {
        // Declares a method that takes no arguments and returns no value.
        void Quit();
    }

    // Represents an employee who can quit.
    public class Employee : IQuittable
    {
        // Stores the employee's name.
        public string Name { get; }

        // Sets the employee's name when the object is created.
        public Employee(string name)
        {
            Name = name;
        }

        // Implements IQuittable by displaying a resignation message.
        public void Quit()
        {
            Console.WriteLine($"{Name} has quit.");
        }
    }

    // Contains the console application's entry point.
    internal static class Program
    {
        private static void Main()
        {
            // Create an Employee and hold it in an IQuittable variable.
            IQuittable employee = new Employee("Alex Morgan");

            // Call through the interface. The runtime runs Employee.Quit().
            employee.Quit();
        }
    }
}
