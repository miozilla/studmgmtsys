namespace StudentManagementSystem.Models;

public class Student : Person
{
    public int StudentId { get; set; }
    public string Course { get; set; }

    public Student(
        int studentId,
        string name,
        int age,
        string course)
        : base(name, age)
    {
        StudentId = studentId;
        Course = course;
    }

    public override void Display()
    {
        Console.WriteLine("----- Student -----");
        Console.WriteLine($"ID     : {StudentId}");
        Console.WriteLine($"Name   : {Name}");
        Console.WriteLine($"Age    : {Age}");
        Console.WriteLine($"Course : {Course}");
    }
}