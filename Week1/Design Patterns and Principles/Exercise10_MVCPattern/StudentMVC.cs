public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Grade { get; set; } = string.Empty;
}

public class StudentView
{
    public void DisplayStudentDetails(string name, int id, string grade) =>
        Console.WriteLine($"Student -> ID: {id}, Name: {name}, Grade: {grade}");
}

public class StudentController
{
    private readonly Student _student;
    private readonly StudentView _view;

    public StudentController(Student student, StudentView view)
    {
        _student = student;
        _view = view;
    }

    public void SetName(string name) => _student.Name = name;
    public void SetGrade(string grade) => _student.Grade = grade;
    public void UpdateView() => _view.DisplayStudentDetails(_student.Name, _student.Id, _student.Grade);
}
