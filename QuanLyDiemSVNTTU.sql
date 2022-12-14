GO
USE MASTER
GO

IF EXISTS (SELECT NAME FROM MASTER..SYSDATABASES WHERE NAME ='QLDIEMTHI')
	DROP DATABASE QLDIEMTHI
GO
GO

CREATE DATABASE QLDIEMTHI
GO

USE QLDIEMTHI
GO

CREATE TABLE NGANH
(
	MaNganh		NVARCHAR (20)	PRIMARY KEY NOT NULL,
	TenNganh	NVARCHAR (256)	NOT NULL
)
GO

CREATE TABLE  LOP
(
	MaLop		NVARCHAR (20)	PRIMARY KEY NOT NULL, 
	TenLop		NVARCHAR (256)	NOT NULL,
	MaNganh		NVARCHAR (20)	NOT NULL
	CONSTRAINT fk_NGANH_LOP FOREIGN KEY (MaNganh) REFERENCES NGANH (MaNganh)
)
GO

CREATE TABLE GIANGVIEN
(
    MaGV		NVARCHAR (20) PRIMARY KEY	NOT NULL,
    TenGV       NVARCHAR (30) NULL,
    GioiTinh	NVARCHAR (10) NULL,
    Phone		NVARCHAR (15) NULL,
    Email		NVARCHAR (20) NULL,
    PhanLoaiGV	NVARCHAR (20) NULL,
    Anh			IMAGE           NULL,
)
GO

CREATE TABLE MONHOC
(
	MaMH		NVARCHAR (20)	PRIMARY KEY NOT NULL, 
	TenMH		NVARCHAR (256)	NOT NULL,
	MaGV		NVARCHAR (20)	NOT NULL,
	HocKy		NVARCHAR (10)	NOT NULL,
	MaNganh		NVARCHAR (20)	NOT NULL,
	TinChi		NVARCHAR (10)	NOT NULL,
	CONSTRAINT fk_MH_GV FOREIGN KEY (MaGV) REFERENCES GIANGVIEN (MaGV)
)
GO


CREATE TABLE SINHVIEN
(
	MaSV		NVARCHAR (20)	PRIMARY KEY NOT NULL,
	HoTen		NVARCHAR (256)	NOT NULL,
	NgaySinh	DATETIME		NOT NULL,
	GioiTinh	NVARCHAR (20)	NOT NULL,
	DiaChi		NVARCHAR (256)	NOT NULL,
	MaLop		NVARCHAR (20)	NOT NULL,
	Anh			IMAGE           NULL,
	CONSTRAINT fk_SINHVIEN_LOP FOREIGN KEY (MaLop) REFERENCES LOP (MaLop)
)
GO


CREATE TABLE LOGIN
(
	TenDN		NVARCHAR (50)	PRIMARY KEY NOT NULL,
	MatKhau		NVARCHAR (30)	NOT NULL,
	HoTen		NVARCHAR (256)	NOT NULL,
	GioiTinh	NVARCHAR (10)	NOT NULL,
	Email		NVARCHAR (50)	NOT NULL,
	Quyen		NVARCHAR (50)	NOT NULL
)
GO

CREATE TABLE DIEMTHI
(
	MaSV		NVARCHAR (20)	NOT NULL,
	HoTen		NVARCHAR (256)	NOT NULL,
	MaLop		NVARCHAR (20)	NOT NULL,
	MaMH		NVARCHAR (20)	NOT NULL,
	DiemLT		FLOAT			NULL,
	DiemTH		FLOAT			NULL,
	DiemThi   	FLOAT			NULL,
	DiemTK		FLOAT			NULL,
	HanhKiem	NVARCHAR (20)	NOT NULL,
	HocKy		INT				NOT NULL,
	GhiChu		NVARCHAR (50)	NULL,
	CONSTRAINT PK_DIEMTHI	PRIMARY KEY (MaSV, MaMH),
	CONSTRAINT	FK_DT_SV	FOREIGN KEY(MaSV) REFERENCES SINHVIEN(MaSV),
	CONSTRAINT	FK_DT_MON	FOREIGN KEY(MaMH) REFERENCES MONHOC(MaMH)
)
GO

CREATE TABLE DIEMTHILAI
(
	MaSV		NVARCHAR (20) 	PRIMARY KEY NOT NULL ,
	HoTen		NVARCHAR (50)	NOT NULL,
	MaLop		NVARCHAR (20)	NOT NULL,
	TenMH		NVARCHAR (256)	NOT NULL,
	DiemLT		FLOAT			NULL,
	DiemTH		FLOAT			NULL,
	DiemThiLai	FLOAT			NULL,
	HocKy		NVARCHAR (10)	NOT NULL,
	
) ON [PRIMARY]
GO

CREATE TABLE DIEMHOCLAI
(
	MaSV		NVARCHAR (20)	PRIMARY KEY NOT NULL,
	HoTen		NVARCHAR (50)	NOT NULL,
	MaLop		NVARCHAR (20)	NOT NULL,
	TenMH		NVARCHAR (256)	NOT NULL,
	DiemLT		FLOAT			NULL,
	DiemTH		FLOAT			NULL,
	DiemHocLai	FLOAT			NULL,
	HocKy		NVARCHAR (10)	NOT NULL,
	
) ON [PRIMARY]
GO





