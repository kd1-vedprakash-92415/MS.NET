namespace College.StudentInfo
{
    class Student
    {
        public void ShowDetails()
        {
            Console.WriteLine("ShowDetails from CollegeStudentInfo");
        }
    }
}
namespace School.StudentInfo
{
    class Student
    {
        public void ShowDetails()
        {
            Console.WriteLine("ShowDeatils from SchoolStudentsInfo");
        }
    }
}

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            College.StudentInfo.Student C = new College.StudentInfo.Student();
            C.ShowDetails();
            School.StudentInfo.Student S = new School.StudentInfo.Student();
            S.ShowDetails();
        }
    }
}