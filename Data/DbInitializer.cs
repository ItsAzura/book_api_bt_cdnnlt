using BookApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BookApi.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            // Đảm bảo database được tạo
            context.Database.EnsureCreated();

            // Kiểm tra xem có dữ liệu sẵn trong bảng Books không
            if (context.Books.Any())
            {
                return; // Database đã có dữ liệu, không cần seed
            }

            // Thêm dữ liệu mẫu
            var books = new Book[]
            {
                new Book { Title = "Đắc Nhân Tâm" },
                new Book { Title = "Nhà Giả Kim" },
                new Book { Title = "Tôi Tài Giỏi, Bạn Cũng Thế" },
                new Book { Title = "Người Giàu Có Nhất Thành Babylon" },
                new Book { Title = "Đọc Vị Bất Kỳ Ai" }
            };

            context.Books.AddRange(books);
            context.SaveChanges();
        }
    }
} 