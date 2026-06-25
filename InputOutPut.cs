
public class InputOutPut
{
    public static void Run()
    {

            //Lesson -2 taking input from user in C#

            // Console.Write("Enter your name: ");
            // string name = Console.ReadLine(); // ReadLine() method takes only string
            // Console.WriteLine($"Name: {name}");

            // Console.Write("Enter your City: ");
            // string city=Console.ReadLine();
            // Console.WriteLine($"City: {city}");

            //Lesson -2.1 taking input from user in C# with different data types

            Console.Write("Enter your age: ");
            int age=Convert.ToInt32(Console.ReadLine()); // ReadLine() method takes only string so we need to convert it into int
            Console.WriteLine($"Age is : {age}");

            Console.Write("Enter your salary: ");
            double salary=Convert.ToDouble(Console.ReadLine()); // ReadLine() method takes only string so we need to convert it into double
            Console.WriteLine($"Salary is : {salary}");

            Console.Write("Enter your grade: ");
            char grade=Convert.ToChar(Console.ReadLine()); // ReadLine() method takes only string so we need to convert it into char
            Console.WriteLine($"Grade is : {grade}");

            Console.Write("Are you employed? (true/false): ");
            bool isEmployed=Convert.ToBoolean(Console.ReadLine()); // ReadLine() method takes only string so we need to convert it into bool
            Console.WriteLine($"Is Employed: {isEmployed}");

                    
    }
}