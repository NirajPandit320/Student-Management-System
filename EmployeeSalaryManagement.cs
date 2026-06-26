public class EmployeeSalaryManagement
{
    public static void Run()
    {
        ShowTitle();
        int employeeId=GetEmployeeId();
        string employeeName=GetEmployeeName();
        string department=GetDepartment();
        int salary=GetSalary();
        double bonus=GetBonus();

        double totalSalary=TotalSalary(bonus,salary);
        double taxAmount=TaxAmount(totalSalary);
        double netSalary=NetSalary(totalSalary,taxAmount);

        ShowEmployeeDetails(employeeId,employeeName,department,salary,bonus,totalSalary,taxAmount,netSalary);

    }

    private static void ShowTitle()
    {
        Console.WriteLine("=========================================");
        Console.WriteLine("      EMPLOYEE SALARY MANAGEMENT");
        Console.WriteLine("=========================================");
        Console.WriteLine();
    }
    private static int GetEmployeeId()
    {
        Console.Write("Enter Employee ID: ");
        return Convert.ToInt32(Console.ReadLine());
        
    }
        private static string GetEmployeeName()
    {
        Console.Write("Enter Employee Name: ");
        return Console.ReadLine();
    }

        private static string GetDepartment()
    {
        Console.Write("Enter Employee Department: ");
        return Console.ReadLine();
        
    }

        private static int GetSalary()
    {
        Console.Write("Enter Employee Salary: ");
        return Convert.ToInt32(Console.ReadLine());
        
    }
        private static double GetBonus()
    {
        Console.Write("Enter Employee Bonus: ");
        return Convert.ToDouble(Console.ReadLine());
        
    }

    //Calculations 

    private static double TotalSalary(double bonus, int salary)
    {
        return bonus + salary;
    }
    private static double TaxAmount(double totalSalary)
    {
        return totalSalary * 0.1;
    }
    private static double NetSalary(double totalSalary, double taxAmount)
    {
        return totalSalary - taxAmount;
    }

    // Show 

    public static void ShowEmployeeDetails(int employeeId, string employeeName, string department, int salary, double bonus, double totalSalary, double taxAmount, double netSalary)
    {
        Console.WriteLine("=========================================");
        Console.WriteLine("      EMPLOYEE DETAILS");
        Console.WriteLine("=========================================");
        Console.WriteLine($"Employee ID: {employeeId}");
        Console.WriteLine($"Employee Name: {employeeName}");
        Console.WriteLine($"Department: {department}");
        Console.WriteLine($"Salary: {salary}");
        Console.WriteLine($"Bonus: {bonus}");
        Console.WriteLine($"Total Salary: {totalSalary}");
        Console.WriteLine($"Tax Amount: {taxAmount}");
        Console.WriteLine($"Net Salary: {netSalary}");
    }
}