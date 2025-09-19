using week2day5.Services;

namespace week2day5;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        var service = new TodoService();
        int choice;

        do
        {
            Console.WriteLine("===== TODO LIST APP =====");
            Console.WriteLine("1. Thêm công việc");
            Console.WriteLine("2. Xem tất cả công việc");
            Console.WriteLine("3. Cập nhật công việc");
            Console.WriteLine("4. Xoá công việc");
            Console.WriteLine("5. Đánh dấu hoàn thành / chưa xong");
            Console.WriteLine("6. Lọc công việc theo trạng thái");
            Console.WriteLine("0. Thoát");
            Console.Write("👉 Chọn: ");
            choice = int.Parse(Console.ReadLine() ?? "0");

            switch (choice)
            {
                case 1:
                    Console.Write("Nhập tên công việc: ");
                    string title = Console.ReadLine() ?? "";
                    service.Add(title);
                    break;

                case 2:
                    service.ViewAll();
                    break;

                case 3:
                    Console.Write("Nhập Id công việc cần sửa: ");
                    int updateId = int.Parse(Console.ReadLine() ?? "0");
                    Console.Write("Tên mới: ");
                    string newTitle = Console.ReadLine() ?? "";
                    service.Update(updateId, newTitle);
                    break;

                case 4:
                    Console.Write("Nhập Id công việc cần xoá: ");
                    int deleteId = int.Parse(Console.ReadLine() ?? "0");
                    service.Delete(deleteId);
                    break;

                case 5:
                    Console.Write("Nhập Id công việc cần đổi trạng thái: ");
                    int toggleId = int.Parse(Console.ReadLine() ?? "0");
                    service.ToggleStatus(toggleId);
                    break;

                case 6:
                    Console.Write("Nhập trạng thái (1 = Hoàn thành, 0 = Chưa xong): ");
                    int status = int.Parse(Console.ReadLine() ?? "0");
                    service.Filter(status == 1);
                    break;

                case 0:
                    Console.WriteLine("👋 Tạm biệt!");
                    break;

                default:
                    Console.WriteLine("⚠️ Lựa chọn không hợp lệ!\n");
                    break;
            }

        } while (choice != 0);
    }
}