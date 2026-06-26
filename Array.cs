public class EmployeeArray
{
    public static void Run()
    {
        // string[] employeeNames = {
        //     "John Doe",
        //     "Jane Smith",
        //     "Michael Johnson",
        //     "Emily Davis",
        //     "William Brown"
        // };

        // for(int i=0; i<employeeNames.Length; i++)
        // {
        //     Console.WriteLine($"Employee {i+1}: {employeeNames[i]}");
        // }

        // store marks of 5 students in an array
        // int [] studentsmarks={85, 92, 78, 96, 88};
        // for(int i=0; i<studentsmarks.Length; i++)
        // {
        //     Console.WriteLine($"Student {i+1}: {studentsmarks[i]}");
        // }

        //find the total marks of 5 students using array
        // int [] studentsmarks={85, 92, 78, 96, 88};
        // int totalMarks=0;
        // for (int i=0; i<studentsmarks.Length; i++)
        // {
        //     totalMarks+=studentsmarks[i];
        // }
        // Console.WriteLine($"Total Marks: {totalMarks}");

        int [] marks={85, 92, 78, 96, 88};
        int highestmark=marks[0];

        for(int i=0; i<marks.Length;i++)
        {
            if(marks[i]>highestmark)
            {
                highestmark=marks[i];
            }
        }
        Console.WriteLine($"Highest Mark: {highestmark}");
    }

}