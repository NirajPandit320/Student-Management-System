using System.Net.Http.Headers;

public class EmployeePoly
{

    public static void Run()
    {
        
        EmployeePoly employee = new EmployeePoly();
        EmployeePoly manager = new Manager();
        EmployeePoly developer = new Developer();
        EmployeePoly hr = new Hr();

        double CalculateSalary = employee.CalculateSalary();
        Console.WriteLine("Salary of Employee: " + CalculateSalary);

        double CalculateSalary1 = manager.CalculateSalary();
        Console.WriteLine("Salary of Manager: " + CalculateSalary1);

        double CalculateSalary2 = developer.CalculateSalary();
        Console.WriteLine("Salary of Developer: " + CalculateSalary2);
    }

    public virtual double CalculateSalary()
    {
            Console.WriteLine("===== EMPLOYEE DETAILS =====");
            Console.WriteLine("This is a base class for Employee");
            return 45000;
    }
    public void DisplayEmployee()
    {
        Console.WriteLine("===== EMPLOYEE DETAILS =====");
        Console.WriteLine("Salary of Manager: " + CalculateSalary());
        Console.WriteLine("Salary of Developer: " + CalculateSalary());
        Console.WriteLine("Salary of HR: " + CalculateSalary());
    }
}