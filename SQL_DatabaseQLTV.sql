CREATE DATABASE QuanLyThuVien
USE QuanLyThuVien
create table DOCGIA
(	MADOCGIA  char (10) primary key,
	HOTEN	  Nvarchar(30),
	NGAYSINH  smalldatetime,
	QUEQUAN   Nvarchar(30),
	DIACHI    Nvarchar(30),
	CMND      Nvarchar(30),
	MSSV      Nvarchar(30),
	Email	  Nvarchar(30),
	TENTKDG   Nvarchar(30),
)
create table THUTHU
(
	MATHUTHU  char (10) primary key,
	HOTEN	  Nvarchar(30),
	NGAYSINH  smalldatetime,
	QUEQUAN   Nvarchar(30),
	DIACHI    Nvarchar(30),
	CMND      Nvarchar(30),
	Email	  Nvarchar(30),
	TENTKTT   Nvarchar(30),
	NGVL      Smalldatetime,
)
create table THUKHO
(
	MATHUKHO  char (10) primary key,
	HOTEN	  Nvarchar(30),
	NGAYSINH  smalldatetime,
	QUEQUAN   Nvarchar(30),
	DIACHI    Nvarchar(30),
	CMND      Nvarchar(30),
	Email	  Nvarchar(30),
	TENTKTK   Nvarchar(30),
	NGVL      Smalldatetime,
)
create table TAIKHOAN
(
	MASO char (10), 
	TENTK Nvarchar(30)primary key,
	Email	  Nvarchar(30),
	MATKHAU Nvarchar(50), 
)
	/*ngay sinh khong ???c nh? h?n ngày hi?n hành*/
ALTER TABLE TAIKHOAN ADD CONSTRAINT FK_MS_MGD FOREIGN KEY (MASO) REFERENCES DOCGIA(MADOCGIA);
					-- CONSTRAINT FK_MS_MTT FOREIGN KEY (MASO) REFERENCES THUTHU(MATHUTHU),
					--CONSTRAINT FK_MS_MTK FOREIGN KEY (MASO) REFERENCES THUKHO(MATHUKHO);
	
ALTER TABLE DOCGIA	ADD CONSTRAINT ck_ngaysinhDG CHECK (NGAYSINH <GETDATE())
ALTER TABLE THUTHU	ADD CONSTRAINT ck_ngaysinhTT CHECK (NGAYSINH <GETDATE())
ALTER TABLE THUKHO	ADD CONSTRAINT ck_ngaysinhTK CHECK (NGAYSINH <GETDATE())
ALTER TABLE DOCGIA ADD GIOITINH varchar(3);
ALTER TABLE THUKHO ADD GIOITINH varchar(3);
ALTER TABLE THUTHU ADD GIOITINH varchar(3);

ALTER TABLE DOCGIA ADD NGAYTAO smalldatetime;
ALTER TABLE THUKHO ADD NGAYTAO smalldatetime;
ALTER TABLE THUTHU ADD NGAYTAO smalldatetime;

ALTER TABLE DOCGIA ADD SDT varchar(15);
ALTER TABLE THUKHO ADD SDT varchar(15);
ALTER TABLE THUTHU ADD SDT varchar(15);
/*kiem tra ten taikhoan c?a doc gia khong ???c trùng v?i c?a th? th? */
CREATE TRIGGER CHECK_TKDG
 ON DOCGIA
 FOR INSERT,UPDATE
 AS
 BEGIN
 IF (UPDATE(TENTKDG))
 BEGIN
 DECLARE @TENTKDG Nvarchar(30),@TENTK Nvarchar(30)
	SET @TENTKDG=(select TENTKDG from inserted)
	if(@TENTKDG IN(SELECT TENTK FROM TAIKHOAN)) 
	BEGIN
		print ' Ten tai khoan doc gia khong duoc trung nhau'
		rollback TRAN	
	END
 END
END
--lay ma so lon nhat hien hanh
CREATE FUNCTION DBO.FuLayMaSo()
returns nvarchar(30)
AS 
BEGIN
RETURN 
	(select TOP 1 MADOCGIA
	FROM DOCGIA
	GROUP BY MADOCGIA
	order by MADOCGIA desc)
END;

--Code procedure
USE [QuanLyThuVien]
GO
/****** Object:  StoredProcedure [dbo].[ThemDocGia]    Script Date: 2/6/2017 2:32:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[ThemDocGia]
@MADOCGIA Nvarchar(30),
@HOTEN Nvarchar(30),
@NGAYSINH smalldatetime,
@QUEQUAN Nvarchar(30),
@DIACHI Nvarchar(30),
@CMNN Nvarchar(30),
@MSSV Nvarchar(30),
@Email Nvarchar(30),
@TENTKDG Nvarchar(30),
@GIOITINH varchar(3),
@NGAYTAO smalldatetime,
@MATKHAU Nvarchar(30),
@SDT Nvarchar(15)
as 
begin
	insert into DOCGIA(MADOCGIA,HOTEN,NGAYSINH,QUEQUAN,DIACHI,CMND,MSSV,Email,TENTKDG,GIOITINH,NGAYTAO, SDT)
	VALUES(@MADOCGIA,@HOTEN,@NGAYSINH,@QUEQUAN,@DIACHI,@CMNN,@MSSV,@Email,@TENTKDG,@GIOITINH,@NGAYTAO, @SDT);
end
BEGIN
	insert into TAIKHOAN(MASO, TENTK, Email, MATKHAU)
	values(@MADOCGIA,@TENTKDG,@Email,@MATKHAU);
END


--Kiem tra tai khoan co ton tai hay khong
CREATE FUNCTION dbo.TonTaiTK(@TENTK NVARCHAR(30), @MATKHAU NVARCHAR(30))
returns nvarchar(30)
AS 
BEGIN
	DECLARE @RETURN NVARCHAR(30)
	IF(@TENTK IN(SELECT TENTK FROM TAIKHOAN) AND @MATKHAU IN (SELECT MATKHAU FROM TAIKHOAN))
		BEGIN
			SET @RETURN = (SELECT MASO FROM TAIKHOAN WHERE TENTK = @TENTK AND MATKHAU = @MATKHAU)
		END
	ELSE 
		BEGIN
			SET @RETURN = 'error';
		END
		RETURN @RETURN;
END;
