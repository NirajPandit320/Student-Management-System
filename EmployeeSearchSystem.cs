public class EmployeeSearchSystem
{
    public static void Run()
    {
        string[] employeeNames = {
            "John Doe",
            "Jane Smith",
            "Michael Johnson",
            "Emily Davis",
            "William Brown"
        };
        Console.Write("Enter the name of the employee to search for: ");
        string searched= Console.ReadLine();

        for(int i=0; i<employeeNames.Length;i++)
        {
            if(employeeNames[i].Equals(searched, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Employee found: {employeeNames[i]}");
                return;
            }
        }
        Console.WriteLine("Employee not found.");
    }

}