using week2day5.Models;

namespace week2day5.Services;

public class TodoService
{
    private readonly List<Todo> _todos = new();
    private int _nextId = 1;

    // Thêm công việc
    public void Add(string title)
    {
        var todo = new Todo
        {
            Id = _nextId++,
            Title = title,
            IsCompleted = false
        };
        _todos.Add(todo);
        Console.WriteLine("✅ Đã thêm công việc!\n");
    }

    // Xem tất cả công việc
    public void ViewAll()
    {
        if (_todos.Count == 0)
        {
            Console.WriteLine("⚠️ Chưa có công việc nào.\n");
            return;
        }

        Console.WriteLine("📋 Danh sách công việc:");
        foreach (var todo in _todos)
        {
            Console.WriteLine(todo);
        }
        Console.WriteLine();
    }

    // Cập nhật công việc
    public void Update(int id, string newTitle)
    {
        var todo = _todos.FirstOrDefault(t => t.Id == id);
        if (todo == null)
        {
            Console.WriteLine("❌ Không tìm thấy công việc!\n");
            return;
        }

        todo.Title = newTitle;
        Console.WriteLine("✏️ Đã cập nhật công việc!\n");
    }

    // Xoá công việc
    public void Delete(int id)
    {
        var todo = _todos.FirstOrDefault(t => t.Id == id);
        if (todo == null)
        {
            Console.WriteLine("❌ Không tìm thấy công việc!\n");
            return;
        }

        _todos.Remove(todo);
        Console.WriteLine("🗑️ Đã xoá công việc!\n");
    }

    // Đánh dấu hoàn thành / chưa xong
    public void ToggleStatus(int id)
    {
        var todo = _todos.FirstOrDefault(t => t.Id == id);
        if (todo == null)
        {
            Console.WriteLine("❌ Không tìm thấy công việc!\n");
            return;
        }

        todo.IsCompleted = !todo.IsCompleted;
        Console.WriteLine("🔄 Đã cập nhật trạng thái!\n");
    }

    // Lọc theo trạng thái
    public void Filter(bool isCompleted)
    {
        var list = _todos.Where(t => t.IsCompleted == isCompleted).ToList();
        if (!list.Any())
        {
            Console.WriteLine("⚠️ Không có công việc nào phù hợp.\n");
            return;
        }

        Console.WriteLine("📂 Danh sách lọc:");
        foreach (var todo in list)
        {
            Console.WriteLine(todo);
        }
        Console.WriteLine();
    }
}