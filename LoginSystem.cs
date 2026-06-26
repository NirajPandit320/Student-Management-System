public class Login
{
    public static void Run()
    {
        Console.Write("Enter the Name: ");
        string name = Console.ReadLine().Trim();
        Console.Write("Enter the Password: ");
        string password = Console.ReadLine();

        if(name.Equals("admin", StringComparison.OrdinalIgnoreCase) && password.Equals("admin123"))
        {
            Console.WriteLine("Login Successful!");
        }
        else
        {
            Console.WriteLine("Invalid Credentials. Please try again.");
        }
    }
    
}