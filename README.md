# Web Bán Hàng Cơ Bản - .NET MVC

Dự án này là một ứng dụng web bán hàng cơ bản được xây dựng bằng **.NET MVC**, cung cấp các tính năng cơ bản của một trang web thương mại điện tử. Mục tiêu của dự án là giúp người dùng có thể duyệt sản phẩm, thêm vào giỏ hàng, và tiến hành thanh toán.

## Ngôn Ngữ Công Nghệ Sử Dụng

- **.NET MVC (Model-View-Controller)**: Framework để phát triển ứng dụng web, với mô hình phân tách rõ ràng giữa dữ liệu, giao diện người dùng và xử lý logic.
- **C#**: Ngôn ngữ lập trình chính cho backend trong .NET.
- **HTML, CSS, JavaScript**: Dùng để xây dựng giao diện người dùng (frontend) và các tính năng động.
- **SQL Server**: Cơ sở dữ liệu lưu trữ thông tin sản phẩm, người dùng, và đơn hàng.
- **Bootstrap**: Framework CSS giúp thiết kế giao diện người dùng responsive, phù hợp với các thiết bị di động.

## Các Tính Năng

- **Hiển thị sản phẩm**: Trang chủ hiển thị danh sách sản phẩm, bao gồm tên, mô tả, giá cả và hình ảnh.
- **Giỏ hàng**: Người dùng có thể thêm sản phẩm vào giỏ hàng và điều chỉnh số lượng. Giỏ hàng sẽ được hiển thị tổng giá trị đơn hàng.
- **Thanh toán**: Sau khi xác nhận đơn hàng, người dùng có thể điền thông tin thanh toán và hoàn tất giao dịch.
- **Quản lý sản phẩm**: Quản trị viên có thể thêm, sửa, xóa sản phẩm trong hệ thống qua trang quản trị.
- **Đăng nhập và đăng ký người dùng**: Người dùng có thể tạo tài khoản và đăng nhập để quản lý thông tin cá nhân và lịch sử mua hàng.
- **Phân quyền**: Phân quyền account theo role Admin, Employee, Customer.
- **Lưu trữ đơn hàng**: Thông tin về đơn hàng của người dùng được lưu trữ trong cơ sở dữ liệu và có thể tra cứu lại.
  
## Cài Đặt và Sử Dụng

### Yêu Cầu Hệ Thống

- **.NET Framework** phiên bản 4.7 hoặc cao hơn
- **SQL Server** hoặc **SQL Server Express**

### Các Bước Cài Đặt

1. Clone repository về máy của bạn:
  git clone https://github.com/Yeder1/webC-.git
2. Mở dự án trong Visual Studio (hoặc IDE hỗ trợ .NET khác).

3. Cài đặt các gói cần thiết thông qua NuGet Package Manager trong Visual Studio.

4. Cấu hình kết nối cơ sở dữ liệu, chỉ định chuỗi kết nối đến SQL Server của bạn và sau đó chạy lệnh "update-database" trong Pakege Maneger Console.

5. Chạy ứng dụng từ Visual Studio bằng cách nhấn F5 hoặc chọn Start Debugging.

Truy cập ứng dụng qua trình duyệt tại http://localhost:xxxx (số cổng sẽ được hiển thị trong Visual Studio).

### Contributing
1. Fork repository này.

2. Tạo một nhánh mới (git checkout -b feature-branch).

3. Thực hiện thay đổi và commit (git commit -m 'Thêm tính năng mới').

4. Đẩy lên nhánh (git push origin feature-branch).

5. Mở Pull Request.
