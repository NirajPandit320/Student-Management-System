public class Operators
{
    public static void Run()
    {

        // Arithmetic Operators in C#
        int a=10;
        int b=5;

        int sum=a+b;
        int difference=a-b;
        int product=a*b;
        double devide=a/b;
        int remainder=a%b;

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {difference}");
        Console.WriteLine($"Product: {product}");
        Console.WriteLine($"Division: {devide}");
        Console.WriteLine($"Remainder: {remainder}");

        int hour=165;
        int hourspay=45;

        double totalpay=hour*hourspay;
        Console.WriteLine($"Total Pay: {totalpay}");

        double yearlypay=totalpay*12;
        Console.WriteLine($"Yearly Pay: {yearlypay}");


        double tax=yearlypay*0.2;
        Console.WriteLine($"Tax: {tax}");

        double takehomepay=yearlypay-tax;
        Console.WriteLine($"Take Home Pay: {takehomepay}");

        //Assignment Operators in C#
        Console.Write("Enter your salary: ");
        int salary=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Salary: {salary+=5000}"); // this will add 5000 to salary and assign it to salary
        Console.WriteLine($"Salary: {salary-=2000}"); // this will subtract 2000 from salary and assign it to salary
        Console.WriteLine($"Salary: {salary*=2}"); // this will multiply salary by 2 and assign it to salary
        Console.WriteLine($"Salary: {salary/=2}"); // this will divide salary by 2 and assign it to salary
        Console.WriteLine($"Salary: {salary%=3}"); // this will divide salary by 3 and assign the remainder to salary

        // Logical Operators in C#
        
        // AND 


        int age=2;
        bool isEmployed=true;
        Console.WriteLine($"Is eligible for loan:{age>10 && isEmployed}");
        if (age>18 && isEmployed)
        {
            Console.WriteLine("Eligible for loan");
        }else
        {
            Console.WriteLine("Not Eligible for loan");
        }

    }
}