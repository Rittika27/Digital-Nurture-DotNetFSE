public class TaskItem
{
    public int TaskId { get; set; }
    public string TaskName { get; set; } = string.Empty;
    public string Status { get; set; } = "Pending";
    public TaskItem? Next { get; set; }

    public override string ToString() => $"[{TaskId}] {TaskName} | {Status}";
}

public class TaskLinkedList
{
    private TaskItem? _head;

    // O(1)
    public void Add(TaskItem task)
    {
        task.Next = _head;
        _head = task;
        Console.WriteLine($"Added task: {task.TaskName}");
    }

    // O(n)
    public TaskItem? Search(int id)
    {
        var curr = _head;
        while (curr != null) { if (curr.TaskId == id) return curr; curr = curr.Next; }
        return null;
    }

    // O(n)
    public void Traverse()
    {
        var curr = _head;
        while (curr != null) { Console.WriteLine(curr); curr = curr.Next; }
    }

    // O(n)
    public void Delete(int id)
    {
        if (_head == null) return;
        if (_head.TaskId == id) { _head = _head.Next; Console.WriteLine($"Deleted task ID {id}"); return; }
        var curr = _head;
        while (curr.Next != null)
        {
            if (curr.Next.TaskId == id) { curr.Next = curr.Next.Next; Console.WriteLine($"Deleted task ID {id}"); return; }
            curr = curr.Next;
        }
        Console.WriteLine($"Task {id} not found.");
    }
}
