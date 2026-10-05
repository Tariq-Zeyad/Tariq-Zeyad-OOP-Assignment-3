using System.Collections.Generic;

namespace Generics;

public class StudentStore
{
    private readonly List<Student> students = new();

    public void Add(Student student)
    {
        students.Add(student);
    }

    public Student? GetById(int id)
    {
        foreach (Student student in students)
        {
            if (student.Id == id)
            {
                return student;
            }
        }

        return null;
    }

    public IReadOnlyList<Student> GetAll()
    {
        return students;
    }

    public void Remove(int id)
    {
        for (int i = 0; i < students.Count; i++)
        {
            if (students[i].Id == id)
            {
                students.RemoveAt(i);
                return;
            }
        }
    }
}
