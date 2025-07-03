using System;
class Program
{
    static void Main()
    {

        /*Ctrl + F5 -> Start without debugging 
         Shift + F5 -> Stop Debugging
         
        Shift + F9 -> Watch Window
        Ctrl + Alt + I -> Immediate Window
        Ctrl + Shift + F10 -> Set Next Statement / right click on the line which you want to set next statement and select set next statement option


        F10 -> Step Over
        F10 -> Step In(Goes to the Method Defination(into the method)
         */

        string empDetails = getEmpNameByDesignation("Divya");
        Console.WriteLine(empDetails);

    }

    static string getAlexDetails()
    {
        string designation = "Alex is a Software Engineer";
        return designation;
    }


    static string getJustinDetails()
    {
        string designation = "Justin is a Trainee Software Engineer";
        return designation;
    }

    static string getEmpNameByDesignation(string empName)
    {
        string empDetails = "";
        string managerName = "Mohan";

        if (empName == "Alex")
        {
            empDetails = getAlexDetails();
            empDetails = string.Concat(empDetails, "Alex DOB is 12-12-1993");
            empDetails = string.Concat(empDetails, "\nManager is " + managerName);
        }
        else if (empName == "Justin")
        {
            empDetails = getJustinDetails();
            empDetails = string.Concat(empDetails, "Justin DOB is 15-03-1998");
            empDetails = string.Concat(empDetails, "\nManager is " + managerName);

        }
        else
        {
            empDetails = "No Employee Found";
        }
        return empDetails;

    }




}






    //// PrintFirstCheckPont();
    //string empDetails = getEmpName();
    //Console.WriteLine(empDetails);

    //string empDetails1 = getEmpName1();
    //Console.WriteLine(empDetails1);

    //string getAlexdetails = getAlexDetails();
    //Console.WriteLine(getAlexdetails);



    //    static void PrintFirstCheckPont()
    //    {
    //        Console.WriteLine("*************CheckPoint-1************");
    //        string empName = "Alex";
    //        int age = 35;
    //        double salary = 45000.23d;
    //        Console.WriteLine($"Showing the data before Check Point 2: {empName}, {age}, {salary}");

    //        Console.WriteLine("*************CheckPoint-2************");
    //        string empDesignation = "Software Engineer";
    //        string DOB = "05-06-1994";
    //        Console.WriteLine($"Showing the data before Check Point 3: {empDesignation}, {DOB}");

    //        Console.WriteLine("*************CheckPoint-3*************");
    //        int[] ID = { 1101, 1102, 1103 };
    //        string[] bankNames = { "HDFC", "AXIS", "ICICI" };
    //        Console.WriteLine("You are at the End of Checkpoints");
    //        string empLocation = Console.ReadLine();
    //    }
    //static string getEmpName()
    //{
    //    string empName = "Alex";
    //    return empName;
    //}
    //static string getEmpName1()
    //{
    //    string empName1 = "Justin";
    //    return empName1;
    //}






