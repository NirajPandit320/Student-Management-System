public class Hr:EmployeePoly
{
    public override double CalculateSalary()
    {
        Console.WriteLine("===== HR DETAILS =====");
        Console.WriteLine("This is a derived class for HR");
        return 60000;
    }
}