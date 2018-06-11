CREATE DATABASE PhongMay
GO

USE PhongMay
GO
-- 151505156
SELECT * FROM dbo.TaiKhoan
CREATE TABLE PhongMay(
	MaPM varchar(15),
	TenPm nvarchar(30),
	SoMay INT,
	CONSTRAINT PK_Phongmay PRIMARY KEY(MaPM)
)
GO

CREATE TABLE May(
	MaMay varchar(15),
	TenMay varchar(20),
	Ram varchar(10),
	HDD varchar(10),
	TinhTrang nvarchar(20),
	HanBH Date,
	SolanBH INT,
	MaPM VARCHAR(15),
	CONSTRAINT PK_May PRIMARY KEY(MaMay)
)
GO
--151505156
SELECT * FROM dbo.TaiKhoan
CREATE TABLE ThietBi(
	MaTB VARCHAR(15),
	TenTB NVARCHAR(20),
	TinhTrang NVARCHAR(20),
	HanBH DATE,
	SolanBH INT,
	MaPM VARCHAR(15),
	CONSTRAINT PK_Thietbi PRIMARY KEY(MaTB)
)
GO

CREATE TABLE NhanVien(
	MaNV VARCHAR(15),
	TenNV NVARCHAR(50),
	GioiTinh NVARCHAR(10) CHECK(GioiTinh IN(N'Nam', N'Nữ')),
	NgaySinh DATE,
	Luong FLOAT,
	HeSoLuong FLOAT,
	ChucVu NVARCHAR(30),
	CONSTRAINT PK_NhanVien PRIMARY KEY(MaNV)
)
GO

CREATE TABLE GiaoVien(
	MaGV VARCHAR(15),
	TenGV NVARCHAR(30),
	CONSTRAINT PK_Giaovien PRIMARY KEY(MaGV)
)
GO

CREATE TABLE Lop(
	MaLop VARCHAR(15),
	MaMH VARCHAR(15),
	MaGV VARCHAR(15),
	CONSTRAINT PK_Lop PRIMARY KEY(MaLop)
)
GO

CREATE TABLE MonHoc(
	MaMH VARCHAR(15),
	TenMH NVARCHAR(50),
	CONSTRAINT PK_Monhoc PRIMARY KEY(MaMH)
)
GO

CREATE TABLE PhieuDK(
	MaPhieuDK VARCHAR(15),
	NgayDK DATE,
	NgayMuon DATE,
	NgayTra DATE,
	MaGV VARCHAR(15),
	MaLop VARCHAR(15),
	CONSTRAINT PK_Phieudk PRIMARY KEY(MaPhieuDK)
)
GO

CREATE TABLE ChiTietDK(
	MaCTDK VARCHAR(15),
	MaPhieuDK VARCHAR(15),
	MaPM VARCHAR(15),
	MaNV VARCHAR(15),
	MaCa VARCHAR(15),
	CONSTRAINT PK_Chitietdk PRIMARY KEY(MaCTDK)
)

CREATE TABLE CA(
	MaCa VARCHAR(15),
	TietBD INT,
	TietKT INT,
	CONSTRAINT PK_Ca PRIMARY KEY(MaCa)
)

CREATE TABLE LichTruc(
	MaLT VARCHAR(15),
	MaPM VARCHAR(15),
	MaNV VARCHAR(15),
	NgayTruc DATE,
	CaTruc NVARCHAR(20),
	TangCa BIT,
	CONSTRAINT PK_Lichtruc PRIMARY KEY(MaLT)
)
GO



ALTER TABLE dbo.LichTruc ALTER COLUMN  NgayTruc DATE

CREATE TABLE PhieuSuaChuaMay(
	MaPhieu VARCHAR(15),
	MaMay VARCHAR(15),
	MaNV VARCHAR(15),
	NgaySua DATE,
	ChiPhi FLOAT,
	CONSTRAINT PK_Phieusuachuamay PRIMARY KEY(MaPhieu)
)
GO

CREATE TABLE PhieuSuaChuaTB(
	MaPhieu VARCHAR(15),
	MaTB VARCHAR(15),
	MaNV VARCHAR(15),
	NgaySua DATE,
	ChiPhi FLOAT,
	CONSTRAINT PK_Phieusuachuatb PRIMARY KEY(MaPhieu)
)
GO
 
CREATE TABLE TaiKhoan(
	TaiKhoan VARCHAR(15) PRIMARY KEY,
	MatKhau VARCHAR(50) NOT NULL,
	CHECKQuyen INT
)

ALTER TABLE dbo.TaiKhoan ADD CONSTRAINT FK_TaiKhoan FOREIGN KEY(TaiKhoan) REFERENCES dbo.NhanVien(MaNV) ON DELETE CASCADE
	ON UPDATE CASCADE



ALTER TABLE dbo.May ADD CONSTRAINT FK_May FOREIGN KEY(MaPM) REFERENCES dbo.PhongMay(MaPM) ON DELETE CASCADE
	ON UPDATE CASCADE


ALTER TABLE dbo.ThietBi ADD CONSTRAINT FK_Thietbi FOREIGN KEY(MaPM) REFERENCES dbo.PhongMay(MaPM)ON DELETE CASCADE
	ON UPDATE CASCADE

ALTER TABLE dbo.Lop ADD CONSTRAINT FK_Lop FOREIGN KEY(MaMH) REFERENCES dbo.MonHoc(MaMH), FOREIGN KEY(MaGV) REFERENCES dbo.GiaoVien(MaGV)ON DELETE CASCADE
	ON UPDATE CASCADE
ALTER TABLE dbo.LichTruc ADD CONSTRAINT FK_Lichtruc FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV), FOREIGN KEY(MaPM) REFERENCES dbo.PhongMay(MaPM)ON DELETE CASCADE
	ON UPDATE CASCADE
ALTER TABLE dbo.PhieuSuaChuaTB ADD CONSTRAINT FK_Phieusuachuatb FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV), FOREIGN KEY(MaTB) REFERENCES dbo.ThietBi(MaTB)ON DELETE CASCADE
	ON UPDATE CASCADE
ALTER TABLE dbo.PhieuSuaChuaMay ADD CONSTRAINT FK_Phieusuachuamay FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV), FOREIGN KEY(MaMay) REFERENCES dbo.May(MaMay)ON DELETE CASCADE
	ON UPDATE CASCADE
ALTER TABLE dbo.PhieuDK ADD CONSTRAINT FK_Phieudk FOREIGN KEY(MaGV) REFERENCES dbo.GiaoVien(MaGV), FOREIGN KEY(MaLop) REFERENCES dbo.Lop(MaLop)ON DELETE CASCADE
	ON UPDATE CASCADE
ALTER TABLE dbo.ChiTietDK ADD CONSTRAINT FK_Chitietdk FOREIGN KEY(MaPhieuDK) REFERENCES dbo.PhieuDK(MaPhieuDK), FOREIGN KEY(MaPM) REFERENCES dbo.PhongMay(MaPM), FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV), FOREIGN KEY (MaCa) REFERENCES dbo.CA(MaCa)ON DELETE CASCADE
	ON UPDATE CASCADE

CREATE PROC XemMH
AS
BEGIN
	SELECT * FROM dbo.MonHoc
END
GO

-- Thêm môn học

CREATE PROC ThemMH (@ma varchar(15), @ten NVARCHAR(50))
AS
BEGIN
	IF @ma IN (SELECT MaMH FROM dbo.MonHoc)
		PRINT N'Môn học đã tồn tại'
	ELSE
		BEGIN
			INSERT dbo.MonHoc
			VALUES  (@ma, @ten)
		END
END
GO


-- Sửa môn học

CREATE PROC SuaMH (@ma varchar(15), @ten NVARCHAR(50))
AS
BEGIN
	IF @ma IN (SELECT MaMH FROM dbo.MonHoc)
		BEGIN
			UPDATE dbo.MonHoc SET TenMH = @ten WHERE MaMH = @ma
		END
	ELSE
		PRINT N'Mã môn học không tồn tại!'
	
END
GO

-- Xóa môn học

CREATE  PROC XoaMH (@ma VARCHAR(15))
AS
BEGIN
	IF @ma IN (SELECT MaMH FROM dbo.Lop)
		PRINT N'Không thể xóa môn học đã được dạy'
	ELSE
		BEGIN
			DELETE dbo.MonHoc WHERE MaMH = @ma
		END
		
END
GO
--Xem lớp

CREATE PROC XemLop
AS
BEGIN
	SELECT * FROM dbo.Lop
END
GO

-- Thêm lớp

CREATE PROC ThemLop (@malop VARCHAR(15), @mamh VARCHAR(15), @magv VARCHAR(15))
AS
BEGIN
	IF @malop IN (SELECT MaLop FROM dbo.Lop)
		PRINT N'Lơp học đã tồn tại'
	ELSE 
		BEGIN
			INSERT dbo.Lop
			        ( MaLop, MaMH, MaGV )
			VALUES  (@malop, @mamh, @magv)
		END
END
GO

-- Sửa lớp

CREATE PROC SuaLop (@malop VARCHAR(15), @mamh VARCHAR(15), @magv VARCHAR(15))
AS
BEGIN
	IF @malop IN (SELECT MaLop FROM dbo.Lop)
		BEGIN
			UPDATE dbo.Lop 
			SET MaMH = @mamh, MaGV = @magv 
			WHERE MaLop = @malop
		END
	ELSE
		PRINT N'Không có lớp học'
END
GO

-- Xáo lớp

CREATE PROC XoaLop (@malop VARCHAR(15))
AS
BEGIN
	IF @malop IN (SELECT MaLop FROM dbo.PhieuDK)
		PRINT N'Lớp học đã đk học, không thể xóa'
	ELSE
		BEGIN
			DELETE dbo.Lop WHERE MaLop = @malop
		END
END
GO
--  Xem Giáo Viên

CREATE PROC XemGV
AS
BEGIN
	SELECT * FROM dbo.GiaoVien
END
GO


-- Thêm Giáo Viên

CREATE PROC ThemGV (@ma VARCHAR(15), @ten VARCHAR(15))
AS
BEGIN
	IF @ma IN (SELECT MaGV FROM dbo.GiaoVien)
		PRINT N'Giáo viên đã tồn tại'
	ELSE 
		BEGIN
			INSERT dbo.GiaoVien
			        ( MaGV, TenGV)
			VALUES  ( @ma, @ten)
		END
END
GO

-- Sửa Giáo Viên

CREATE PROC SuaGV (@ma VARCHAR(15), @ten VARCHAR(15))
AS 
BEGIN
	IF @ma IN (SELECT MaGV FROM dbo.GiaoVien)
		BEGIN
			UPDATE dbo.GiaoVien
			SET TenGV = @ten
			WHERE MaGV = @ma
		END
	ELSE
		PRINT N'Mã giáo viên không tồn tại'
END
GO

-- Xóa Giáo Viên

CREATE PROC XoaGV (@ma VARCHAR(15))
AS
BEGIN
	IF @ma IN (SELECT MaGV FROM dbo.PhieuDK)
		PRINT N'Giáo viên đang dạy không thể xóa'
	ELSE
		BEGIN
			DELETE dbo.GiaoVien
			WHERE MaGV = @ma
		END
END
GO

-- Thêm Phiếu Đăng Ký

CREATE PROC ThemDK(@madk VARCHAR(15), @mapm VARCHAR(15), @magv VARCHAR(15), @manv VARCHAR(15), @malop VARCHAR(15), @Ngaydk NVARCHAR(20), @ngaymuon DATE, @ngaytra DATE, @tiet VARCHAR(10))
AS
BEGIN
	IF @madk IN (SELECT MaPhieuDK FROM dbo.PhieuDK)
		PRINT N'Phiếu đăng ký đã tồn tại'
	ELSE
		BEGIN
			INSERT dbo.PhieuDK
			        ( MaPhieuDK, MaPM, MaGV, MaNV, MaLop, NgayDK, NgayMuon, NgayTra, TietHoc )
			VALUES  ( @madk, @mapm, @magv, @manv, @malop, @Ngaydk, @ngaymuon, @ngaytra, @tiet)
		END
END
GO

-- Sửa Phiếu Đăng Ký

 

-- Xóa Phiếu Đăng ký

CREATE PROC XoaDK (@ma VARCHAR(15))
AS
BEGIN
	DELETE dbo.PhieuDK WHERE MaPhieuDK = @ma
END
----------------------------------------------------------------------------------------------
-- load nhân viên
CREATE PROC LoadNhanVien AS 
BEGIN
	SELECT * FROM dbo.NhanVien 
END
-- thêm nhân viên
  ALTER PROC ThemNV (@MaNV char(10),@TenNV nvarCHAR(30),@GioiTinh nvarchar(5),@NgaySinh date,@Luong float,@HSLuong float,@ChucVu nvarchar(30)) AS 
  BEGIN
	INSERT INTO dbo.NhanVien
	        ( MaNV ,TenNV , GioiTinh ,NgaySinh , Luong ,HeSoLuong,ChucVu)
	VALUES  ( @MaNV,@TenNV,@GioiTinh,@NgaySinh,@Luong,@HSLuong,@ChucVu)
   END
   GO
 
  -- sửa nhân viên
  ALTER PROC suaNV (@MaNV char(10),@TenNV nvarCHAR(30),@GioiTinh nvarchar(5),@NgaySinh date,@Luong float,@HSLuong float,@ChucVu nvarchar(30)) AS 
  Begin
  UPDATE dbo.NhanVien
  SET TenNV = @TenNV , GioiTinh = @gioitinh,NgaySinh = @NgaySinh,Luong = @Luong,HeSoLuong = @HSLuong, ChucVu = @ChucVu
  where dbo.NhanVien.MaNV = @MaNV
  END
  GO
 --Xóa nhân viên
 ALTER PROC xoaNV (@MaNV nchar(10)) AS
	 begin
	 DELETE dbo.NhanVien where  MaNV = @MaNV
	 END
 GO
 
-- Thống kê theo tên phòng máy
CREATE PROC ThongKeNV(@MaPM VARCHAR(15)) AS 
BEGIN
	SELECT nv.* FROM dbo.NhanVien AS nv,dbo.LichTruc AS lt,dbo.PhongMay AS pm
	WHERE  nv.MaNV = lt.MaNV AND lt.MaPM = pm.MaPM and lt.MaPM = @MaPM
END
DROP PROC ThongKeNV
 
ThongKeNV 'PM04'
   
-- Phòng máy
CREATE PROC LoadPM AS 
BEGIN
	SELECT * FROM dbo.PhongMay
END
 

 --Lịch Trưc
 CREATE PROC LoadLichTruc AS 
 BEGIN
	SELECT * FROM dbo.LichTruc
 END
 -- Tài khoản
CREATE PROC DangNhap(@TaiKhoan varchar(15),@MatKhau varchar(50)) AS
BEGIN
	SELECT * FROM dbo.TaiKhoan WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau
end    

CREATE PROC ThemTaiKhoan(@TaiKhoan varchar(15),@MatKhau varchar(50)) AS
BEGIN
	INSERT INTO dbo.TaiKhoan
        ( TaiKhoan, MatKhau )
VALUES  ( @TaiKhoan,@MatKhau )
end    

CREATE PROC XoaTaiKhoan(@TaiKhoan varchar(15)) AS
BEGIN
	DELETE dbo.TaiKhoan WHERE TaiKhoan = @TaiKhoan
end    
SELECT* FROM dbo.NhanVien
CREATE PROC SuaTaiKhoan(@TaiKhoan varchar(15),@MatKhau varchar(50)) AS
BEGIN
	 UPDATE dbo.TaiKhoan
	 SET MatKhau = @MatKhau 
	 WHERE TaiKhoan = @TaiKhoan
end   

SELECT * FROM dbo.TaiKhoan
  
CREATE TRIGGER TrigerThemNV ON  NhanVien FOR 
   INSERT 
   AS 
   DECLARE @ma NCHAR(10) ,@ten NVARCHAR(30), @ngaysinh NCHAR(15),@Gt NVARCHAR(5),@quequan NVARCHAR(30),@maPm NCHAR(10) , @luong INT,@chucvu NVARCHAR(30)
   BEGIN
    SELECT @ma =  MaNV FROM inserted 
	SELECT @ten =  TenNV FROM inserted 
	SELECT @ngaysinh = NgaySinh FROM inserted  
	SELECT @Gt = GioiTinh FROM inserted 
	SELECT @luong = Luong FROM inserted 
	SELECT @chucvu = Inserted.ChucVu FROM inserted 

	PRINT N'Mã nhân viên  : ' +@ma
	PRINT N'Tên Nhân Viên : ' +@ten
	PRINT N'Ngày Sinh  : ' +@ngaysinh
	PRINT N'Giới Tính  : ' +@Gt
	PRINT N'Lương : '  + CONVERT(NVARCHAR(30),@luong) 
	PRINT N'Chức Vụ  : ' +@chucvu
   END
  GO

  INSERT INTO dbo.NhanVien
          ( MaNV , TenNV , GioiTinh ,NgaySinh , Luong , HeSoLuong ,ChucVu)
  VALUES  ( 'NV02' , N'Hoàng Hữu Huyên' ,N'Nam' ,'1997-08-20',  50000000.0 ,1.0 ,  N'Nhân Viên ' )
  -- đưa ra số lượng máy và tên máy có trong phiếu sửa chữa với tên đưa vào : 
 --.nếu tên không tồn tại hoặc rỗng thì sẽ đưa tất cả các mát bị hỏng

   CREATE FUNCTION FUT (@TenMay nvarchar(20)) RETURNS @ThongKe table
  (
		TenMay nvarchar(30),
		slMay int
  )AS 
  BEGIN
  	  IF((@TenMay IS NULL) OR ( @TenMay=' ')  )
	  BEGIN 
	    INSERT INTO @ThongKe
		SELECT TenMay,COUNT(May.MaMay)  FROM dbo.May,dbo.PhieuSuaChuaMay 
		WHERE May.MaMay = PhieuSuaChuaMay.MaMay
		GROUP BY TenMay
	  END
		
	  ELSE
	  BEGIN
	    INSERT INTO @ThongKe
		SELECT TenMay,COUNT(May.TenMay)  FROM dbo.May INNER JOIN dbo.PhieuSuaChuaMay 
		on May.MaMay = PhieuSuaChuaMay.MaMay
		WHERE TenMay = @TenMay
		GROUP BY TenMay
	  END
		RETURN
  END
  Go
  SELECT * FROM FUT('')
  GO
  


CREATE VIEW NhanVienTangCa AS 
SELECT nv.TenNV,nv.Luong,nv.HeSoLuong,lt.TangCa,lt.MaPM FROM dbo.NhanVien AS nv,dbo.LichTruc AS lt
	 WHERE nv.MaNV = lt.MaNV AND lt.TangCa = 1
 
SELECT * FROM NhanVienTangCa
DROP VIEW NhanVienTangCa

  UPDATE NhanVienTangCa SET Luong = Luong + Luong*HeSoLuong*0.01 WHERE TangCa = 1
  SELECT * FROM dbo.NhanVien
  GO
  SELECT* FROM dbo.LichTruc
  GO
  

  SELECT nv.TenNV,nv.Luong,nv.HeSoLuong,lt.TangCa FROM dbo.NhanVien AS nv,dbo.LichTruc AS lt
 WHERE nv.MaNV = lt.MaNV AND lt.TangCa = 1
 SELECT SUM(Luong) AS TongLuong FROM dbo.NhanVien

 --liệt kê các ca thực hành ở có trong trung tâm trong khoảng ngày 1- ngày 2  .proc

 CREATE PROC ThongKe(@NgayM date,@NgayT date)AS
 BEGIN
		SELECT pm.TenPm,ca.MaCa,dk.MaLop,dk.NgayMuon,dk.NgayTra FROM dbo.PhongMay AS pm ,dbo.ChiTietDK AS ct,dbo.PhieuDK AS dk,dbo.CA AS ca
		WHERE pm.MaPM = ct.MaPM AND ct.MaPhieuDK = dk.MaPhieuDK AND ct.MaCa = ca.MaCa AND dk.NgayMuon = @NgayM AND dk.NgayTra=@NgayT
 END
 ThongKe '2018-04-07','2018-04-09'
 

 -- Thiết Bị
 CREATE PROC LoadThietBi AS
 BEGIN
		SELECT * FROM dbo.ThietBi
 END

 CREATE PROC ThemTB( @MaTB varchar(15), @TenTB nvarchar(20),@TinhTrang nvarchar(20),@HanBH date,@SolanBH int,@MaPM varchar(15))AS 
 BEGIN
	INSERT INTO dbo.ThietBi
	        ( MaTB , TenTB ,TinhTrang ,HanBH , SolanBH ,MaPM)
	VALUES  ( @MaTB , @TenTB ,@TinhTrang ,@HanBH , @SolanBH ,@MaPM)
 END
 
 CREATE proc SuaTB( @MaTB varchar(15), @TenTB nvarchar(20),@TinhTrang nvarchar(20),@HanBH date,@SolanBH int,@MaPM varchar(15))AS 
 BEGIN
	UPDATE dbo.ThietBi SET
	TenTB = @TenTB,TinhTrang = @TinhTrang,HanBH =@HanBH,SolanBH= @SolanBH,MaPM=@MaPM WHERE MaTB =@MaTB
 END
 CREATE PROC XoaTB ( @MaTB varchar(15)) AS
  BEGIN
	DELETE FROM dbo.ThietBi WHERE MaTB = @MaTB
 END

 
 SELECT * FROM dbo.NhanVien

 SELECT sum(HeSoLuong*Luong)AS TienLuong FROM dbo.NhanVien

 SELECT * FROM dbo.May
INSERT INTO dbo.May
        ( MaMay ,
          TenMay ,
          Ram ,
          HDD ,
          TinhTrang ,
          HanBH ,
          SolanBH ,
          MaPM
        )
VALUES  ( '' , -- MaMay - varchar(15)
          '' , -- TenMay - varchar(20)
          '' , -- Ram - varchar(10)
          '' , -- HDD - varchar(10)
          N'' , -- TinhTrang - nvarchar(20)
          GETDATE() , -- HanBH - date
          0 , -- SolanBH - int
          ''  -- MaPM - varchar(15)
        )


CREATE PROC LoadMay AS
BEGIN
	SELECT * FROM dbo.May
END


UPDATE dbo.May
SET HDD = 'Win8.1' WHERE Ram ='4GB'
SELECT * FROM dbo.LichTruc

SELECT * FROM dbo.NhanVien nv, dbo.LichTruc lt WHERE nv.MaNV = lt.MaNV AND lt.TangCa = 1

CREATE VIEW NhanVienTangCa as
SELECT * FROM dbo.NhanVien nv,dbo.LichTruc lt
 WHERE nv.MaNV = lt.MaNV

 SELECT nv.*,lt.TangCa FROM dbo.NhanVien nv,dbo.LichTruc lt WHERE nv.MaNV = lt.MaNV 

 SELECT (nv.Luong + nv.Luong*nv.HeSoLuong*0.01*lt.TangCa) AS LuongThang , nv.* ,lt.TangCa FROM dbo.NhanVien nv ,dbo.LichTruc lt 
 WHERE nv.MaNV ='1313222' AND lt.MaNV = nv.MaNV

 CREATE VIEW ThongTinCaNhan AS
  SELECT nv.* ,lt.TangCa,(nv.Luong + nv.Luong*nv.HeSoLuong*0.01*lt.TangCa) AS LuongThang  FROM dbo.NhanVien nv ,dbo.LichTruc lt 
 WHERE nv.MaNV ='1354222'

 SELECT (nv.Luong + nv.Luong*nv.HeSoLuong*0.01) AS LuongThang , nv.*  FROM dbo.NhanVien nv
 WHERE nv.MaNV ='1313222' 
 

CREATE PROC KiemTraCaTruc(@CaTruc nvarchar(20),@NgayTruc date)AS
BEGIN
	SELECT * FROM dbo.LichTruc WHERE CaTruc= @CaTruc AND NgayTruc =@NgayTruc
END

 
 
SELECT * FROM dbo.TaiKhoan

CREATE PROC SuaMatKhau(@TaiKhoan varchar(15) ,@MatKhau varchar(15))AS
BEGIN
	UPDATE dbo.TaiKhoan
	 SET MatKhau =@MatKhau WHERE TaiKhoan =@TaiKhoan
END

UPDATE dbo.TaiKhoan
	 SET Quyen = 0 WHERE TaiKhoan = 15153346

CREATE PROC PhanQuyen(@TaiKhoan varchar(15))AS
BEGIN
	SELECT Quyen FROM dbo.TaiKhoan  WHERE TaiKhoan =@TaiKhoan
END


CREATE PROC LayTen(@MaNV varchar(15))AS
BEGIN
	SELECT TenNV FROM dbo.NhanVien WHERE MaNV = @MaNV
END

 CREATE PROC ThemMT( @MaMay varchar(15),@TenMay varchar(20), @Ram varchar(10),@HDD varchar(10),@TinhTrang nvarchar(20),@HanBH date,@SolanBH int,@MaPM varchar(15))AS
 BEGIN
	INSERT INTO dbo.May ( MaMay ,TenMay , Ram ,HDD ,TinhTrang ,HanBH ,SolanBH ,MaPM)
	VALUES  ( @MaMay ,@TenMay , @Ram ,@HDD ,@TinhTrang ,@HanBH ,@SolanBH ,@MaPM) 
 end
 CREATE PROC SuaMT( @MaMay varchar(15),@TenMay varchar(20), @Ram varchar(10),@HDD varchar(10),@TinhTrang nvarchar(20),@HanBH date,@SolanBH int,@MaPM varchar(15))AS
 BEGIN
	UPDATE dbo.May
	SET TenMay = @TenMay,Ram = @Ram,HDD = @HDD,TinhTrang=@TinhTrang,HanBH = @HanBH,SolanBH = @SolanBH,MaPM=@MaPM
	WHERE MaMay = @MaMay
 END
 
 CREATE PROC XoaMT (@MaMay varchar(15))AS
 BEGIN
 	DELETE dbo.May WHERE MaMay = @MaMay
 END

 -- phiếu thiết bị
CREATE PROC ThemPSCThietBi(@MaPhieu varchar(15), @MaTB varchar(15), @MaNV varchar(15), @NgaySua date, @ChiPhi float)AS
BEGIN
	INSERT INTO dbo.PhieuSuaChuaTB
	        ( MaPhieu, MaTB, MaNV, NgaySua, ChiPhi )
	VALUES (@MaPhieu, @MaTB, @MaNV, @NgaySua, @ChiPhi )  
END
CREATE PROC SuaPSCThietBi(@MaPhieu varchar(15), @MaTB varchar(15), @MaNV varchar(15), @NgaySua date, @ChiPhi float)AS
BEGIN
	 UPDATE dbo.PhieuSuaChuaTB
	SET MaTB= @MaTB,MaNV= @MaNV,NgaySua= @NgaySua,ChiPhi = @ChiPhi WHERE MaPhieu = @MaPhieu
END
CREATE PROC XoaPSCThietBi(@MaPhieu varchar(15))AS
BEGIN
	DELETE dbo.PhieuSuaChuaTB WHERE MaPhieu = @MaPhieu
END
CREATE PROC LoadPSCThietBi AS
BEGIN
	SELECT * FROM dbo.PhieuSuaChuaTB
END

--  phiếu máy tính
CREATE PROC ThemPSCMayTinh(@MaPhieu varchar(15), @MaMay varchar(15), @MaNV varchar(15), @NgaySua date, @ChiPhi float)AS
BEGIN
	INSERT INTO dbo.PhieuSuaChuaMay
	VALUES (@MaPhieu, @MaMay, @MaNV, @NgaySua, @ChiPhi )  
END
CREATE PROC SuaPSCMayTinh(@MaPhieu varchar(15), @MaMay varchar(15), @MaNV varchar(15), @NgaySua date, @ChiPhi float)AS
BEGIN
	 UPDATE dbo.PhieuSuaChuaMay
	SET MaMay= @MaMay,MaNV= @MaNV,NgaySua= @NgaySua,ChiPhi = @ChiPhi WHERE MaPhieu = @MaPhieu
END
CREATE PROC XoaPSCMayTinh(@MaPhieu varchar(15))AS
BEGIN
	DELETE dbo.PhieuSuaChuaMay WHERE MaPhieu = @MaPhieu
END
CREATE PROC LoadPSCMayTinh AS
BEGIN
	SELECT * FROM dbo.PhieuSuaChuaMay
END

-- Lịch Trực
CREATE PROC ThemLT( @MaLT varchar(15),@MaPM varchar(15), @MaNV varchar(15),@NgayTruc date, @CaTruc nvarchar(20),@TangCa int)AS
BEGIN
	INSERT INTO dbo.LichTruc( MaLT ,MaPM , MaNV ,NgayTruc , CaTruc ,TangCa)
	VALUES  ( @MaLT ,@MaPM , @MaNV ,@NgayTruc , @CaTruc ,@TangCa)
END

CREATE PROC SuaLT( @MaLT varchar(15),@MaPM varchar(15), @MaNV varchar(15),@NgayTruc date, @CaTruc nvarchar(20),@TangCa int)AS
BEGIN
	UPDATE dbo.LichTruc
	SET  MaPM=@MaPM , MaNV = @MaNV ,NgayTruc = @NgayTruc ,CaTruc= @CaTruc ,TangCa = @TangCa WHERE MaLT =@MaLT
END

CREATE PROC XoaLT( @MaLT varchar(15))AS
BEGIN
	DELETE FROM dbo.LichTruc WHERE MaLT = @MaLT
END

INSERT INTO dbo.PhieuSuaChuaMay
        ( MaPhieu, MaMay, MaNV, NgaySua, ChiPhi )
VALUES  ( 'Phieu 01', -- MaPhieu - varchar(15)
          'xyz', -- MaMay - varchar(15)
          '15153346 ', -- MaNV - varchar(15)
          '2017-09-08', -- NgaySua - date
          50000  -- ChiPhi - float
          )

		  SELECT * FROM dbo.TaiKhoan