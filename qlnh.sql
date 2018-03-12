use QuanLyNhaHang
go


---- da lam xong----------
create table NhanVien(
Manv varchar(10) not null primary key,
Tennv nvarchar(50),
GioiTinh varchar(3),
---GioiTinh CHAR(3) CHECK (GioiTinh IN ('Nam', 'Nu')), 
NgaySinh datetime,
SCMT varchar(10),
NgayLamViec nvarchar(50),
NgayNghi nvarchar(50),
TrangThai nvarchar(50)
)

Alter table NhanVien  alter COLUMN  GioiTinh  Char(3) 

ALTER TABLE NhanVien
ADD CONSTRAINT MyUniqueConstraint CHECK (GioiTinh IN ('Nam ' , 'Nu'));


----da xong ---
create table LoaiMonAn(
MaLoaiMonAn varchar(10) not null primary key,
TenMonAn nvarchar(50),
DonGia varchar(10),
ChiTiet nvarchar(50),
)





---da xong------
create table Menu(
MaMonAn varchar(10) not null primary key,
TenMonAn nvarchar(50),
DonGia varchar(10),
MaLoaiMonAn varchar(10) not null references LoaiMonAn(MaLoaiMonAn)
)
----da xong------------
create table KhachHang (
MaKH varchar (10) not null primary key ,
TenKH nvarchar(50),
SoTien varchar(10),
MaThanhToan varchar(10) not null references HoaDonThanhToan( MaThanhToan)
 )



 create table HoaDonNhapHang (
 MaHD varchar(10) not null primary key ,
 TenHD nvarchar(50),
 DonGia varchar(10),
 NgayNhap datetime,
 MaNV varchar(10) not null references NhanVien(MaNV),
 MaHDNhap varchar(10) not null references ChiTietHoaDonNhap(MaHDNhap)


 )
 -----xong--------------
 create table ChiTietHoaDonNhap(
 MaHDNhap varchar(10) not null primary key,
 SoLuong varchar(10),
 DonGia varchar(10),
 MaNL varchar(10) not null references NguyenLieu(MaNL)
 )
 -----da xong ------
 create table ChiTietHoaDonBan(
 MaHDBan varchar(10) not null primary key ,
 TenHD nvarchar(50),
 DonGia varchar(10),
 NgayNhap date , 
 MaNV varchar(10),
 MaMonAn varchar(10) not null references Menu(MaMonAn)
 )
 -----da xong-----
 create table HoaDonThanhToan(
 MaThanhToan varchar(10) not null primary key ,
 TenKH nvarchar(50),
 TongTien varchar(20),
 MaHDBan varchar(10) not null references ChiTietHoaDonBan(MaHDBan),
 MaNV varchar(10) not null references NhanVien(MaNV),
 MaBan varchar(10) not null references Ban(MaBan)
 )

 select*from HoaDonThanhToan
 -----da xong----
 create table NguyenLieu (
 MaNL varchar(10) not null primary key ,
 TenNL nvarchar(50),
 DonGia varchar(10)
 )
 ---da xong --
 create table Ban(
 MaBan varchar(10) not null primary key ,
 TenBan nvarchar(50),
 
 )
 


 ------Select Ban--------------------
 CREATE PROC SelectBan
 AS
 BEGIN
	Select*From Ban
 END

 ------------Select NL ------------------------
 CREATE PROC SelectNguyenLieu
 AS
 BEGIN
	Select*From NguyenLieu
 END


 -----------Select Hoa don Thanh Toan-----------
 CREATE PROC SelectHoaDonThanhToan
 AS
 BEGIN
	Select*From HoaDonThanhToan
 END



 ----------Select Menu-------------------------------
 CREATE PROC SelectMeNu 
 AS
 BEGIN
	Select*From Menu
 END

 -----------Select LoaiMonAn---------------------------
 CREATE PROC SelectLoaiMonAn
 AS
 BEGIN
	Select*From LoaiMonAn
 END

 ------------Select Nhan Vien ------------------------
 CREATE PROC SelectNhanVien
 AS
 BEGIN
	Select*From NhanVien
 END

 -----------Select KhachHang--------------
 CREATE PROC SelectKhachHang
 AS
 BEGIN
	Select*From KhachHang
 END



 --------Select HoaDonNhapHang-----------------
 CREATE PROC SelectHoaDonNhapHang
 AS
 BEGIN
	Select*From HoaDonNhapHang
 END

 -------Select ChiTietHoaDonBan-------------------
 CREATE PROC SelectChiTietHoaDonBan
 AS
 BEGIN
	Select*From ChiTietHoaDonBan
 END

 --------Select ChiTietHoaDonNhap------------------
 CREATE PROC SelectChiTietHoaDonNhap
 AS
 BEGIN
	Select*From ChiTietHoaDonNhap
 END



 -------Them Hoa Don Nhap --------------------

 CREATE PROC ThemHoaDonNhap (@mahd varchar(10) , @tenhd Nvarchar(50) , @dongia varchar(10) , @ngaynhap datetime , @manv varchar(10) , @mahdnhap  varchar(10))
 AS
 BEGIN
	Insert into HoaDonNhapHang (MaHD , TenHD , DonGia , NgayNhap , MaNV , MaHDNhap)
	Values (@mahd , @tenhd , @dongia , @ngaynhap , @manv , @mahdnhap)

 END
 go
 execute ThemHoaDonNhap @mahd = 'hd001' , @tenhd ='Hoa Don Ban 1', @dongia ='35200000' , @ngaynhap = '10/10/2017' , @manv = 'nv001' , @mahdnhap = 'hdn001'
 execute ThemHoaDonNhap @mahd = 'hd002' , @tenhd ='Hoa Don Ban 2', @dongia ='35200000' , @ngaynhap = '10/10/2017' , @manv = 'nv001' , @mahdnhap = 'hdn001'
 execute ThemHoaDonNhap @mahd = 'hd003' , @tenhd ='Hoa Don Ban 3', @dongia ='35200000' , @ngaynhap = '10/10/2017' , @manv = 'nv001' , @mahdnhap = 'hdn001'
 execute ThemHoaDonNhap @mahd = 'hd004' , @tenhd ='Hoa Don Ban 4', @dongia ='35200000' , @ngaynhap = '10/10/2017' , @manv = 'nv001' , @mahdnhap = 'hdn001'
 execute ThemHoaDonNhap @mahd = 'hd005' , @tenhd ='Hoa Don Ban 5', @dongia ='35200000' , @ngaynhap = '10/10/2017' , @manv = 'nv001' , @mahdnhap = 'hdn001'
 execute ThemHoaDonNhap @mahd = 'hd006' , @tenhd ='Hoa Don Ban 6', @dongia ='35200000' , @ngaynhap = '10/10/2017' , @manv = 'nv001' , @mahdnhap = 'hdn001'
 execute ThemHoaDonNhap @mahd = 'hd007' , @tenhd ='Hoa Don Ban 7', @dongia ='35200000' , @ngaynhap = '10/10/2017' , @manv = 'nv001' , @mahdnhap = 'hdn001'
 execute ThemHoaDonNhap @mahd = 'hd008' , @tenhd ='Hoa Don Ban 8', @dongia ='35200000' , @ngaynhap = '10/10/2017' , @manv = 'nv001' , @mahdnhap = 'hdn001'
 execute ThemHoaDonNhap @mahd = 'hd009' , @tenhd ='Hoa Don Ban 9', @dongia ='35200000' , @ngaynhap = '10/10/2017' , @manv = 'nv001' , @mahdnhap = 'hdn001'
 go



 --------------Update hoa don nhap -------------------------
 CREATE PROC EDITHoaDonNhap (@mahd varchar(10) , @tenhd Nvarchar(50) , @dongia varchar(10) , @ngaynhap datetime , @manv varchar(10) , @mahdnhap  varchar(10))
 AS
 BEGIN
	Update HoaDonNhapHang
	set TenHD = @tenhd , DonGia = @dongia , NgayNhap =@ngaynhap , MaNV = @manv , MaHDNhap = @mahdnhap
	where MaHD = @mahd
 END
 go
  execute EDITHoaDonNhap @mahd = 'hd009' , @tenhd ='Hoa Don Ban 12', @dongia ='33550100' , @ngaynhap = '10/10/2017' , @manv = 'nv001' , @mahdnhap = 'hdn001'
 go



 ------------------Xoa Hoa don nhap------------------
 CREATE PROC DELETEHoaDonNhap (@mahd varchar(10))
 AS
 BEGIN
	DELETE FROM HoaDonNhapHang where MaHD = @mahd
 END
 go
 execute DELETEHoaDonNhap @mahd = 'hd008'
 go

 --------Them Chi Tiet Hoa Don Ban ----------------

 CREATE PROC ThemChiTietHoaDonBan(@mahdban varchar(10) , @tenhd nvarchar(50) , @dongia varchar(10) , @ngaynhap date , @manv varchar(10) , @mamonan varchar(10))
 AS
 BEGIN
	Insert into ChiTietHoaDonBan (MaHDBan , TenHD , DonGia , NgayNhap , MaNV , MaMonAn)
	Values (@mahdban ,@tenhd , @dongia , @ngaynhap , @manv , @mamonan )
 END
 go
	execute ThemChiTietHoaDonBan @mahdban = 'hdb001' , @tenhd = N'Hoa Don 1' , @dongia = '3500000' , @ngaynhap = '2016/10/10' , @manv = 'nv001' , @mamonan = 'ma001'
	execute ThemChiTietHoaDonBan @mahdban = 'hdb002' , @tenhd = N'Hoa Don 2' , @dongia = '3500000' , @ngaynhap = '2016/10/10' , @manv = 'nv001' , @mamonan = 'ma005'
	execute ThemChiTietHoaDonBan @mahdban = 'hdb003' , @tenhd = N'Hoa Don 3' , @dongia = '3500000' , @ngaynhap = '2016/10/10' , @manv = 'nv002' , @mamonan = 'ma001'
	execute ThemChiTietHoaDonBan @mahdban = 'hdb004' , @tenhd = N'Hoa Don 4' , @dongia = '3500000' , @ngaynhap = '2016/10/10' , @manv = 'nv003' , @mamonan = 'ma004'
	execute ThemChiTietHoaDonBan @mahdban = 'hdb005' , @tenhd = N'Hoa Don 5' , @dongia = '3500000' , @ngaynhap = '2016/10/10' , @manv = 'nv001' , @mamonan = 'ma001'
	execute ThemChiTietHoaDonBan @mahdban = 'hdb006' , @tenhd = N'Hoa Don 6' , @dongia = '3500000' , @ngaynhap = '2016/10/10' , @manv = 'nv005' , @mamonan = 'ma003'
	execute ThemChiTietHoaDonBan @mahdban = 'hdb007' , @tenhd = N'Hoa Don 7' , @dongia = '3500000' , @ngaynhap = '2016/10/10' , @manv = 'nv001' , @mamonan = 'ma001'
	execute ThemChiTietHoaDonBan @mahdban = 'hdb008' , @tenhd = N'Hoa Don 8' , @dongia = '3500000' , @ngaynhap = '2016/10/10' , @manv = 'nv006' , @mamonan = 'ma002'
	execute ThemChiTietHoaDonBan @mahdban = 'hdb009' , @tenhd = N'Hoa Don 9' , @dongia = '3500000' , @ngaynhap = '2016/10/10' , @manv = 'nv001' , @mamonan = 'ma001'
 go


 -----Update Chi Tiet Hoa Don Ban--------------
 CREATE PROC EDITChiTietHoaDonBan (@mahdban varchar(10) , @tenhd nvarchar(50) , @dongia varchar(10) , @ngaynhap date , @manv varchar(10) , @mamonan varchar(10))
 AS
 BEGIN
	Update ChiTietHoaDonBan
	set  TenHD = @tenhd , DonGia= @dongia , NgayNhap = @ngaynhap , MaNV = @manv , MaMonAn = @mamonan
	Where  MaHDBan = @mahdban
	
 END
 go
execute EDITChiTietHoaDonBan @mahdban = 'hdb009' , @tenhd = N'Hoa Don 90' , @dongia = '3500000' , @ngaynhap = '2016/10/10' , @manv = 'nv001' , @mamonan = 'ma001'
 go


 ------------------Xoa Chi Tiet Hoa Don Ban ---------------
 CREATE PROC DELETEChiTietHoaDonBan (@mahdban varchar(10))
 AS
 BEGIN
	DELETE FROM ChiTietHoaDonBan where MaHDBan = @mahdban
 END
 go
 execute DELETEChiTietHoaDonBan @mahdban = 'hdb009'
 go


 ------Them NhanVien -------------------

 CREATE PROC ThemNhanVien (@manv varchar(10) , @tennv Nvarchar(50) , @gioitinh char(3) , @ngaysinh datetime , @scmt varchar(10) , @ngaylamviec Nvarchar(50) , @ngaynghi Nvarchar(50) , @trangthai Nvarchar(50))
 AS
 BEGIN
	Insert into NhanVien(Manv , Tennv , GioiTinh , NgaySinh , SCMT , NgayLamViec , NgayNghi , TrangThai)
	Values (@manv , @tennv , @gioitinh , @ngaysinh , @scmt , @ngaylamviec , @ngaynghi , @trangthai)
 END
 go
 execute ThemNhanVien @manv = 'nv001' , @tennv = 'Nguyen Van C' , @gioitinh = 'Nu' , @ngaysinh='10-10-1997' , @scmt='01324567' , @ngaylamviec='23' , @ngaynghi='30' , @trangthai='di lam'
 execute ThemNhanVien @manv = 'nv002' , @tennv = 'Nguyen Van B' , @gioitinh = 'Nu' , @ngaysinh='10-10-1997' , @scmt='01324567' , @ngaylamviec='23' , @ngaynghi='30' , @trangthai='di lam'
 execute ThemNhanVien @manv = 'nv003' , @tennv = 'Nguyen Van A' , @gioitinh = 'Nu' , @ngaysinh='10-10-1997' , @scmt='01324567' , @ngaylamviec='23' , @ngaynghi='30' , @trangthai='di lam'
 execute ThemNhanVien @manv = 'nv004' , @tennv = 'Luong Van C' , @gioitinh = 'Nu' , @ngaysinh='10-10-1997' , @scmt='01324567' , @ngaylamviec='23' , @ngaynghi='30' , @trangthai='di lam'
 execute ThemNhanVien @manv = 'nv005' , @tennv = 'Nguyen Trong R' , @gioitinh = 'Nu' , @ngaysinh='10-10-1997' , @scmt='01324567' , @ngaylamviec='23' , @ngaynghi='30' , @trangthai='di lam'
execute ThemNhanVien @manv = 'nv006' , @tennv = 'Do Mai Giang' , @gioitinh = 'Nu' , @ngaysinh='10-10-1997' , @scmt='01324567' , @ngaylamviec='23' , @ngaynghi='30' , @trangthai='di lam'
execute ThemNhanVien @manv = 'nv007' , @tennv = 'Pham Minh Duc' , @gioitinh = 'Nu' , @ngaysinh='10-10-1997' , @scmt='01324567' , @ngaylamviec='23' , @ngaynghi='30' , @trangthai='di lam'
 go


 ---------------Sua NhanVien --------
 CREATE PROC EDITNhanVien (@manv varchar(10) , @tennv Nvarchar(50) , @gioitinh char(3) , @ngaysinh datetime , @scmt varchar(10) , @ngaylamviec Nvarchar(50) , @ngaynghi Nvarchar(50) , @trangthai Nvarchar(50))
 AS
 BEGIN
	Update NhanVien
	set Tennv = @tennv , GioiTinh = @gioitinh , NgaySinh = @ngaysinh , SCMT = @scmt , NgayLamViec = @ngaylamviec , NgayNghi = @ngaynghi , TrangThai = @trangthai
	where Manv = @manv
 END
 go
 execute EDITNhanVien @manv = 'nv005' , @tennv = 'Nguyen Van Cuong' , @gioitinh = 'Nam' , @ngaysinh='10-10-1997' , @scmt='01324567' , @ngaylamviec='23' , @ngaynghi='30' , @trangthai='di lam'
 go

 ---------Xoa NhanVien ------------------------
 CREATE PROC DELETENhanVien (@manv varchar(10))
 AS
 BEGIN
	DELETE FROM NhanVien where (Manv = @manv)
 END
 go
 execute DELETENhanVien @manv = 'nv003'
 go


 --Theem Hoa Don Thanh Toan------------------ 

 CREATE PROC ThemHoaDonThanhToan (@mathanhtoan varchar(10) , @tenkh Nvarchar(50) , @tongtien varchar(20) , @mahdban varchar(10) , @manv varchar(10)  , @maban varchar(10) )
 AS
 BEGIN
	Insert into HoaDonThanhToan(MaThanhToan , TenKH , TongTien , MaHDBan , MaNV, MaBan)
	Values (@mathanhtoan , @tenkh , @tongtien , @mahdban ,@manv , @maban)
 END
 go
 execute ThemHoaDonThanhToan @mathanhtoan = 'tt001' , @tenkh = N'Nguyen Van B' , @tongtien = '3450000' , @mahdban = 'hdb001' ,@manv = 'nv001' , @maban = 'b001'
execute ThemHoaDonThanhToan @mathanhtoan = 'tt002' , @tenkh = N'Nguyen Van H' , @tongtien = '3450000' , @mahdban = 'hdb001' ,@manv = 'nv001' , @maban = 'b001'
execute ThemHoaDonThanhToan @mathanhtoan = 'tt003' , @tenkh = N'Nguyen Van G' , @tongtien = '3450000' , @mahdban = 'hdb001' ,@manv = 'nv001' , @maban = 'b001'
execute ThemHoaDonThanhToan @mathanhtoan = 'tt004' , @tenkh = N'Nguyen Van F' , @tongtien = '3450000' , @mahdban = 'hdb001' ,@manv = 'nv001' , @maban = 'b001'
execute ThemHoaDonThanhToan @mathanhtoan = 'tt005' , @tenkh = N'Nguyen Van E' , @tongtien = '3450000' , @mahdban = 'hdb001' ,@manv = 'nv001' , @maban = 'b001'
execute ThemHoaDonThanhToan @mathanhtoan = 'tt006' , @tenkh = N'Nguyen Van B' , @tongtien = '3450000' , @mahdban = 'hdb001' ,@manv = 'nv001' , @maban = 'b001'
execute ThemHoaDonThanhToan @mathanhtoan = 'tt007' , @tenkh = N'Nguyen Van C' , @tongtien = '3450000' , @mahdban = 'hdb001' ,@manv = 'nv001' , @maban = 'b001'
 go


 ---------Sua Hoa don thanh toan ----------------
 CREATE PROC EDITHoaDonThanhToan (@mathanhtoan varchar(10) , @tenkh Nvarchar(50) , @tongtien varchar(20) , @mahdban varchar(10) , @manv varchar(10)  , @maban varchar(10) )
 AS
 BEGIN
	Update HoaDonThanhToan 
	set TenKH = @tenkh , TongTien = @tongtien ,MaHDBan = @mahdban , MaNV = @manv, MaBan = @maban
	Where MaThanhToan = @mathanhtoan
 END
 go
 execute EDITHoaDonThanhToan @mathanhtoan = 'tt004' , @tenkh = N'Nguyen Van E ' , @tongtien= '650000' , @mahdban = 'hdb001' , @manv = 'nv001' , @maban = 'b004'
 go

 ------ Xoa Hoa Don Thanh Toan -------------------------
 CREATE PROC DELETEHoaDonThanhToan (@mathanhtoan varchar(10))
 AS
 BEGIN
	DELETE FROM HoaDonThanhToan where (MaThanhToan=@mathanhtoan)
 END
 go
 execute DELETEHoaDonThanhToan @mathanhtoan = 'tt007'
 go

 -----Thêm chi tiet hóa đơn nhập ---------

CREATE PROC ThemChiTietHoaDonNhap (@mahdnhap varchar(10) , @soluong varchar(10) , @dongian varchar(10) , @manl varchar(10))
AS
BEGIN
	Insert into ChiTietHoaDonNhap(MaHDNhap , SoLuong , DonGia , MaNL)
	Values (@mahdnhap , @soluong , @dongian , @manl)
END
go
execute ThemChiTietHoaDonNhap @mahdnhap = 'hdn001' , @soluong = '10kg' , @dongian = '2300025' , @manl ='nl001'
execute ThemChiTietHoaDonNhap @mahdnhap = 'hdn002' , @soluong = '120kg' , @dongian = '2300025' , @manl ='nl001'
execute ThemChiTietHoaDonNhap @mahdnhap = 'hdn003' , @soluong = '100kg' , @dongian = '2300025' , @manl ='nl001'
execute ThemChiTietHoaDonNhap @mahdnhap = 'hdn004' , @soluong = '100kg' , @dongian = '2300025' , @manl ='nl001'
execute ThemChiTietHoaDonNhap @mahdnhap = 'hdn005' , @soluong = '10kg' , @dongian = '2300025' , @manl ='nl001'
execute ThemChiTietHoaDonNhap @mahdnhap = 'hdn006' , @soluong = '150kg' , @dongian = '2300025' , @manl ='nl002'
execute ThemChiTietHoaDonNhap @mahdnhap = 'hdn007' , @soluong = '20kg' , @dongian = '2300025' , @manl ='nl003'
go

-------sửa chi tiết hóa đơn nhập ----------------
CREATE PROC EDITChiTietHoaDonNhap (@mahdnhap varchar(10) , @soluong varchar(10) , @dongian varchar(10) , @manl varchar(10))
AS
BEGIN
	Update ChiTietHoaDonNhap
	set SoLuong = @soluong , DonGia = @dongian , MaNL = @manl
	Where MaHDNhap = @mahdnhap
END
go
execute EDITChiTietHoaDonNhap @mahdnhap = 'hdn007' , @soluong = '200kg' , @dongian = '2300025' , @manl ='nl002'
go

-----Xóa chi tiêt hóa đơn nhập---------------
CREATE PROC DELETEChiTietHoaDonNhap (@mahdnhap varchar(10))
AS
BEGIN
	DELETE FROM ChiTietHoaDonNhap Where (MaHDNhap =@mahdnhap)
END
go
execute DELETEChiTietHoaDonNhap @mahdnhap = 'hdn007'
go



 -------Thêm menu ------

CREATE PROC ThemMeNu (@mamonan varchar(10),@tenmonan nvarchar(50),@dongia varchar(10),@maloaimonan varchar(10))
AS
BEGIN
	Insert into Menu(MaMonAn , TenMonAn , DonGia , MaLoaiMonAn)
	Values (@mamonan , @tenmonan , @dongia , @maloaimonan)
END
go
execute ThemMeNu @mamonan = 'ma001' , @tenmonan=N'Khai Vị' , @dongia = '20000000' , @maloaimonan ='lma001'
execute ThemMeNu @mamonan = 'ma002' , @tenmonan=N'Món Chính' , @dongia = '20000000' , @maloaimonan ='lma001'
execute ThemMeNu @mamonan = 'ma003' , @tenmonan=N'Tráng Miệng' , @dongia = '20000000' , @maloaimonan ='lma002'
execute ThemMeNu @mamonan = 'ma004' , @tenmonan=N'Khai Vị' , @dongia = '20000000' , @maloaimonan ='lma001'
execute ThemMeNu @mamonan = 'ma005' , @tenmonan=N'Khai Vị' , @dongia = '20000000' , @maloaimonan ='lma001'
execute ThemMeNu @mamonan = 'ma006' , @tenmonan=N'Khai Vị' , @dongia = '20000000' , @maloaimonan ='lma001'
execute ThemMeNu @mamonan = 'ma007' , @tenmonan=N'Khai Vị' , @dongia = '20000000' , @maloaimonan ='lma001'
execute ThemMeNu @mamonan = 'ma008' , @tenmonan=N'Khai Vị' , @dongia = '20000000' , @maloaimonan ='lma001'
go
-------sửa menu
CREATE PROC EDITMeNu (@mamonan varchar(10),@tenmonan nvarchar(50),@dongia varchar(10),@maloaimonan varchar(10))
AS
BEGIN
	Update Menu
	set TenMonAn=@tenmonan ,DonGia = @dongia , MaLoaiMonAn = @maloaimonan
	Where MaMonAn = @mamonan

END
go
execute EDITMeNu @mamonan = 'ma008' , @tenmonan=N'Món Phụ' , @dongia = '33554000' , @maloaimonan ='lma005'
go
-------Xóa menu
CREATE PROC DELETEMeNu (@mamonan varchar(10))
AS
BEGIN
	DELETE FROM Menu Where (MaMonAn = @mamonan)
END
go
execute DELETEMeNu @mamonan = 'ma007'
go

 ----Them Loai Mon An --------- 

CREATE PROC ThemLoaiMonAn (@maloaimonan varchar(10) ,@tenmonan nvarchar(50),@dongia varchar(10),@chitiet nvarchar(50))
AS
BEGIN
	Insert into LoaiMonAn(MaLoaiMonAn , TenMonAn , DonGia , ChiTiet)
	Values (@maloaimonan , @tenmonan , @dongia , @chitiet)
END
go
execute ThemLoaiMonAn @maloaimonan = 'lma001' , @tenmonan = N'Cá Chép Vua Nướng Nguyên Con' , @dongia = '6890000' , @chitiet = N'Rất giòn ngon và thơm'
execute ThemLoaiMonAn @maloaimonan = 'lma002' , @tenmonan = N'Tôm Nướng' , @dongia = '6890000' , @chitiet = N'Rất giòn ngon và thơm'
execute ThemLoaiMonAn @maloaimonan = 'lma003' , @tenmonan = N'Cá Chép Vua Nướng Nguyên Con' , @dongia = '6890000' , @chitiet = N'Rất giòn ngon và thơm'
execute ThemLoaiMonAn @maloaimonan = 'lma004' , @tenmonan = N'Cá Chép Vua Nướng Nguyên Con' , @dongia = '6890000' , @chitiet = N'Rất giòn ngon và thơm'
execute ThemLoaiMonAn @maloaimonan = 'lma005' , @tenmonan = N'Cá Chép Vua Nướng Nguyên Con' , @dongia = '6890000' , @chitiet = N'Rất giòn ngon và thơm'
execute ThemLoaiMonAn @maloaimonan = 'lma006' , @tenmonan = N'Cá Voi Chiên' , @dongia = '6890000' , @chitiet = N'Rất giòn ngon và thơm'
execute ThemLoaiMonAn @maloaimonan = 'lma007' , @tenmonan = N'Bạch Tuộc Xào' , @dongia = '6890000' , @chitiet = N'Rất giòn ngon và thơm'
go



-------Update Loai Mon An------------------
CREATE PROC EDITLoaiMonAn (@maloaimonan varchar(10) ,@tenmonan nvarchar(50),@dongia varchar(10),@chitiet nvarchar(50))
AS
BEGIN
	Update LoaiMonAn
	set TenMonAn=@tenmonan ,DonGia = @dongia , ChiTiet = @chitiet 
	Where MaLoaiMonAn = @maloaimonan

END
go
execute EDITLoaiMonAn  @maloaimonan= 'lma005', @tenmonan = N'Cá Chép Vũ Đại' , @dongia = '600000' , @chitiet = N'Rất ngon và đảm bảo' 
go

------------Xoa Loai Mon An -----------------
CREATE PROC DELETELoaiMonAn (@maloaimonan varchar(10))
AS
BEGIN
	DELETE FROM LoaiMonAn Where (MaLoaiMonAn =@maloaimonan)
END
go
execute DELETELoaiMonAn @maloaimonan = 'lma004'
go
 -----Them NguyenLieu----------------
 CREATE PROC ThemNguyenLieu( @manl varchar(10) , @tennl Nvarchar(50) , @dongia varchar(10))
 AS
 BEGIN
	Insert into NguyenLieu(MaNL, TenNL , DonGia)
	Values (@manl , @tennl , @dongia)
 END
 go
 execute ThemNguyenLieu @manl ='nl001' , @tennl =N'Cá chép' , @dongia ='2400000'
 execute ThemNguyenLieu @manl ='nl002' , @tennl =N'Ba Ba' , @dongia ='6800000'
 execute ThemNguyenLieu @manl ='nl003' , @tennl =N'Cua' , @dongia ='22400000'
 execute ThemNguyenLieu @manl ='nl004' , @tennl =N'Bạch Tuộc' , @dongia ='82400000'
 execute ThemNguyenLieu @manl ='nl005' , @tennl =N'Cá voi' , @dongia ='502400000'
 execute ThemNguyenLieu @manl ='nl006' , @tennl =N'Cá Ngừ' , @dongia ='6400000'
 execute ThemNguyenLieu @manl ='nl007' , @tennl =N'Tôm' , @dongia ='24800000'
 go
 -----Them ban-----
 --CREATE PROC ThemBan(@maban varchar(10), @tenban Nvarchar(50) , @makh varchar(10))
 CREATE PROC ThemBan(@maban varchar(10) , @tenban Nvarchar(50) )
AS
BEGIN
	Insert into Ban( MaBan, TenBan )
	Values (@maban, @tenban )
END
go
execute ThemBan @maban= 'b001', @tenban = N'Ban 1' 
execute ThemBan @maban= 'b002', @tenban = N'Ban 2' 
execute ThemBan @maban= 'b003', @tenban = N'Ban 3' 
execute ThemBan @maban= 'b004', @tenban = N'Ban 4' 
execute ThemBan @maban= 'b005', @tenban = N'Ban 5' 
execute ThemBan @maban= 'b006', @tenban = N'Ban 6' 

go

------Them Khach Hang---
CREATE PROC ThemKhachHang (@makh varchar(10) ,@tenkh nvarchar(50) , @sotien varchar(10), @mathanhtoan varchar(10))
AS
BEGIN
	Insert into KhachHang (MaKH , TenKH , SoTien , MaThanhToan)
	Values (@makh , @tenkh , @sotien ,@mathanhtoan)
END
go
execute ThemKhachHang @makh = '0121' , @tenkh = N'Nguyen Van A' , @sotien = '1000000' , @mathanhtoan = 'tt001'
execute ThemKhachHang @makh = '0122' , @tenkh = N'Nguyen Van B' , @sotien = '1650000', @mathanhtoan = 'tt001'
execute ThemKhachHang @makh = '0123' , @tenkh = N'Nguyen Van C' , @sotien = '189000', @mathanhtoan = 'tt002'
execute ThemKhachHang @makh = '0124' , @tenkh = N'Nguyen Van D' , @sotien = '1007700', @mathanhtoan = 'tt003'
execute ThemKhachHang @makh = '0125' , @tenkh = N'Nguyen Van E' , @sotien = '500000', @mathanhtoan = 'tt004'
execute ThemKhachHang @makh = '0126' , @tenkh = N'Nguyen Van G' , @sotien = '400000', @mathanhtoan = 'tt005'
execute ThemKhachHang @makh = '0127' , @tenkh = N'Nguyen Van H' , @sotien = '300000', @mathanhtoan = 'tt006'
execute ThemKhachHang @makh = '0128' , @tenkh = N'Nguyen Van F' , @sotien = '2000000', @mathanhtoan = 'tt001'
go


--------update Khach Hang -------------------
alter PROC EDITKhachHang (@makh varchar(10) ,@tenkh nvarchar(50) , @sotien varchar(10), @mathanhtoan varchar(10)  )
AS
BEGIN
	Update KhachHang
	set TenKH = @tenkh, SoTien = @sotien , MaThanhToan = @mathanhtoan 
	Where MaKH=@makh
END
go
execute EDITKhachHang @makh = '0128' , @tenkh = N'Nguyen Van F' , @sotien = '2000000', @mathanhtoan = 'tt001'
go
select * from KhachHang
select * from HoaDonThanhToan
--Duoc roi loi eo j dau,tai soa no bị vay a

[QuanLySinhVien]
---------update ban------

CREATE PROC EDITBan(@maban varchar(10), @tenban Nvarchar(50) )
AS
BEGIN
	Update Ban
	set TenBan=@tenban 
	Where MaBan=@maban

END
go
execute EDITBan @maban= 'b001', @tenban = N'Ban 10' 
go

------update nguyen lieu----------------------
CREATE PROC EDITNguyenLieu(@manl varchar(10) , @tennl Nvarchar(50) , @dongia varchar(10))
AS
BEGIN
	Update NguyenLieu
	set TenNL = @tennl , DonGia = @dongia
	Where MaNL = @manl
END
go
execute EDITNguyenLieu @manl = 'nl001' , @tennl = N'Cá Chép Vua' ,@dongia = '8400000'
go




------Xoa NguyenLieu----------------------
CREATE PROC DELETENguyenLieu (@manl varchar(10))
AS
BEGIN
	DELETE FROM NguyenLieu Where (MaNL =@manl)
END
go
execute DELETENguyenLieu @manl = 'nl007'
go


-----Xoa ban----
CREATE PROC DELETEBan(@maban varchar(10))
AS
BEGIN
	DELETE FROM Ban Where (MaBan=@maban)
END
go
execute DELETEBan @maban= 'mk006'
go


-------Xoa Khach hang-----
CREATE PROC DELETEKhachHang(@makh varchar(10))
AS
BEGIN
	DELETE FROM KhachHang Where (MaKH = @makh)
END
go
execute DELETEKhachHang @makh = '01345'
go

