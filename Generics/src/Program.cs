using System;
using System.Collections.Generic;

namespace Generics;

public class Program
{
    public static void Main(string[] args)
    {
        Store<Student> studentStore = new();

        studentStore.Add(new Student(1, "Ahmad"));
        studentStore.Add(new Student(2, "Omar"));
        studentStore.Add(new Student(3, "Sara"));
        studentStore.Add(new Student(4, "Lina"));
        studentStore.Add(new Student(5, "Yousef"));

        Store<Course> courseStore = new();

        courseStore.Add(new Course(101, "C#", 100));
        courseStore.Add(new Course(102, "OOP", 120));
        courseStore.Add(new Course(103, "Generics", 150));

        Student? student = studentStore.GetById(3);

        if (student != null)
        {
            Console.WriteLine(
                $"Student: {student.Id} - {student.Name}"
            );
        }

        Course? course = courseStore.GetById(102);

        if (course != null)
        {
            Console.WriteLine(
                $"Course: {course.Id} - {course.Title} - {course.Price}"
            );
        }

        try
        {
            studentStore.Add(new Student(3, "Duplicate Student"));
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }

        Console.WriteLine();
        Console.WriteLine("Page 2 of students:");

        IEnumerable<Student> secondPage =
            studentStore.GetAll().Values.Page(2, 2);

        foreach (Student item in secondPage)
        {
            Console.WriteLine($"{item.Id} - {item.Name}");
        }

        Console.WriteLine();
        Console.WriteLine("Find course by ID:");

        List<Course> courses = new()
        {
            new Course(201, "Clean Code", 90),
            new Course(202, "Design Patterns", 130),
            new Course(203, "Data Structures", 110)
        };

        Course? foundCourse = courses.FindById(202);

        if (foundCourse != null)
        {
            Console.WriteLine(
                $"{foundCourse.Id} - {foundCourse.Title} - {foundCourse.Price}"
            );
        }

        // Store<string> badStore = new(); // must NOT compile
    }
}