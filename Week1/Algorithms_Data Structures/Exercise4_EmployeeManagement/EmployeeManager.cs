public class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;
    public double Salary { get; set; }

    public override string ToString() =>
        $"[{EmployeeId}] {Name} | {Position} | ${Salary}";
}

public class EmployeeManager
{
    private Employee?[] _employees;
    private int _count = 0;

    public EmployeeManager(int capacity) => _employees = new Employee[capacity];

    // O(1)
    public void Add(Employee e)
    {
        if (_count < _employees.Length) { _employees[_count++] = e; Console.WriteLine($"Added: {e.Name}"); }
        else Console.WriteLine("Array full.");
    }

    // O(n)
    public Employee? Search(int id)
    {
        for (int i = 0; i < _count; i++)
            if (_employees[i]?.EmployeeId == id) return _employees[i];
        return null;
    }

    // O(n)
    public void Traverse() { for (int i = 0; i < _count; i++) Console.WriteLine(_employees[i]); }

    // O(n)
    public void Delete(int id)
    {
        for (int i = 0; i < _count; i++)
            if (_employees[i]?.EmployeeId == id)
            {
                _employees[i] = _employees[--_count];
                _employees[_count] = null;
                Console.WriteLine($"Deleted employee ID {id}");
                return;
            }
        Console.WriteLine($"Employee {id} not found.");
    }
}
