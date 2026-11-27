namespace StudentManagementSystem.Models;

public class Course
{
    public string CourseCode { get; set; }
    public string CourseName { get; set; }

    public Course(string code, string name)
    {
        CourseCode = code;
        CourseName = name;
    }
}