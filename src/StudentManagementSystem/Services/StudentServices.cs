using StudentManagementSystem.Interfaces;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Services;

public class StudentService : IRepository<Student>
{
    private readonly List<Student> students =
        new();

    public void Add(Student student)
    {
        students.Add(student);
    }

    public List<Student> GetAll()
    {
        return students;
    }

    public void Delete(int id)
    {
        var student =
            students.FirstOrDefault(
                s => s.StudentId == id);

        if (student != null)
        {
            students.Remove(student);
        }
    }

    public Student? FindStudent(int id)
    {
        return students.FirstOrDefault(
            s => s.StudentId == id);
    }
}