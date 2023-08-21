Console.WriteLine("please enter login type");
Console.WriteLine("Enter 1 for admin, 2 for teacher, 3 for student");
string userChoice = Console.ReadLine();

if (userChoice == "1")
{
    string adminUserName = "admin";
    string adminPassword = "admin";
    //
    Console.WriteLine("Please login");
    Console.WriteLine("Enter Username");
    string inputUserId = Console.ReadLine();

    Console.WriteLine("Enter Password");
    string inputpassword = Console.ReadLine();
    // inputUserId ebong inputpassword kono database er user tbl er mile kina!
    if (inputUserId == adminUserName && inputpassword == adminPassword)
    {
        Console.WriteLine("Welcome Admin");
        Console.WriteLine("Please enter your choice");
        Console.WriteLine("1 for create teacher");
        Console.WriteLine("2 for create course");
        Console.WriteLine("3 for create student");
        Console.WriteLine("4 for report: attendance check");
        Console.WriteLine("5 for assign teacher in a cousre");
        Console.WriteLine("6 for assign student in a course");
        Console.WriteLine("7 for set class schedule for a course");

        string adminActivity = Console.ReadLine();
        if (adminActivity == "1")
        {
            Console.WriteLine("===== Add a new Teacher ====");
            //add teacher 
            Console.WriteLine("Enter Teacher Name");
            string techerName = Console.ReadLine();
            Console.WriteLine("Enter Teacher Salary");
            string teacherSalary = Console.ReadLine();
            Console.WriteLine("Teacher Added with " + techerName + " and with salary of " + teacherSalary);
        }
        else if (adminActivity == "2")
        {
            Console.WriteLine("===== Add a new Course ====");
            //add teacher 
            Console.WriteLine("Enter Course Name");
            string CourseName = Console.ReadLine();
            Console.WriteLine("Enter Course Credit");
            string CourseCredit = Console.ReadLine();
            Console.WriteLine("Teacher Added Course :< " + CourseName + " >:and Credit of " + CourseCredit);//add a course
        }
        else if (adminActivity == "3")
        {
            //add student
            Console.WriteLine("===== Add a Student for a Course ====");

            Console.WriteLine("Enter Student Name");
            string StdName = Console.ReadLine();
            Console.WriteLine("Enter Student Id:");
            string StdId = Console.ReadLine();
            Console.WriteLine("CourseName:");
            string CourseName = Console.ReadLine();


            Console.WriteLine("Teacher Added a Student of Name: " + StdName + ", Id: " + StdId + ", TakenCourse: " + CourseName);

        }
        else if (adminActivity == "4")
        {
            //add Attandance Report
            Console.WriteLine("===== Add a report of Attendance ====");

            Console.WriteLine("Enter A Student Name");
            string StdName = Console.ReadLine();
            Console.WriteLine("Enter Student Id:");
            string StdId = Console.ReadLine();
            Console.WriteLine("Enter Date");
            string Date = Console.ReadLine();
            Console.WriteLine("Enter ClassTime:");
            string ClassTime = Console.ReadLine();
            Console.WriteLine("Status:");
            string Status = Console.ReadLine();

            Console.WriteLine("AttendanceReport of a Student Name: " + StdName + ", Id: " + StdId + ", Date: " + Date + ", ClassTime: " + ClassTime + "Status:" + Status);

        }
        else if (adminActivity == "5")
        {
            //add Attandance Report
            Console.WriteLine("===== Assigning teacher in a cousre ====");

            Console.WriteLine("Faculty Name");
            string FName = Console.ReadLine();
            Console.WriteLine("Enter Faculty Id:");
            string FId = Console.ReadLine();
            Console.WriteLine("Assign New Course");
            string Course = Console.ReadLine();
            Console.WriteLine("Total Course:");
            string TCourses = Console.ReadLine();
            Console.WriteLine("Position:");
            string Position = Console.ReadLine();

            Console.WriteLine("Assigning New Teacher Name: " + FName + ", Id: " + FId + ", TotalCourses: " + TCourses + ",Status:" + Position);
        }
        else if (adminActivity == "6")
        {
            //add Attandance Report
            Console.WriteLine("===== Assigning Student in a cousre ====");

            Console.WriteLine("Student Name");
            string SName = Console.ReadLine();
            Console.WriteLine("Enter Student Id:");
            string SId = Console.ReadLine();
            Console.WriteLine("Assign New Course");
            string Course = Console.ReadLine();
            Console.WriteLine("Total Course:");
            string TCourses = Console.ReadLine();
            Console.WriteLine("Course Faculty Name:");
            string FName = Console.ReadLine();

            Console.WriteLine("Assigning New Student of Name: " + SName + "StdID:" + SId + "TotalCourse:" + TCourses + ", UnderFaculty of: " + FName);
        }
        else if (adminActivity == "7")
        {

            Console.WriteLine("===== Class Schedule for courses ====");

            Console.WriteLine("Enter Day");
            string DName = Console.ReadLine();
            Console.WriteLine("Enter ClassName");
            string CName = Console.ReadLine();
            Console.WriteLine("Enter Class Time");
            string CTime = Console.ReadLine();
            Console.WriteLine("Class Taken By");
            string FName = Console.ReadLine();


            Console.WriteLine("Class Scedule Details: " + DName + "Class Name:" + CName + "Timing:" + CTime + ", Class Taken By: " + FName);
        }

        else
        {
            Console.WriteLine("Login unsuccessfull");
        }
    }
    
    else if (userChoice == "2")
    {
        string TUserName = "teacher";
        string TPassword = "1234";
        Console.WriteLine("Please login");
        Console.WriteLine("Enter Username");
        string TUserId = Console.ReadLine();

        Console.WriteLine("Enter Password");
        string TInputpassword = Console.ReadLine();

        if (TUserId == TUserName && TInputpassword == TPassword)
        {
            Console.WriteLine("Welcome Teacher");
            Console.WriteLine("Please enter your choice");
            Console.WriteLine("1 for create student");
            Console.WriteLine("2 for report: attendance check");
            Console.WriteLine("3 for assign student in a course");
            Console.WriteLine("4 for set class schedule for a course");

            string Activity = Console.ReadLine();

        }
        else if (userChoice == "3")
        {
            string SUserName = "student";
            string SPassword = "12345";
            Console.WriteLine("Please login");
            Console.WriteLine("Enter Username");
            string SUserId = Console.ReadLine();

            Console.WriteLine("Enter Password");
            string SInputpassword = Console.ReadLine();

            if (TUserId == SUserName && TInputpassword == SPassword)
            {
                Console.WriteLine("Welcome Student");
                Console.WriteLine("Please enter your choice");
                Console.WriteLine("1 for Give Attendance");
                Console.WriteLine("2 for doing Exam");

                string Activity = Console.ReadLine();

            }

        }
        else
        {
            Console.WriteLine("Choice unknow");
        }
    }
}