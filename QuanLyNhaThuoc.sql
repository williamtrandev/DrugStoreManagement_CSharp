--DROP DATABASE QuanLyNhaThuoc
CREATE DATABASE QuanLyNhaThuoc
GO
USE QuanLyNhaThuoc
GO
CREATE TABLE NhaCungCap
(
	MANCC VARCHAR(10) PRIMARY KEY,
	TENNCC NVARCHAR(100) NOT NULL,
)
GO
CREATE TABLE KhachHang
(
	SDT VARCHAR(10) PRIMARY KEY,
	TENKH NVARCHAR(50) NOT NULL,
	TICHDIEM INT DEFAULT 0
)
GO
CREATE TABLE Thuoc 
(
	SODK VARCHAR(20) PRIMARY KEY,
	TENTHUOC NVARCHAR(100) NOT NULL,
	HOATCHAT NVARCHAR(100) DEFAULT '',
	DONVITINH NVARCHAR(30) NOT NULL,
	QUYCACHDONGGOI NVARCHAR(100) NOT NULL,
	GIANHAP FLOAT NOT NULL,
	GIABAN FLOAT NOT NULL
)

CREATE TABLE PhieuNhapHang
(
	MAPHIEU VARCHAR(10) PRIMARY KEY,
	MANCC VARCHAR(10) FOREIGN KEY REFERENCES NhaCungCap(MANCC),
	NGAYLAP DATE DEFAULT GETDATE(),
	TONGGIANHAP FLOAT
)
GO
CREATE TABLE ChiTietNhapHang
(
	MAPHIEU VARCHAR(10) FOREIGN KEY REFERENCES PhieuNhapHang(MAPHIEU),
	SODK VARCHAR(20) FOREIGN KEY REFERENCES Thuoc(SODK), --Khoa ngoai den Thuoc nhung bi vuong
	SOLUONGNHAP INT DEFAULT 1,
	PRIMARY KEY(MAPHIEU, SODK)
)
GO
CREATE TABLE KhoThuoc
(
	SODK VARCHAR(20) FOREIGN KEY REFERENCES Thuoc(SODK),
	MAPHIEU VARCHAR(11) FOREIGN KEY REFERENCES PhieuNhapHang(MAPHIEU),
	HSD DATE NOT NULL,
	SOLUONG INT DEFAULT 1,
	PRIMARY KEY(SODK, MAPHIEU)
)
GO
CREATE TABLE HoaDon
(
	MAHD INT PRIMARY KEY,
	SDT VARCHAR(10) FOREIGN KEY REFERENCES KhachHang(SDT),
	NGAYXUAT DATE DEFAULT GETDATE(),
	TONGTIEN FLOAT NOT NULL,
)
GO
CREATE TABLE ChiTietHoaDon
(
	MAHD INT FOREIGN KEY REFERENCES HoaDon(MAHD),
	SODK VARCHAR(20)  FOREIGN KEY REFERENCES Thuoc(SODK), --Khoa ngoai den Thuoc nhung bi vuong
	SOLUONGBAN INT DEFAULT 1,
	PRIMARY KEY(MAHD, SODK)
)
GO
CREATE TABLE NhanVien
(
	SDT VARCHAR(20) PRIMARY KEY,
	HOTEN NVARCHAR(50) NOT NULL,
	PASS VARCHAR(30) NOT NULL
)

insert into NhanVien values('0907640698', N'Trần Tấn Thành', 'admin123')
-------------------------------
--       Procedure           --
-------------------------------

--Login
GO
CREATE PROC proc_Login @sodt VARCHAR(20), @pass VARCHAR(30)
AS
BEGIN
	SELECT * FROM NhanVien WHERE SDT = @sodt AND PASS = @pass
END



--Them thuoc vao danh muc thuoc
go
CREATE PROC proc_themThuoc @sodk VARCHAR(20), @tenthuoc NVARCHAR(100), @hoatchat NVARCHAR(100), @donvitinh NVARCHAR(30), @quycachdonggoi NVARCHAR(100), @gianhap FLOAT
AS
begin
	DECLARE @giaban float
	set @giaban = @gianhap + @gianhap*10/100
	insert into Thuoc values(@sodk,@tenthuoc,@hoatchat,@donvitinh,@quycachdonggoi,@gianhap,@giaban)
end

--Xoa thuoc khoi danh muc thuoc
go
create proc proc_xoaThuoc @sodk varchar(20)
as
begin
	declare @c1 int, @c2 int, @c3 int
	set @c1 = (select COUNT(*) from ChiTietNhapHang where SODK = @sodk)
	set @c2 = (select COUNT(*) from ChiTietHoaDon where SODK = @sodk)
	set @c3 = (select COUNT(*) from KhoThuoc where SODK = @sodk)
	if (@c1 = 0 and @c2 = 0 and @c3 = 0)
		delete from ChiTietNhapHang where SODK = @sodk
end

--Sua thong tin thuoc


--Them nha cung cap
go
create proc proc_themNCC @mancc varchar(10), @tenncc varchar(100)
as
	insert into NhaCungCap values(@mancc,@tenncc)

--Xoa nha cung cap

--Sua nha cung cap

--Them khach hang
go
create proc proc_themKH @sdt varchar(10), @tenkh nvarchar(50)
as
	insert into KhachHang values(@sdt,@tenkh,0);

--cong diem
go
create proc proc_congDiem @sdt varchar(10), @diem int
as
	update KhachHang set TICHDIEM = TICHDIEM + @diem

--Sua khach hang

--Xoa khach hang

--Them phieu nhap hang
go
create function func_taoMaPhieu()
returns varchar(11)
as
begin
	declare @date date, @date_string varchar(10), @maphieu varchar(11), @num int, @ma varchar(11)
	set @date = GETDATE()
	set @date_string = CONVERT(varchar(10),@date,111)
	set @date_string = RIGHT(@date_string, 8)
	set @date_string = REPLACE(@date_string,'/','')
	set @ma = 'N' + @date_string
	set @maphieu = (select top 1 MAPHIEU from PhieuNhapHang where LEFT(MAPHIEU,7) = @ma order by MAPHIEU desc)
	set @num = CAST(RIGHT(@maphieu,3) as int)
	if (@num < 10)
		set @ma = @ma + '00' + CAST(@num as varchar)
	else
	begin
		if (@num < 100)
			set @ma = @ma + '0' + CAST(@num as varchar)
		else
			set @ma = @ma + CAST(@num as varchar)
	end
	return @ma
end


go
create proc proc_themPhieuNhap @mancc varchar(10), @ngaylap date
as
	insert into PhieuNhapHang values(dbo.func_taoMaPhieu(),@mancc,@ngaylap,null)


--Xoa phieu nhap hang

--Sua phieu nhap hang

--Them Chi tiet phieu nhap hang
MAPHIEU VARCHAR(11) FOREIGN KEY REFERENCES PhieuNhapHang(MAPHIEU),
	SODK VARCHAR(20) FOREIGN KEY REFERENCES Thuoc(SODK), --Khoa ngoai den Thuoc nhung bi vuong
	SOLUONGNHAP INT DEFAULT 1,
	PRIMARY KEY(MAPHIEU, SODK)

create proc proc_themCTPN @maphieu varchar()


--Them thuoc vao kho thuoc
go
create proc proc_themKhoThuoc @sodk varchar(20), @maphieu varchar(11), @hsd date, @soluong int
as
	insert into KhoThuoc values(@sodk, @maphieu, @hsd, @soluong)

--Xoa thuoc khoi kho thuoc

--Sua thong tin thuoc trong kho