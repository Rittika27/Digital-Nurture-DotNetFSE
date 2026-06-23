Student student = new() { Id = 1, Name = "Alice", Grade = "A" };
StudentView view = new();
StudentController controller = new(student, view);

controller.UpdateView();

controller.SetName("Alice Johnson");
controller.SetGrade("A+");
controller.UpdateView();
