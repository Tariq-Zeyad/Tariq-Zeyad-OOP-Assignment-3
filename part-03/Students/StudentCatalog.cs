namespace RefactoringLab.Part03.Students;



public static class StudentCatalog
{
    public static IEnumerable<Student> GetAllStudents()
    {
        for (var i = 1; i <= 1_000_000; i++)
        {
            yield return new Student
            {
                Id = i,
                Name = $"Student {i}"
            };
        }
    }
}