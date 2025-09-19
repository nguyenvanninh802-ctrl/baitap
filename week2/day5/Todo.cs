namespace week2day5.Models;

public class Todo
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public bool IsCompleted { get; set; }

    public override string ToString()
    {
        return $"[{Id}] {Title} - {(IsCompleted ? "✅ Hoàn thành" : "⌛ Chưa xong")}";
    }
}