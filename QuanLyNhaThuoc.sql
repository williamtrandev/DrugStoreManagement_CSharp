--DROP DATABASE QuanLyNhaThuoc
CREATE DATABASE QuanLyNhaThuoc
GO
USE QuanLyNhaThuoc
GO
CREATE TABLE NhaCungCap
(
	MANCC VARCHAR(10) PRIMARY KEY,
	TENNCC NVARCHAR(100) NOT NULL,
	SDT VARCHAR(10),
	DIACHI NVARCHAR(255)
)
GO
CREATE TABLE KhachHang
(
	SDT VARCHAR(10) PRIMARY KEY,
	TENKH NVARCHAR(50) NOT NULL,
	TICHDIEM FLOAT DEFAULT 0
)
GO
CREATE TABLE Thuoc 
(
	SODK VARCHAR(20) PRIMARY KEY, 
	MANCC VARCHAR(10),
	TENTHUOC NVARCHAR(200) NOT NULL,
	HOATCHAT NVARCHAR(500) DEFAULT '',
	DONVITINH NVARCHAR(100) NOT NULL,
	QUYCACHDONGGOI NVARCHAR(200) NOT NULL,
	GIANHAP FLOAT NOT NULL,
	GIABAN FLOAT NOT NULL
)

CREATE TABLE PhieuNhapHang
(
	MAPHIEU VARCHAR(10) PRIMARY KEY,
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
	MAPHIEU VARCHAR(10) FOREIGN KEY REFERENCES PhieuNhapHang(MAPHIEU),
	HSD DATE NOT NULL,
	SOLUONG INT DEFAULT 1,
	PRIMARY KEY(SODK, MAPHIEU)
)
GO
CREATE TABLE NhanVien
(
	SDT VARCHAR(20) PRIMARY KEY,
	DIACHI NVARCHAR(100),
	HOTEN NVARCHAR(50) NOT NULL,
	PASS VARCHAR(30) NOT NULL
)
GO
CREATE TABLE HoaDon
(
	MAHD VARCHAR(10) PRIMARY KEY,
	SDT VARCHAR(10) FOREIGN KEY REFERENCES KhachHang(SDT),
	SDTNV VARCHAR(20) FOREIGN KEY REFERENCES NhanVien(SDT),
	NGAYXUAT DATE DEFAULT GETDATE(),
	TONGTIEN FLOAT NOT NULL,
)

GO
CREATE TABLE ChiTietHoaDon
(
	MAHD VARCHAR(10) FOREIGN KEY REFERENCES HoaDon(MAHD),
	SODK VARCHAR(20)  FOREIGN KEY REFERENCES Thuoc(SODK), --Khoa ngoai den Thuoc nhung bi vuong
	SOLUONGBAN INT DEFAULT 1,
	PRIMARY KEY(MAHD, SODK)
)
GO





insert into NhanVien values('admin', N'TpHCM', N'Admin', 'admin123')
insert into NhanVien values('0907640644', N'TpHCM', N'Trương Tuấn Tú', 'tuantu123')
insert into NhanVien values('0122657847', N'TpHCM', N'Lê Thúy Vân', 'thuyvan123')
insert into NhanVien values('0987635213', N'Sóc Trăng', N'Hà Như Ngọc', 'hanhungoc123')
insert into NhanVien values('0923178132', N'TpHCM', N'Trương Tiểu Tiểu', 'tieutieu123')
insert into NhanVien values('0123213212', N'Cà Mau', N'Võ Văn Cừ', 'vancu123')
insert into NhanVien values('0923713156', N'Cần Thơ', N'Lý Hào Nam', 'haonam123')
insert into NhanVien values('0231632718', N'TpHCM', N'Kiều Minh Tú', 'minhtu123')


insert into NhaCungCap values('NCC1', N'Gujarat Liqui Pharmacaps (P) Ltd', '031731819', N'Ấn Độ')
insert into NhaCungCap values('NCC2', N'Công ty cổ phần dược phẩm Bidiphar 1', '0563846040', N'Việt Nam')
insert into NhaCungCap values('NCC3', N'Korean Drug Co., Ltd','098321632', N'Hàn Quốc')
insert into NhaCungCap values('NCC4', N'Ebewe Pharma Ges.m.b.H.Nfg.KG - Áo','098321632', N'Việt Nam')
insert into NhaCungCap values('NCC5', N'Công ty cổ phần dược phẩm Hà Tây','0433522203', N'Việt Nam')
insert into NhaCungCap values('NCC6', N'Công ty cổ phần dược phẩm IMEXPHARM - Việt Nam','043242456', N'Việt Nam')



insert into Thuoc values('VN-13708-11', 'NCC1', N'Ferrosanols', N'Cyanocobalamin, Sắt fumarat, Pyridoxine HCl, Kẽm Sulphate, acid folic', N'Viên', N'Hộp 10 vỉ x 10 viên',  6700, 6700*1.1)

insert into Thuoc values('VN-10268-10', 'NCC1', N'Emviyem', N'Calci, Kẽm, Mangan, Sắt, Kali, Đồng, Các Vitamin A, D3, E, B1, B2, B5, B6, B12, C, PP, Biotin', N'Viên', N'Hộp 3 vỉ, 6 vỉ x 10 viên',  12555, 12555*1.1)

insert into Thuoc values('VN-5249-10', 'NCC1', N'Megazith Soft', N'Azithromycin', N'Viên', N'Hộp to x 10 hộp nhỏ x 2 vỉ x 3 viên', 3.429, 3.429*1.1)

insert into Thuoc values('VN-13136-11', 'NCC1', N'Berofine', N'Beta caroten, Selen và muối khoáng', N'Viên', N'Hộp 10 vỉ x 10 viên nang mềm', 1100, 1100*1.1)

insert into Thuoc values('VN-13137-11', 'NCC1', N'Cetrisoft', N'Cetirizin HCl', N'Viên', N'Hộp 10 vỉ x 10 viên', 2100, 2100*1.1)

insert into Thuoc values('VN-12471-11', 'NCC1', N'Dextrex Plus', N'BromhexinHCll', N'Viên', N'Hộp 10 vỉ x 10 viên', 200, 200*1.1)
insert into Thuoc values('VN-13138-11', 'NCC1', N'Ferobex', N'Các Vitamin và khoáng chất', N'Viên', N'Hộp 10 vỉ x 10 viên', 900, 900*1.1)

insert into Thuoc values('VN-13674-11', 'NCC1', N'Royens', N'Carbonyl Iron, Folic acid, Vitamin B12, Natru Selenite, Vitamin E acetate', N'Viên', N'Hộp 10 vỉ x 10 viên', 789, 789*1.1)

insert into Thuoc values('VN-12472-11', 'NCC1', N'Spurt', N'Các vitamin và chất khoáng', N'Viên', N'Hộp 3 vỉ x 10 viên', 7000, 7000*1.1)

insert into Thuoc values('VN-11063-10', 'NCC1', N'Biorich E', N'Vitamin E - 400IU', N'Viên', N'Hộp 6 vỉ x 10 viên', 9000, 9000*1.1)

insert into Thuoc values('VN-11064-10', 'NCC1', N'Fine life Natural E 400', N'Vitamin E-400IU', N'Viên', N'Hộp 6 vỉ x 10 viên',  8700, 8700*1.1)

insert into Thuoc values('VN-10140-10', 'NCC1', N'Livintact', N'Lecithin-525mg/ viên', N'Viên', N'Hộp 6 vỉ x 10 vỉ',  5700, 5700*1.1)



insert into Thuoc values('VD-18249-13', 'NCC2',N'Amoxicilin 250mg', N'Amoxicilin 250mg', N'Gói', N'Hộp 12 gói x 1,4g', 1680, 1680*1.1)
insert into Thuoc values('VD-18248-13', 'NCC2', N'Ace kid 325', N'Paracetamol 325mg', N'Gói',N'Hộp 12 gói x 3g', 2940, 2940*1.1)
insert into Thuoc values('VD-19317-13', 'NCC2', N'Atorlog 20', N'Atorvastatin 20mg', N'Viên',N'Hộp 3 vỉ x 10 viên, hộp 10 vỉ x 10 viên', 1680, 1680*1.1)
insert into Thuoc values('QLDB-378-13', 'NCC2', N'Bestdocel 20', N'Docetaxel 20mg/0,5ml', N'Lọ',N'Hộp 1 lọ dung dịch đậm đặc + 1 lọ dung môi', 1050000, 1050000*1.1)
insert into Thuoc values('VD-19846-13', 'NCC2', N'Devastin 10', N'Rosuvastatin 10mg', N'Viên',N'Hộp 3 vỉ x 10 viên; hộp 10 vỉ x 10 viên', 4620, 4620*1.1)
insert into Thuoc values('VD-19849-13', 'NCC2', N'Ircovas 150', N'Irbesartan 150mg', N'Viên',N'Hộp 3 vỉ x 10 viên, hộp 10 vỉ x 10 viên; hộp 2 vỉ x 14 viên', 4200, 4200*1.1)
insert into Thuoc values('VD-19850-13', 'NCC2', N'Latoxol', N'Ambroxol HCl 360 mg', N'Lọ',N'Hộp 1 lọ x 60ml', 38850, 38850*1.1)
insert into Thuoc values('VD-18251-13', 'NCC2', N'Paracetamol 500mg', N'Paracetamol 500mg', N'Viên',N'Hộp 10 vỉ x 10 viên; hộp 50 vỉ x 10 viên', 263, 263*1.1)
insert into Thuoc values('VD-18704-13', 'NCC2', N'Glyclamic', N'Glibenclamid 5mg', N'Viên',N'Hộp 5 vỉ x 20 viên', 420, 420*1.1)
insert into Thuoc values('VD-18935-13', 'NCC2', N'Neutrifore', N'Thiamin mononitrat 250mg', N'Viên',N'Hộp 10 vỉ x 10 viên', 1890, 1890*1.1)



insert into Thuoc values('VD-31980-19', 'NCC3',N'Hep-Uso 300', N'Ursodeoxycholic acid', N'Viên', N'Hộp 3 vỉ, 10 vỉ x 10 viên', 3589, 3589*1.1)

insert into Thuoc values('VN-21038-18', 'NCC3',N'Midorel', N'Clopidogrel (dưới dạng Clopidogrel besylat) - 75mg', N'Viên', N'Hộp 3 vỉ x 10 viên', 10500, 10500*1.1)

insert into Thuoc values('VN-21811-19', 'NCC3',N'Redpentin Hard Capsule 300mg', N'Gabapentin - 300mg', N'Viên', N'Hộp 10 vỉ x 10 viên', 10500, 10500*1.1)

insert into Thuoc values('VN-16868-13', 'NCC3',N'Viên nang mềm Dimorin', N'Isotretinoin-10mg', N'Viên', N'Hộp 3 vỉ x 10 viên', 8000, 8000*1.1)

insert into Thuoc values('VN-21390-18', 'NCC3',N'Zypeace OD tab 10mg', N'Olanzapine - 10mg', N'Viên', N'Hộp 4 vỉ x 7 viên', 12500, 12500*1.1)

insert into Thuoc values('VN-19029-15', 'NCC3',N'Acutrine 20 Soft capsule', N'Isotretinoin 20mg', N'Viên', N'Hộp 3 vỉ x 10 viên', 5000, 5000*1.1)

insert into Thuoc values('VN-19035-15', 'NCC3',N'Interleukast Tab. 10mg', N'Montelukast (dưới dạng Montelukast natri) 10 mg;', N'Viên', N'Hộp 4 vỉ nhôm/ nhôm x 7 viên', 13500, 13500*1.1)

insert into Thuoc values('VN-14883-12', 'NCC3',N'Zilertal Tablet', N'Cetirizine dihydrochloride-10mg', N'Viên', N'Hộp 10 vỉ x 10 viên', 15500, 15500*1.1)

insert into Thuoc values('VN-11986-11', 'NCC3',N'Amiplex Tablet', N'Casein hydrolysate-500mg', N'Viên', N'Hộp 3 vỉ hoặc 9 vỉ hoặc 10 vỉ x 10 viên', 6500, 6500*1.1)

insert into Thuoc values('VN-10318-10', 'NCC3',N'Hctonase', N'Streptokinase', N'Viên', N'Hộp 10 vỉ x 10 viên', 8500, 8500*1.1)



insert into Thuoc values('VN-17422-13', 'NCC4', N'5-Fluorouracil Ebewe', N'5-Fluorouracil', N'Lọ', N'Hộp 1 lọ 10ml', 112.350, 112.350*1.1)

insert into Thuoc values('VN-17423-13', 'NCC4', N'Calciumfolinate Ebewe', N'Acid folinic', N'ống', N'ống 10ml', 175.239, 175.239*1.1)

insert into Thuoc values('VN-17425-13', 'NCC4', N'Docetaxel "Ebewe"', N'Docetaxel', N'Lọ', N'Hộp 1 lọ 2ml', 566.075, 566.075*1.1)

insert into Thuoc values('VN-15431-12', 'NCC4', N'Cerebrolysin', N'Cerebrolysin-215,2mg/ml', N'ống', N'Hộp 5 ống x 10ml', 108.675, 106.675*1.1)

insert into Thuoc values('VN-13698-11', 'NCC4', N'Alexan', N'Cytarabine', N'Lọ', N'Hộp 1 lọ 10ml', 185, 185*1.1) 

insert into Thuoc values('VD-27875-17', 'NCC5',N'Acemetin', N'Acetylcystein 200 mg', N'Gói', N'Hộp 12 gói x 1,4g', 1650, 1650*1.1)
insert into Thuoc values('VD-18278-13', 'NCC5', N'Babycanyl', N'Terbutalin sulfat 1,5 mg/5 ml', N'Lo',N'Hộp 1 lọ 60 ml', 23000, 23000*1.1)
insert into Thuoc values('VD-25691-16', 'NCC5', N'Cefdina 300', N'Cefdinir 300 mg', N'Viên',N'Hộp 3 vỉ x 10 viên, hộp 10 vỉ x 10 viên', 8500, 8500*1.1)
insert into Thuoc values('VD-18285-13', 'NCC5', N'Franvit A-D', N'Vitamin A (Retinyl palmitat) 2500 IU', N'Viên',N'Hộp 10 vỉ x 10 viên', 450, 450*1.1)
insert into Thuoc values('VD-19876-13', 'NCC5', N'Histapast', N'Levocetirizin hydroclorid 5 mg', N'Viên',N'Hộp 1 vỉ x 10 viên', 3000, 3000*1.1)



insert into Thuoc values('VD-24207-16', 'NCC6',N'ABAB 325 mg', N'Acetaminophen-325 mg', N'Viên', N'Chai 1000 viên', 500, 500*1.1)

insert into Thuoc values('VD-24781-16', 'NCC6',N'Chlorpheniramine maleate 4mg', N'Clorpheniramin maleat-4mg', N'Viên', N'Hộp 10 vỉ x 20 viên; chai 200 viên; chai 1000 viên', 210, 210*1.1)

insert into Thuoc values('VD-24784-16', 'NCC6',N'Ospamox 250 mg', N'Amoxicilin (dưới dạng Amoxicilin trihydrat)', N'Viên', N'Hộp 100 vỉ x 10 viên', 210, 210*1.1)

insert into Thuoc values('VD-24782-16', 'NCC6',N'Chlorpheniramine maleate 4mg', N'Clorpheniramin maleat-4mg', N'Viên', N'Hộp 10 vỉ x 20 viên', 1510, 1510*1.1)

insert into Thuoc values('VD-24786-16', 'NCC6',N'Standacillin 500 mg', N'Ampicilin (dưới dạng Ampicilin trihydrat)', N'Viên', N'Hộp 100 vỉ x 10 viên', 2000, 2000*1.1)
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
--go
--create proc proc_themNCC @mancc varchar(10), @tenncc varchar(100)
--as
--	insert into NhaCungCap values(@mancc,@tenncc)

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
--create proc proc_themHoaDon @sdt varchar(10), @ngayxuat date
--as
	--insert into HoaDon values(dbo.func_taoMaHoaDon(),@sdt,@ngayxuat,null)

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

go

exec dbo.proc_themKH '0123456789' , N'Dung'
exec dbo.proc_themKH '0246812345' , N'Khoa'
exec dbo.proc_themKH '0345216798' , N'Huy'
exec dbo.proc_themKH '0123283242' , N'Thảo'
exec dbo.proc_themKH '0830127462' , N'Ân'


