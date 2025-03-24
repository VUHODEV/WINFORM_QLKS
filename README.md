Quản Lý Khách Sạn - WinForms

Giới thiệu

Dự án Quản Lý Khách Sạn được phát triển bằng WinForms (C#) giúp quản lý thông tin khách sạn, bao gồm:

Quản lý phòng

Đặt phòng

Quản lý khách hàng

Quản lý nhân viên

Quản lý hóa đơn và thanh toán

Tính năng chính

🎯 Quản lý phòng

Mục tiêu: Theo dõi thông tin phòng, trạng thái sử dụng, và tình trạng vệ sinh.

Quy trình:

Nhập thông tin phòng: Loại phòng, giá phòng, số lượng giường.

Cập nhật trạng thái phòng: Check-in, Check-out.

Tìm kiếm và liệt kê phòng theo tiêu chí: Loại phòng, giá tiền, trạng thái.

🏨 Quản lý đặt phòng

Mục tiêu: Quản lý các đơn đặt phòng từ khách hàng.

Quy trình:

Tiếp nhận yêu cầu đặt phòng: Thông tin khách hàng, số lượng phòng, thời gian đặt.

Kiểm tra tình trạng phòng khả dụng.

Lập và lưu thông tin đặt phòng: Mã đặt phòng, thông tin khách hàng, thời gian nhận/trả phòng, tiền cọc.

Cập nhật trạng thái phòng: Chuyển từ Trống sang Đã đặt.

👤 Quản lý khách hàng

Mục tiêu: Theo dõi thông tin khách hàng để hỗ trợ tốt hơn và lưu trữ lịch sử giao dịch.

Quy trình:

Đăng ký thông tin khách hàng: Họ tên, số điện thoại, email, địa chỉ.

Quản lý hồ sơ khách hàng: Lưu lịch sử đặt phòng, điểm thưởng (nếu có chương trình khách hàng thân thiết).

Tra cứu thông tin khách hàng: Tìm kiếm theo mã khách hàng hoặc thông tin cá nhân.

👨‍💼 Quản lý nhân viên

Mục tiêu: Quản lý thông tin nhân viên để kiểm soát hệ thống.

Quy trình:

Thêm mới và cập nhật thông tin nhân viên: Họ tên, SĐT, giới tính, email.

Quản lý tài khoản nhân viên trong hệ thống.

🔄 Tích hợp quy trình

Các phân hệ trên liên kết chặt chẽ với nhau:

Trạng thái phòng trong Quản lý Phòng được cập nhật tự động từ Quản lý Đặt phòng.

Hồ sơ khách hàng trong Quản lý Khách hàng được tạo hoặc cập nhật khi có giao dịch đặt phòng.

Nhân viên trong Quản lý Nhân viên có quyền sử dụng hệ thống theo phân quyền.

Công nghệ sử dụng

Ngôn ngữ: C# (WinForms)

Cơ sở dữ liệu: SQL Server

Giao diện: Windows Forms UI Framework

Hướng dẫn cài đặt

1️⃣ Clone repository

git clone https://github.com/VUHODEV/WINFORM_QLKS.git
cd WINFORM_QLKS

2️⃣ Cấu hình cơ sở dữ liệu

Import file database.sql vào SQL Server

Cập nhật chuỗi kết nối trong app.config

3️⃣ Chạy ứng dụng

Mở project bằng Visual Studio

Build & Run (F5)

Đóng góp

📌 Nếu bạn muốn đóng góp, hãy fork repo, tạo branch mới và gửi pull request.

Liên hệ

📩 Email: your_email@example.com
💻 GitHub: github.com/VUHODEV
