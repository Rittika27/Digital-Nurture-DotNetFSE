EmployeeManager mgr = new(10);
mgr.Add(new Employee { EmployeeId = 1, Name = "Alice", Position = "Engineer",   Salary = 90000 });
mgr.Add(new Employee { EmployeeId = 2, Name = "Bob",   Position = "Manager",    Salary = 110000 });
mgr.Add(new Employee { EmployeeId = 3, Name = "Carol", Position = "Analyst",    Salary = 75000 });

Console.WriteLine("\n-- All Employees --");
mgr.Traverse();

var emp = mgr.Search(2);
Console.WriteLine($"\nSearch ID 2: {emp}");

mgr.Delete(2);
Console.WriteLine("\n-- After Delete --");
mgr.Traverse();

/*
 * Time Complexity:
 *   Add      : O(1)
 *   Search   : O(n)
 *   Traverse : O(n)
 *   Delete   : O(n)
 */
