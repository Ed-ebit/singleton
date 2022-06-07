//In software engineering, the singleton pattern is a software design pattern that restricts the instantiation
//of a class to one "single" instance.
//This is useful when exactly one object is needed to coordinate actions across the system.using System;
//https://en.wikipedia.org/wiki/Singleton_pattern

namespace singleton
{
    class Program
    {
        public static void Main()
        {
            Parallel.Invoke(()=>Studentdetails(),
                            ()=>EmployeeDetails());
        }

        private static void EmployeeDetails()
        {
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("fromStudent zweite Testmessage");
        }

        private static void Studentdetails()
        {
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("from Employee Testmessage");
        }
    }
}
