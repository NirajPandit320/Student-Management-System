public class Developer:EmployeePoly
{
    public override double CalculateSalary()
    {
        Console.WriteLine("===== DEVELOPER DETAILS =====");
        Console.WriteLine("This is a derived class for Developer");
        return 50000;
    }
}