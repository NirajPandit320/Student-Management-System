public class ConditionalStatement
{
    public static void Run()
    {
        
        //Lesson -4 Conditional Statements in C#

        Console.Write("Enter your age: ");
        int age=int.Parse(Console.ReadLine());
        if (age>=18)
        {
            Console.WriteLine("You are eligible to vote");
        }
        else
        {
            Console.WriteLine("You are not eligible to vote");
        }

        //if-else if-else statement in C#

        Console.Write("Enter your marks: ");
        int marks=int.Parse(Console.ReadLine());
        if (marks>=90)
        {
            Console.WriteLine("You got A grade");
        }
        else if (marks>=80)
        {
            Console.WriteLine("You got B grade");
        }
        else if (marks>=70)
        {
            Console.WriteLine("You got C grade");
        }
        else if (marks>=60)
        {
            Console.WriteLine("You got D grade");
        }
        else
        {
            Console.WriteLine("You got F grade");
        }

        Console.Write("Enter performance rating (1-5): ");
        int rating = int.Parse(Console.ReadLine()); 
        if(rating==5)
        {
            Console.WriteLine("Bonus 20% of salary");
        }
        else if(rating==4)
        {
            Console.WriteLine("Bonus 10% of salary");
        }
        else if(rating==3)
        {
            Console.WriteLine("Bonus 5% of salary");
        }
        else if(rating==2)
        {
            Console.WriteLine("No bonus");
        }
        else if(rating==1)
        {
            Console.WriteLine("Penalty 5% of salary");
        }
        else
        {
            Console.WriteLine("Invalid rating");
        }

        //Nested if

        // int age=25;
        // bool hasId=true;
        // if (age>=18)
        // {
        //     if (hasId)
        //     {
        //         Console.WriteLine("You are allowed to enter the club");
        //     }
        //     else
        //     {
        //         Console.WriteLine("You are not allowed to enter the club");
        //     }
        // }

        //switch case statement in C#


        Console.Write("Enter Department ");
        string department=Console.ReadLine();

        switch (department.ToUpper())
        {
            case "IT":
                Console.WriteLine("You are in IT department");
                break;
            case "HR":
                Console.WriteLine("You are in HR department");
                break;
            case "Finance":
                Console.WriteLine("You are in Finance department");
                break;
            default:
                Console.WriteLine("Invalid department");
                break;
        }
    }
}