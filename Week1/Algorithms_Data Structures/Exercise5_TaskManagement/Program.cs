TaskLinkedList list = new();
list.Add(new TaskItem { TaskId = 1, TaskName = "Design DB schema", Status = "Done"    });
list.Add(new TaskItem { TaskId = 2, TaskName = "Build REST API",   Status = "Pending" });
list.Add(new TaskItem { TaskId = 3, TaskName = "Write unit tests", Status = "Pending" });

Console.WriteLine("\n-- All Tasks --");
list.Traverse();

var t = list.Search(2);
Console.WriteLine($"\nSearch ID 2: {t}");

list.Delete(2);
Console.WriteLine("\n-- After Delete --");
list.Traverse();

/*
 * Time Complexity:
 *   Add      : O(1)
 *   Search   : O(n)
 *   Traverse : O(n)
 *   Delete   : O(n)
 * Linked lists are better than arrays for frequent insertions/deletions.
 */
