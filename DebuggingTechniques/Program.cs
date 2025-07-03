using System;
 class Program
{
    static void Main()
    {
        PrintFirstCheckPont();
        
    }
    static void PrintFirstCheckPont()
    {
        Console.WriteLine("*************CheckPoint-1************");
        string empName = "Alex";
        int age = 35;
        double salary = 45000.23d;
        Console.WriteLine($"Showing the data before Check Point 2: {empName}, {age}, {salary}");

        Console.WriteLine("*************CheckPoint-2************");
        string empDesignation = "Software Engineer";
        string DOB = "05-06-1994";
        Console.WriteLine($"Showing the data before Check Point 3: {empDesignation}, {DOB}");

        Console.WriteLine("*************CheckPoint-3************");
        int[] ID = { 1101, 1102, 1103 };
        string[] bankNames = { "HDFC", "AXIS", "ICICI" };
        Console.WriteLine("You are at the End of Checkpoints");
        string empLocation = Console.ReadLine();
    }
}