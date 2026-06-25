public class Methods
{
    public static void Run()
    {
        ShowTitle();
        string name = GetStudentName();
        int age = GetAge();
        string college = GetCollege();
        double cgpa=GetCGPA();
        Display(name, age, college, cgpa);
        CheckResults(cgpa);
    }

    public static void ShowTitle()
    {
        Console.WriteLine("===============================");
        Console.WriteLine(" Student Management System");
        Console.WriteLine("===============================");
        Console.WriteLine();
        
    }

    public static string GetStudentName()
    {
        Console.Write("Enter Student Name: ");
        return Console.ReadLine();
    }

    private static int GetAge()
    {
        Console.Write("Enter Student Age: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    private static string GetCollege()
    {
        Console.Write("Enter College Name: ");
        return Console.ReadLine();
    }
    
    private static double GetCGPA()
    {
        Console.Write("Enter CGPA: ");
        return Convert.ToDouble(Console.ReadLine());
    }

    private static void Display(string name, int age, string college, double cgpa)

    {
        Console.WriteLine();
        Console.WriteLine("================================");
        Console.WriteLine(" Student Details");
        Console.WriteLine("================================");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"College: {college}");
        Console.WriteLine($"CGPA: {cgpa}");
    }

    private static void CheckResults(double cgpa)
    {
        if (cgpa >= 3.5)
        {
            Console.WriteLine("Result: Passed with Distinction");
        }
        else if (cgpa >= 2.0)
        {
            Console.WriteLine("Result: Passed");
        }
        else
        {
            Console.WriteLine("Result: Failed");
        }
    }
}