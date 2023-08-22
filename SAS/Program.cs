using System.Net.NetworkInformation;

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
            Console.WriteLine("Unknown Activity");
        }

    }
    else
    {
        Console.WriteLine("Choice Unknown");
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
        Console.WriteLine("4 for set Exam schedule for a course");

        string TeacherActivity = Console.ReadLine();
        if (TeacherActivity == "1")
        {
            Console.WriteLine("===== Add a new Student ====");
            //add teacher 
            Console.WriteLine("Enter Student Name");
            string StdName = Console.ReadLine();
            Console.WriteLine("Enter Student Id");
            string StdId = Console.ReadLine();
            Console.WriteLine("Enter Student Activity");
            string StdStatus = Console.ReadLine();
            Console.WriteLine("Teacher Added with " + StdName + " and with salary of " + StdId + "Std Status" + StdStatus);
        }
        else if (TeacherActivity == "2")
        {
            Console.WriteLine("===== Add an Attendance report ====");
            //add teacher 
            Console.WriteLine("Enter Total Student");
            string CountStd = Console.ReadLine();
            Console.WriteLine("Enter Total Present Student");
            string CountPStd = Console.ReadLine();
            Console.WriteLine("Enter Total Absent Student");
            string CountAStd = Console.ReadLine();
            Console.WriteLine("Report of Attendance " + CountStd + " Present of " + CountPStd + "Absent of" + CountAStd);
        }
        else if (TeacherActivity == "3")
        {
            Console.WriteLine("===== Assigning Students  ====");
            //add teacher 
            Console.WriteLine("Enter Student Name");
            string StdName = Console.ReadLine();
            Console.WriteLine("Enter Student Id");
            string StdId = Console.ReadLine();
            Console.WriteLine("Assigning Course Id");
            string CourseId = Console.ReadLine();
            Console.WriteLine("Report of Attendance " + StdName + " Present of " + StdId + "Absent of" + CourseId);
        }
        else if (TeacherActivity == "4")
        {
            Console.WriteLine("===== Exam Schedule  ====");
            //add teacher 
            Console.WriteLine("Enter Course Name");
            string CId = Console.ReadLine();
            Console.WriteLine("Enter Mid Term Schedule");
            string XmMid = Console.ReadLine();
            Console.WriteLine("Enter Final Term Schedule");
            string XmFinal = Console.ReadLine();
            Console.WriteLine("Exam Schedule " + CId + " Mid Term will take " + XmMid + "Final Term Will Take" + XmFinal);
        }
        else
        {
            Console.WriteLine("Unknown Activity");
        }
    }
    else
    {
        Console.WriteLine("Choice Unknown");
    }
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

    if (SUserId == SUserName && SInputpassword == SPassword)
    {
        Console.WriteLine("Welcome Student");
        Console.WriteLine("Please enter your choice");
        Console.WriteLine("1 for Give Attendance");
        Console.WriteLine("2 for doing Exam");
        Console.WriteLine("3 for Extra Curriculum Activity");

        string StudentActivity = Console.ReadLine();

        if (StudentActivity == "1")
        {
            Console.WriteLine("===== Give Attendance ====");
            //add teacher 
            Console.WriteLine("Enter Student Name");
            string StdName = Console.ReadLine();
            Console.WriteLine("Present Plz");
            string StdActivity = Console.ReadLine();
            Console.WriteLine("Present Status");
            string SPstatus = Console.ReadLine();

            Console.WriteLine("Attendance Query " + StdName + " Presnt  " + StdActivity + " Yes/No " + SPstatus);

        }
        else if (StudentActivity == "2")
        {

            Console.WriteLine("===== Doing Exam ====");
            //add teacher 
            Console.WriteLine("Enter Course Name");
            string CName = Console.ReadLine();
            Console.WriteLine("Exam Type");
            string XmType = Console.ReadLine(); // CT, MId, Final
            Console.WriteLine("Attendance");
            string Pstatus = Console.ReadLine(); // Yes or No

            Console.WriteLine("Exam Query " + CName + " Presnt  " + XmType + " Yes/No " + Pstatus);
        }

        else if (StudentActivity == "3")
        {

            Console.WriteLine("===== Student Extra Curriculum Activity ====");
            //add teacher 
            Console.WriteLine("Enter Extra Curriculum Activity");
            string EName = Console.ReadLine();
            Console.WriteLine("Extra Curriculum ActivityType");
            string EType = Console.ReadLine(); // Expert, Moderate

            Console.WriteLine("Extra Curriculum Activity Query " + EName + " Type or Position  " + EType);
        }
    }
    else
    {
        Console.WriteLine("Choice Unknown");
    }
}
else
    {
        Console.WriteLine("Login unsuccessfull");
    }
