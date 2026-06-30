public class Manager:EmployeePoly
{
    public override double CalculateSalary()
    {
        Console.WriteLine("===== MANAGER DETAILS =====");
        Console.WriteLine("This is a derived class for Manager");
        return 70000;
    }
}