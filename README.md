# Book API

API quản lý sách sử dụng ASP.NET Core và PostgreSQL.

## Tính năng

- REST API đầy đủ (CRUD) cho quản lý sách
- Sử dụng Entity Framework Core với PostgreSQL
- Docker và Docker Compose
- Seed data tự động
- Swagger UI cho testing API

## Công nghệ

- ASP.NET Core 6.0
- Entity Framework Core
- PostgreSQL
- Docker & Docker Compose
- Swagger/OpenAPI

## Cách chạy

### Sử dụng Docker Compose (Khuyến nghị)

```bash
docker-compose up
```

Ứng dụng sẽ khởi chạy tại http://localhost:8080/swagger

### Phát triển trên máy local (Cần PostgreSQL)

1. Cài đặt PostgreSQL và tạo database `bookstore_db`
2. Cập nhật connection string trong `appsettings.json` nếu cần
3. Chạy ứng dụng:

```bash
dotnet run
```

## Cấu trúc API

- `GET /api/Books` - Lấy danh sách tất cả sách
- `GET /api/Books/{id}` - Lấy thông tin chi tiết của một cuốn sách
- `POST /api/Books` - Thêm sách mới (chỉ cần gửi title)
- `PUT /api/Books/{id}` - Cập nhật thông tin sách (chỉ cần gửi title)
- `DELETE /api/Books/{id}` - Xóa sách

## Ví dụ request

### Tạo sách mới (POST)

```json
POST /api/Books
{
  "title": "Tên sách mới"
}
```

### Cập nhật sách (PUT)

```json
PUT /api/Books/1
{
  "title": "Tên sách đã cập nhật"
}
```
