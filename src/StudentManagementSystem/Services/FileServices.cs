using StudentManagementSystem.Models;

namespace StudentManagementSystem.Services;

public static class FileService
{
    public static void SaveStudents(
        string path,
        List<Student> students)
    {
        var directory = Path.GetDirectoryName(path);

        if (!string.IsNullOrEmpty(directory))
        {
            Directory.CreateDirectory(directory);
        }

        var lines = students.Select(
            s => $"{s.StudentId},{s.Name},{s.Age},{s.Course}");

        File.WriteAllLines(path, lines);
    }

    public static List<Student> LoadStudents(
        string path)
    {
        var students = new List<Student>();

        if (!File.Exists(path))
            return students;

        foreach (var line in File.ReadAllLines(path))
        {
            var data = line.Split(',');

            students.Add(
                new Student(
                    int.Parse(data[0]),
                    data[1],
                    int.Parse(data[2]),
                    data[3]));
        }

        return students;
    }
}