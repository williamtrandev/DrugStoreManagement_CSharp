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
	MANCC VARCHAR(10),
	TENTHUOC NVARCHAR(100) NOT NULL,
	HOATCHAT NVARCHAR(100) DEFAULT '',
	DONVITINH NVARCHAR(30) NOT NULL,
	QUYCACHDONGGOI NVARCHAR(100) NOT NULL,
	GIANHAP FLOAT NOT NULL,
	GIABAN FLOAT NOT NULL
)

CREATE TABLE PhieuNhapHang
(
	MAPHIEU VARCHAR(11) PRIMARY KEY,
	NGAYLAP DATE DEFAULT GETDATE(),
	TONGGIANHAP FLOAT
)
GO
CREATE TABLE ChiTietNhapHang
(
	MAPHIEU VARCHAR(11) FOREIGN KEY REFERENCES PhieuNhapHang(MAPHIEU),
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
	DIACHI NVARCHAR(100),
	HOTEN NVARCHAR(50) NOT NULL,
	PASS VARCHAR(30) NOT NULL
)


insert into NhanVien values('0907640698', N'TpHCM', N'Trần Tấn Thành', 'admin123')



insert into Thuoc values('VN-20514-17', 'NCC1', N'Zinnat tablets 500mg', N'Cefuroxim', N'Viên',N'Hộp 1 vỉ 10 viên', 24.589, 24.589*1.1)
insert into Thuoc values('VD-31977-19', 'NCC1',N'Cefurovid 250', N'Cefuroxim', N'Viên',N'Hộp 2 vỉ x 5 viên; hộp 10 vỉ x 10 viên', 24.589, 24.589*1.1)
insert into Thuoc values('VD-31979-19', 'NCC2',N'Zinnat tablets 500mg', N'Erythromycin', N'Viên', N'Hộp 20 gói x 3g', 24.589, 24.589*1.1)
insert into Thuoc values('VD-31980-19', 'NCC3',N'Hep-Uso 300', N'Ursodeoxycholic acid', N'Viên', N'Hộp 3 vỉ, 10 vỉ x 10 viên', 24.589, 24.589*1.1)
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
--DROP PROC proc_themThuoc
CREATE PROC proc_themThuoc @sodk VARCHAR(20), @mancc VARCHAR(10), @tenthuoc NVARCHAR(100), @hoatchat NVARCHAR(100), @donvitinh NVARCHAR(30), @quycachdonggoi NVARCHAR(100), @gianhap FLOAT, @giaban FLOAT
AS
begin
	insert into Thuoc values(@sodk,@mancc,@tenthuoc,@hoatchat,@donvitinh,@quycachdonggoi,@gianhap,@giaban)
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
returns varchar(10)
as
begin
	declare @date date, @date_string varchar(10), @maphieu varchar(11), @num int, @ma varchar(10)
	set @date = GETDATE()
	set @date_string = CONVERT(varchar(10),@date,111)
	set @date_string = RIGHT(@date_string, 8)
	set @date_string = REPLACE(@date_string,'/','')
	set @ma = 'N' + @date_string
	if EXISTS(select top 1 MAPHIEU from PhieuNhapHang where LEFT(MAPHIEU,7) = @ma order by MAPHIEU desc)
	begin
		set @maphieu = (select top 1 MAPHIEU from PhieuNhapHang where LEFT(MAPHIEU,7) = @ma order by MAPHIEU desc)
		set @num = CAST(RIGHT(@maphieu,3) as int) + 1
		if (@num < 10)
			set @ma = @ma + '00' + CAST(@num as varchar)
		else
		begin
			if (@num < 100)
				set @ma = @ma + '0' + CAST(@num as varchar)
			else
				set @ma = @ma + CAST(@num as varchar)
		end
	end
	else
		set @ma = @ma + '001'
	return @ma
end


go



go
create function func_taoMaHoaDon()
returns varchar(10)
as
begin
	declare @date date, @date_string varchar(10), @mahd varchar(10), @num int, @ma varchar(10)
	set @date = GETDATE()
	set @date_string = CONVERT(varchar(10),@date,111)
	set @date_string = RIGHT(@date_string, 8)
	set @date_string = REPLACE(@date_string,'/','')
	set @ma = 'X' + @date_string
	if EXISTS((select top 1 MAHD from HoaDon where LEFT(MAHD,7) = @ma order by MAHD desc))
	begin
		set @mahd = (select top 1 MAHD from HoaDon where LEFT(MAHD,7) = @ma order by MAHD desc)
		set @num = CAST(RIGHT(@mahd,3) as int) + 1
		if (@num < 10)
			set @ma = @ma + '00' + CAST(@num as varchar)
		else
		begin
			if (@num < 100)
				set @ma = @ma + '0' + CAST(@num as varchar)
			else
				set @ma = @ma + CAST(@num as varchar)
		end
	end
	else
		set @ma = @ma + '001'
	return @ma
end


go
create proc proc_themHoaDon @sdt varchar(10), @ngayxuat date
as
	insert into HoaDon values(dbo.func_taoMaHoaDon(),@sdt,@ngayxuat,null)

--Xoa hoa don

--Sua hoa don

--Them chi tiet hoa don
go
create proc proc_themCTHD @mahd varchar(10), @sodk varchar(20), @soluongban int
as
	insert into ChiTietHoaDon values(@mahd,@sodk,@soluongban)

--Xoa chi tiet hoa don

--Sua chi tiet hoa don

--Tinh tong tien hoa don
go
create proc proc_tongTienHoaDon @mahd varchar(10)
as
begin
	declare @tongtien float
	set @tongtien = (select SUM(Thuoc.GIANHAP*cthd.SOLUONGBAN) from Thuoc join ChiTietHoaDon cthd on Thuoc.SODK = cthd.SODK where cthd.MAHD = @mahd)
	update HoaDon set TONGTIEN = @tongtien where MAHD = @mahd
end



exec dbo.proc_themKH '0123456789' , N'Dung'
exec dbo.proc_themKH '0246812345' , N'Khoa'
exec dbo.proc_themKH '0345216798' , N'Huy'
exec dbo.proc_themKH '0123283242' , N'Thảo'
exec dbo.proc_themKH '0830127462' , N'Ân'

exec dbo.proc_themHoaDon '0123456789' , '2023/1/12'
exec dbo.proc_themHoaDon '0246812345' , '2023/1/13'
exec dbo.proc_themHoaDon '0345216798' , '2023/1/13'
exec dbo.proc_themHoaDon '0345216798' , '2023/1/14'
exec dbo.proc_themHoaDon '0123456789' , '2023/1/15'
exec dbo.proc_themHoaDon '0123283242' , '2023/1/20'
exec dbo.proc_themHoaDon '0123283242' , '2023/2/09'
exec dbo.proc_themHoaDon '0246812345' , '2023/2/12'
exec dbo.proc_themHoaDon '0830127462' , '2023/3/19'
exec dbo.proc_themHoaDon '0123456789' , '2023/3/20'

