# WINFORM_QLKS
VUHO_DEV
1.3.1 Quản lý Phòng
● Mục tiêu: Theo dõi thông tin phòng, trạng thái sử dụng, và tình trạng vệ sinh.
● Quy trình:
1. Nhập thông tin phòng: Loại phòng, giá phòng, số lượng giường.
2. Cập nhật trạng thái phòng: Checkin,Checkout.
3. Tìm kiếm và liệt kê phòng theo tiêu chí: Loại phòng, giá tiền, trạng thái.
1.3.2 Quản lý Đặt phòng
● Mục tiêu: Quản lý các đơn đặt phòng từ khách hàng.
● Quy trình:
1. Tiếp nhận yêu cầu đặt phòng: Thông tin khách hàng, số lượng phòng, thời
gian đặt.
2. Kiểm tra tình trạng phòng khả dụng: Dựa trên thông tin phòng đã được
quản lý.
3. Lập và lưu thông tin đặt phòng: Mã đặt phòng, thông tin khách hàng, thời
gian nhận/trả phòng, tiền cọc.
4. Cập nhật trạng thái phòng: Chuyển trạng thái từ Trống sang Đã đặt.
1.3.3 Quản lý Khách hàng
● Mục tiêu: Theo dõi thông tin khách hàng để hỗ trợ tốt hơn và lưu trữ lịch sử giao
dịch.
● Quy trình:
1. Đăng ký thông tin khách hàng: Họ tên, số điện thoại, email, địa chỉ.
2. Quản lý hồ sơ khách hàng: Lưu lịch sử đặt phòng,điểm thưởng (nếu có
chương trình khách hàng thân thiết).

8

3. Tra cứu thông tin khách hàng: Tìm kiếm khách hàng theo mã khách hàng
hoặc thông tin cá nhân.
1.3.4 Quản lý Nhân viên
● Mục tiêu: Thêm ,Xóa và thông tin chi tiết nhân viên để quản lý hệ thống khi sử
dụng hệ thống
● Quy trình:
1. Thêm mới và cập nhật thông tin nhân viên: Họ tên, SDT,giới tính,Email
2. Quản lý tài khoản nhân viên trong việc sử dụng hệ thống
1.3.5 Tích hợp quy trình
Các phân hệ trên liên kết chặt chẽ với nhau:
● Trạng thái phòng trong phân hệ Quản lý Phòng được cập nhật tự động từ Quản lý
Đặt phòng.
● Hồ sơ khách hàng trong Quản lý Khách hàng được tạo hoặc cập nhật khi có giao
dịch đặt phòng.
● Nhân viên trong Quản lý thông tin nhân viên và tài khoản để sử dụng dịch vụ
