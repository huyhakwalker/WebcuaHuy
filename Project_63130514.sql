create database Project_63130514
go
use Project_63130514
drop database Project_63130514
go
CREATE TABLE MonAn (
    MaMonAn INT PRIMARY KEY IDENTITY(1,1),
    TenMonAn NVARCHAR(255) NOT NULL,
    Gia int NOT NULL,
	AnhMonAn varchar(50) not null,
    MoTa NVARCHAR(255) not null,
    LoaiMonAn NVARCHAR(50) not null
);

INSERT INTO MonAn (TenMonAn, Gia, AnhMonAn, MoTa, LoaiMonAn) VALUES 
(N'Bún riêu cua', 50000, 'MONAN1.PNG', N'Món ăn truyền thống Việt Nam', N'Món chính'),
(N'Phở bò', 75000, 'MONAN2.PNG', N'Món phở ngon tuyệt', N'Món chính'),
(N'Gà nướng muối ớt',150000, 'MONAN3.PNG',  N'Gà nướng cay cay thơm phức', N'Món chính'),
(N'Bánh mì chảo', 35000, 'MONAN4.PNG', N'Bánh mì nóng hổi thơm ngon', N'Món ăn nhẹ'),
(N'Cơm gà Hải Nam',30000, 'MONAN5.PNG',  N'Cơm gà đặc trưng của Hải Nam', N'Món chính'),
(N'Bún chả Hà Nội',50000, 'MONAN6.PNG',  N'Bún chả thơm ngon của Hà Nội', N'Món chính'),
(N'Bánh xèo Miền Trung',40000, 'MONAN7.PNG',  N'Bánh xèo hấp dẫn Miền Trung', N'Món chính'),
(N'Chả cá Lã Vọng', 60000, 'MONAN8.PNG', N'Chả cá nổi tiếng Hà Nội', N'Món chính'),
(N'Bún bò Huế', 45000, 'MONAN9.PNG', N'Bún bò đặc sản của Huế', N'Món chính'),
(N'Bánh cuốn', 30000, 'MONAN10.PNG', N'Bánh cuốn mỏng nhẹ thơm ngon', N'Món ăn nhẹ'),
(N'Cá kho tộ', 100000, 'MONAN11.PNG', N'Món cá kho tộ ngon miệng', N'Món chính'),
(N'Rau muống xào tỏi', 30000, 'MONAN12.PNG', N'Rau muống xào thơm ngon', N'Món phụ'),
(N'Bò né', 55000, N'MONAN13.PNG', 'Bò né sườn ngon hấp dẫn', N'Món chính'),
(N'Cơm rang dưa bò', 50000, 'MONAN14.PNG', N'Cơm rang thơm ngon', N'Món phụ'),
(N'Bún mắm', 80000, 'MONAN15.PNG', N'Bún mắm thơm ngon', N'Món chính'),
(N'Gỏi cuốn', 350000, 'MONAN16.PNG', N'Gỏi cuốn hấp dẫn', N'Món ăn nhẹ'),
(N'Nước mía', 15000, 'MONAN17.PNG', N'Nước mía tươi ngon', N'Đồ uống'),
(N'Sinh tố dừa', 20000, 'MONAN18.PNG', N'Sinh tố dừa thơm ngon', N'Đồ uống'),
(N'Trà đào', 25000, 'MONAN19.PNG', N'Trà đào mát lạnh', N'Đồ uống'),
(N'Bia', 20000, 'MONAN20.PNG', N'Bia lạnh ngon', N'Đồ uống'),
(N'Cà phê sữa đá', 25000, 'MONAN21.PNG', N'Cà phê sữa đá thơm ngon', N'Đồ uống'),
(N'Hamburger', 50000, 'MONAN22.PNG', N'Bữa ăn nhanh phong cách Mỹ', N'Món chính'),
(N'Salad trộn', 25000, 'MONAN23.PNG', N'Salad tươi ngon', N'Món phụ'),
(N'Súp cua', 45000, 'MONAN24.PNG', N'Súp cua nóng hổi', N'Món chính'),
(N'Cá viên chiên', 45000, 'MONAN25.PNG', N'Cá viên chiên giòn', N'Món ăn nhẹ'),
(N'Pizza', 250000, 'MONAN26.PNG', N'Pizza Ý thơm ngon', N'Món chính'),
(N'Bò cuộn phô mai', 85000, 'MONAN27.PNG', N'Bò cuộn phô mai hấp dẫn', N'Món chính'),
(N'Chả giò', 40000, 'MONAN28.PNG', N'Chả giò giòn thơm', N'Món ăn nhẹ'),
(N'Nem cuốn',20000, 'MONAN29.PNG', N'Nem cuốn thanh mát', N'Món ăn nhẹ'),
(N'Chè thập cẩm', 18000, 'MONAN30.PNG', N'Chè thập cẩm ngọt ngào', N'Tráng miệng'),
(N'Gà quay lu', 180000, 'MONAN31.PNG', N'Gà quay lu ngon giòn sần sật', N'Món chính'),
(N'Mì ý', 75000, 'MONAN32.PNG', N'Đặc sản nước Ý', N'Món chính'),
(N'Pizza đặc biệt', 300000, 'MONAN33.PNG', N'Pizza siêu siêu đặc biệt', N'Món chính');

-- Tạo bảng KhachHang
CREATE TABLE KhachHang (
    MaKhachHang INT PRIMARY KEY IDENTITY(1,1),
	Taikhoan varchar(20) not null,
	Matkhau varchar(50) not null,
    TenKhachHang NVARCHAR(255) NOT NULL,
    SoDienThoai VARCHAR(10) not null,
    Email VARCHAR(255) not null,
    DiaChi NVARCHAR(255) not null
);

INSERT INTO KhachHang (Taikhoan, Matkhau, TenKhachHang, SoDienThoai, Email, DiaChi) VALUES 
('taikhoan1', 'matkhau1', N'Nguyễn Văn A', '0123456789', 'nvanA@email.com', N'123 Đường ABC, Quận XYZ'),
('taikhoan2', 'matkhau2', N'Trần Thị B', '0987654321', 'tthiB@email.com', N'456 Đường XYZ, Quận ABC'),
('taikhoan3', 'matkhau3', N'Lê Văn C', '0369852147', 'lvanC@email.com', N'789 Đường LMN, Quận XYZ'),
('taikhoan4', 'matkhau4', N'Phạm Thị D', '0123456788', 'pthiD@email.com', N'101 Đường PQR, Quận LMN'),
('taikhoan5', 'matkhau5', N'Trương Văn E', '0987654322', 'tvanE@email.com', N'202 Đường EFG, Quận PQR'),
('taikhoan6', 'matkhau6', N'Ngô Thị F', '0369852146', 'nthiF@email.com', N'303 Đường HIJ, Quận EFG'),
('taikhoan7', 'matkhau7', N'Vũ Văn G', '0123456787', 'vvanG@email.com', N'404 Đường KLM, Quận STU'),
('taikhoan8', 'matkhau8', N'Hồ Thị H', '0987654323', 'hthiH@email.com', N'505 Đường NOP, Quận VWX'),
('taikhoan9', 'matkhau9', N'Đặng Văn I', '0369852145', 'dvanI@email.com', N'606 Đường UVW, Quận YZA'),
('taikhoan10', 'matkhau10', N'Lưu Thị K', '0123456786', 'lthiK@email.com', N'707 Đường BCD, Quận GHI');


-- Tạo bảng DonHang
CREATE TABLE DonHang (
    MaDonHang INT PRIMARY KEY IDENTITY(1,1),
    MaKhachHang int not null,
    NgayDat DATE not null,
    TongTien int NOT NULL,
	TinhTrang int default 0,
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)
);

INSERT INTO DonHang (MaKhachHang, NgayDat, TongTien, TinhTrang) VALUES 
(1, '2023-01-15', 25, 0),
(2, '2023-02-20', 16, 0),
(3, '2023-03-10', 38, 0),
(4, '2023-04-05', 42, 0),
(5, '2023-05-12', 30, 0),
(6, '2023-06-18', 19, 0),
(7, '2023-07-22', 50, 0),
(8, '2023-08-30', 28, 0),
(9, '2023-09-08', 35, 0),
(10, '2023-10-14', 21, 0);

-- Tạo bảng ChiTietDonHang
CREATE TABLE ChiTietDonHang (
    MaDonHang int not null,
    MaMonAn int not null,
    SoLuong INT NOT NULL,
    FOREIGN KEY (MaDonHang) REFERENCES DonHang(MaDonHang),
    FOREIGN KEY (MaMonAn) REFERENCES MonAn(MaMonAn)
);

INSERT INTO ChiTietDonHang (MaDonHang, MaMonAn, SoLuong) VALUES 
(1, 1, 2),
(2, 2, 1),
(3, 3, 3),
(4, 4, 2),
(5, 5, 4),
(6, 6, 1),
(7, 7, 3),
(8, 8, 2),
(9, 9, 5),
(10, 10, 1);

-- Tạo bảng NhanVien
CREATE TABLE NhanVien (
    MaNhanVien INT PRIMARY KEY IDENTITY(1,1),
	Taikhoannv varchar(20) not null,
	Matkhaunv varchar(50) not null,
    TenNhanVien NVARCHAR(255) NOT NULL,
    ChucVu NVARCHAR(50) NOT NULL,
    SoDienThoai VARCHAR(20) not null,
    DiaChi NVARCHAR(255)
);

INSERT INTO NhanVien (Taikhoannv, Matkhaunv, TenNhanVien, ChucVu, SoDienThoai, DiaChi) VALUES 
('taikhoannv1', 'matkhaunv1', N'Nguyễn Văn Nam', N'Nhân viên phục vụ', '0123456789', N'789 Đường XYZ, Quận ABC'),
('taikhoannv2', 'matkhaunv2', N'Trần Thị Hương', N'Quản lý', '0987654321', N'456 Đường LMN, Quận XYZ'),
('taikhoannv3', 'matkhaunv3', N'Lê Văn Tùng', N'Nhân viên bếp', '0369852147', N'123 Đường ABC, Quận XYZ'),
('taikhoannv4', 'matkhaunv4', N'Phạm Thị Mai', N'Nhân viên phục vụ', '0123456788', N'101 Đường PQR, Quận LMN'),
('taikhoannv5', 'matkhaunv5', N'Trương Văn Minh', N'Quản lý', '0987654322', N'202 Đường EFG, Quận PQR');


