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
