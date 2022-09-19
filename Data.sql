USE QLDIEMTHI
GO

SET DATEFORMAT dmy
GO

---------------DỮ LIỆU BẢNG NGANH-----------------
INSERT INTO NGANH (MaNganh, TenNganh)
	SELECT N'QTM', N'Quản Trị Mạng'
INSERT INTO NGANH(MaNganh, TenNganh)
	SELECT N'LT', N'Lập Trình'

--------------DỮ LIỆU BẢNG LOP-------------
INSERT INTO LOP (MaLop, TenLop, MaNganh)
	SELECT 'DTH01', '18DTH1A', 'QTM'
INSERT INTO LOP (MaLop, TenLop, MaNganh)
	SELECT 'DTH02', '18DTH1B', 'QTM'
INSERT INTO LOP (MaLop, TenLop, MaNganh)
	SELECT 'DTH03', '18DTH1C', 'LT'
INSERT INTO LOP (MaLop, TenLop, MaNganh)
	SELECT 'DTH05', '18DTH2A', 'QTM'
INSERT INTO LOP (MaLop, TenLop, MaNganh)
	SELECT 'DTH06', '18DTH2B', 'LT'
INSERT INTO LOP (MaLop, TenLop, MaNganh)
	SELECT 'DTH07', '18DTH2C', 'LT'
INSERT INTO LOP (MaLop, TenLop, MaNganh)
	SELECT 'DTH08' ,'19DTH1A', 'LT'
INSERT INTO LOP (MaLop, TenLop, MaNganh)
	SELECT 'DTH09', '19DTH1B', 'QTM'
INSERT INTO LOP (MaLop, TenLop, MaNganh)
	SELECT 'DTH10', '19DTH1C', 'LT'
INSERT INTO LOP (MaLop, TenLop, MaNganh)
	SELECT 'DTH11', '19DTH2A', 'LT'
INSERT INTO LOP (MaLop, TenLop, MaNganh)
	SELECT 'DTH12', '19DTH2B', 'QTM'
INSERT INTO LOP (MaLop, TenLop, MaNganh)
	SELECT 'DTH13', '19DTH2C', 'LT'
INSERT INTO LOP (MaLop, TenLop, MaNganh)
	SELECT 'DTH14', '20DTH1A', 'QTM'
INSERT INTO LOP (MaLop, TenLop, MaNganh)
	SELECT 'DTH15', '20DTH1B', 'QTM'
INSERT INTO LOP (MaLop, TenLop, MaNganh)
	SELECT 'DTH16', '20DTH1C', 'LT'
INSERT INTO LOP (MaLop, TenLop, MaNganh)
	SELECT 'DTH17', '20DTH2A', 'LT'
INSERT INTO LOP (MaLop, TenLop, MaNganh)
	SELECT 'DTH18', '20DTH2B', 'LT'
INSERT INTO LOP (MaLop, TenLop, MaNganh)
	SELECT 'DTH19', '20DTH2A', 'LT'
INSERT INTO LOP (MaLop, TenLop, MaNganh)
	SELECT 'DTH20', '20DTH2C', 'QTM'


------------------------------DỮ LIỆU BANG GIANGVIEN----------------------------------------------------
INSERT INTO GIANGVIEN (MaGV, TenGV, GioiTinh, Phone, Email, PhanLoaiGV, Anh)
	SELECT 'nxcuong',N'Nguyễn Xuân Cường',N'Nam','0913119490','nxcuong@ntt.edu.vn',N'Thạc Sĩ','cuong.png'
INSERT INTO GIANGVIEN (MaGV, TenGV, GioiTinh, Phone, Email, PhanLoaiGV, Anh)
	SELECT 'ghcon',N'Giang Hào Côn',N'Nam','0913746401','ghcon@ntt.edu.vn',N'Thạc Sĩ','con.png'
INSERT INTO GIANGVIEN (MaGV, TenGV, GioiTinh, Phone, Email, PhanLoaiGV, Anh)
	SELECT 'pvdang',N'Phạm Văn Đăng',N'Nam','0903648212','pvdang@ntt.edu.vn',N'Thạc Sĩ','dang.png'
INSERT INTO GIANGVIEN (MaGV, TenGV, GioiTinh, Phone, Email, PhanLoaiGV, Anh)
	SELECT 'nthsinh',N'Nguyễn Thị Hoàn Sinh',N'Nữ','0983660766','nthsinh@ntt.edu.vn',N'Thạc Sĩ','sinh.png'
INSERT INTO GIANGVIEN (MaGV, TenGV, GioiTinh, Phone, Email, PhanLoaiGV, Anh)
	SELECT 'tnhi',N'Thái Trúc Nhi',N'Nữ','0907155949','ttnhi@ntt.edu.vn',N'Cô','nhi.png'
INSERT INTO GIANGVIEN (MaGV, TenGV, GioiTinh, Phone, Email, PhanLoaiGV, Anh)
	SELECT 'lmlong', N'Lê Mậu Long',N'Nam','0903716548','lmlong@ntt.edu.vn',N'Tiến Sĩ','long.png'
INSERT INTO GIANGVIEN (MaGV, TenGV, GioiTinh, Phone, Email, PhanLoaiGV, Anh)
	SELECT 'nthong', N'Nguyễn Thị Hồng',N'Nữ','0369942982','nthong@ntt.edu.vn',N'Thạc Sĩ','hong.png'
INSERT INTO GIANGVIEN (MaGV, TenGV, GioiTinh, Phone, Email, PhanLoaiGV, Anh)
	SELECT 'ntpdung',N'Nguyễn Thị Phong Dung',N'Nữ','0908966656','ntpdung@ntt.edu.vn',N'Thạc Sĩ','dung.png'
INSERT INTO GIANGVIEN (MaGV, TenGV, GioiTinh, Phone, Email, PhanLoaiGV, Anh)
	SELECT 'dhnam',N'Đỗ Hoàng Nam',N'Nam','0979739961','dhnam@ntt.edu.vn',N'Thạc Sĩ','nam.png'
INSERT INTO GIANGVIEN (MaGV, TenGV, GioiTinh, Phone, Email, PhanLoaiGV, Anh)
	SELECT 'nkquoc',N'Nguyễn Kim Quốc',N'Nam','07896541235','nkquoc@ntt.edu.vn',N'Thạc Sĩ','quoc.png'
INSERT INTO GIANGVIEN (MaGV, TenGV, GioiTinh, Phone, Email, PhanLoaiGV, Anh)
	SELECT 'pdtai',N'Phạm Đình Tài',N'Nam','0904562358','pdtai@ntt.edu.vn',N'Thạc Sĩ','tai.png'
INSERT INTO GIANGVIEN (MaGV, TenGV, GioiTinh, Phone, Email, PhanLoaiGV, Anh)
	SELECT 'nvthanh',N'Nguyễn Văn Thành',N'Nam','0979739961','nvthanh@ntt.edu.vn',N'Thạc Sĩ','thanh.png'
INSERT INTO GIANGVIEN (MaGV, TenGV, GioiTinh, Phone, Email, PhanLoaiGV, Anh)
	SELECT 'tthyen',N'Trần Thị Hồng Yến',N'Nữ','0979739961','tthyen@ntt.edu.vn',N'Thạc Sĩ','yen.png'
INSERT INTO GIANGVIEN (MaGV, TenGV, GioiTinh, Phone, Email, PhanLoaiGV, Anh)
	SELECT 'dmtuan',N'Dương Minh Tuấn',N'Nam','0987456123','dmtuan@ntt.edu.vn',N'Thạc Sĩ','tuan.png'
INSERT INTO GIANGVIEN (MaGV, TenGV, GioiTinh, Phone, Email, PhanLoaiGV, Anh)
	SELECT 'nmhuy',N'Nguyễn Mai Huy',N'Nam','0775647250','nmhuy@ntt.edu.vn',N'Thạc Sĩ','huy.png'
INSERT INTO GIANGVIEN (MaGV, TenGV, GioiTinh, Phone, Email, PhanLoaiGV, Anh)
	SELECT 'vxchi',N'Vương Xuân Chí',N'Nam','0979739961','vxchi@ntt.edu.vn',N'Thạc Sĩ','chi.png'


---------DỮ LIỆU BẢNG MONHOC-------------------------------------------------------------------------

--------------------DỮ LIỆU BẢNG MÔN HỌC CHUYÊN NGÀNH LẬP TRÌNH----------------------------------------
INSERT INTO MONHOC(MaMH, TenMH, MaGV, HocKy, MaNganh, TinChi)
	SELECT 'LT-KTTMT', N'Kiến trúc máy tính','nvthanh', 'HK1', 'LT', 3
INSERT INTO MONHOC(MaMH, TenMH, MaGV, HocKy, MaNganh, TinChi)
	SELECT 'LT-LTDT', N'Lý thuyết đồ thị', 'lmlong', 'HK1', 'LT', 2
INSERT INTO MONHOC(MaMH, TenMH, MaGV, HocKy, MaNganh, TinChi)
	SELECT 'LT-NMCNTT', N'Nhập môn Công nghệ thông tin', N'nxcuong', 'HK1', 'LT', 3
INSERT INTO MONHOC(MaMH, TenMH, MaGV, HocKy, MaNganh, TinChi)
	SELECT 'LT-KTLT', N'Kỹ thuật lập trình', 'nthong', 'HK2', 'LT', 3
INSERT INTO MONHOC(MaMH, TenMH, MaGV, HocKy, MaNganh, TinChi)
	SELECT 'LT-CSDL', N'Cơ sở dữ liệu', 'tnhi', 'HK2', 'LT', 3
INSERT INTO MONHOC(MaMH, TenMH, MaGV, HocKy, MaNganh, TinChi)
	SELECT 'LT-HQTCSDL', N'Hệ quản trị cơ sở dữ liệu', 'tnhi', 'HK2', 'LT', 3
INSERT INTO MONHOC(MaMH, TenMH, MaGV, HocKy, MaNganh, TinChi)
	SELECT 'LT-TKW', N'Thiết kế web', 'tthyen', 'HK3', 'LT',2
INSERT INTO MONHOC(MaMH, TenMH, MaGV, HocKy, MaNganh, TinChi)
	SELECT 'LT-CTDL&DT', N'Cấu trúc dữ liệu và giải thuật', N'pvdang', 'HK3', 'LT', 3
INSERT INTO MONHOC(MaMH, TenMH, MaGV, HocKy, MaNganh, TinChi)
	SELECT 'LT-HĐH', N'Hệ Điều hành', N'vxchi', 'HK3', 'LT',2
INSERT INTO MONHOC(MaMH, TenMH, MaGV, HocKy, MaNganh, TinChi)
	SELECT 'LT-LTW', N'Lập trình Web', 'tthyen', 'HK3', 'LT', 4
INSERT INTO MONHOC(MaMH, TenMH, MaGV, HocKy, MaNganh, TinChi)
	SELECT 'LT-ĐACSKTPM', N'Đồ án cơ sở KTPM', 'pvdang', 'HK4', 'LT', 5
INSERT INTO MONHOC(MaMH, TenMH, MaGV, HocKy, MaNganh, TinChi)
	SELECT 'LT-CĐNET', N'Chuyên đề.NET', 'nmhuy', 'HK4', 'LT', 4
INSERT INTO MONHOC(MaMH, TenMH, MaGV, HocKy, MaNganh, TinChi)
	SELECT 'LT-HTTTQL', N'Hệ thống thông tin quản lý', 'pvdang', 'HK4', 'LT', 3


--------------------MÔN HỌC CHUYÊN NGÀNH QUẢN TRỊ MẠNG-----------------------------------
INSERT INTO MONHOC(MaMH, TenMH, MaGV, HocKy, MaNganh, TinChi)
	SELECT 'QTM-PTTKHTM', N'Phân tích thiết kế hệ thống mạng', 'nvthanh', 'HK1', 'QTM', 3
INSERT INTO MONHOC(MaMH, TenMH, MaGV, HocKy, MaNganh, TinChi)
	SELECT 'QTM-LTM', N'Lập trình mạng', N'ntpdung', 'HK2', 'QTM', 3
INSERT INTO MONHOC(MaMH, TenMH, MaGV, HocKy, MaNganh, TinChi)
	SELECT 'QTM-ANM', N'An ninh Mạng', 'dmtuan', 'HK3', 'QTM', 2
INSERT INTO MONHOC(MaMH, TenMH, MaGV, HocKy, MaNganh, TinChi)
	SELECT 'QTM-TKHTM', N'Triển khai hệ thống mạng', 'pdtai', 'HK3', 'QTM', 3
INSERT INTO MONHOC(MaMH, TenMH, MaGV, HocKy, MaNganh, TinChi)
	SELECT 'QTM-ĐGHNM', N'Đánh giá hiệu năng mạng', 'ntpdung', 'HK3', 'QTM', 4
INSERT INTO MONHOC(MaMH, TenMH, MaGV, HocKy, MaNganh, TinChi)
	SELECT 'QTM-CĐCS1', N'Chuyên đề chuyên sâu KTPM 1', 'pdtai', 'HK4', 'QTM', 5
INSERT INTO MONHOC(MaMH, TenMH, MaGV, HocKy, MaNganh, TinChi)
	SELECT 'QTM-ĐTĐM', N'Điện toán đám mây', 'nkquoc', 'HK4', 'QTM', 3
INSERT INTO MONHOC(MaMH, TenMH, MaGV, HocKy, MaNganh, TinChi)
	SELECT 'QTM-LTN', N'Lập trình nhúng', N'nkquoc', 'HK4', 'QTM', 4



--------------------------	DỮ LIỆU BẢNG SINH VIÊN------------------------------------------
INSERT INTO SINHVIEN (MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, MaLop, Anh)
	SELECT '18115461', N'Phạm Văn Châu', '06/09/1991', N'Nam', N'Hà Nội', 'DTH01', '0'
INSERT INTO SINHVIEN (MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, MaLop, Anh)
	SELECT '18115462', N'Vũ Khắc Chung', '05/02/2000', N'Nam', N'Hồ Chí Minh', 'DTH01', '0'
INSERT INTO SINHVIEN (MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, MaLop, Anh)
	SELECT '18115463', N'Lý Trung Đức', '19/06/2000', N'Nam', N'Kiên Giang', 'DTH02', '0'
INSERT INTO SINHVIEN (MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, MaLop, Anh)
	SELECT '18115464', N'Nguyễn Thị Thu Hiền', '30/11/2001', N'Nữ', N'Bình Định', 'DTH03', '0'
INSERT INTO SINHVIEN (MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, MaLop, Anh)
	SELECT '18115465', N'Lê Thị Ngọc Bích', '13/06/2001', N'Nữ', N'Cần Thơ', 'DTH07', '0'
INSERT INTO SINHVIEN (MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, MaLop, Anh)
	SELECT '18115466', N'Nguyễn Thị Nhung', '10/10/2001', N'Nữ', N'Bế Tre', 'DTH10', '0'
INSERT INTO SINHVIEN (MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, MaLop, Anh)
	SELECT '18115467', N'Trần Hoài Nam', '13/06/2002', N'Nam', N'Lào Cai', 'DTH19', '0'
INSERT INTO SINHVIEN (MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, MaLop, Anh)
	SELECT '18115468', N'Lưu Vũ Ninh', '30/01/2000', N'Nam', N'Hà Nội', 'DTH14', '0'
INSERT INTO SINHVIEN (MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, MaLop, Anh)
	SELECT '18115469', N'Lưu Thị Quỳnh Như', '12/05/2002', N'Nữ', N'Hồ Chí Minh', 'DTH05', '0'
INSERT INTO SINHVIEN (MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, MaLop, Anh)
	SELECT '181154610', N'Ngô Gia Minh ', '20/08/2001', N'Nam', N'Quy Nhơn', 'DTH05', '0'
INSERT INTO SINHVIEN (MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, MaLop, Anh)
	SELECT '181154611', N'Phan Bảo Anh', '05/05/2000', N'Nữ', N'Hồ Chí Minh', 'DTH15', '0'
INSERT INTO SINHVIEN (MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, MaLop, Anh)
	SELECT '181154612', N'Lưu Minh Đức', '20/09/2001', N'Nam', N'Hồ Chí Minh', 'DTH15', '0'


----------------------------DỮ LIỆU BẢNG LOGIN-----------------------------------------------
INSERT INTO LOGIN(TenDN, MatKhau, HoTen, GioiTinh, Email, Quyen)
	SELECT 'phuongtrang', '12345', N'Nguyễn Ngọc Phương Trang', N'Nữ', 'pt1312@gmail.com', 'Admin'
INSERT INTO LOGIN(TenDN, MatKhau, HoTen, GioiTinh, Email, Quyen)
	SELECT 'mannghi', '12345', N'Nguyễn Thị Mẫn Nghi', N'Nữ', 'mn1908@gmail.com', 'Admin'
INSERT INTO LOGIN(TenDN, MatKhau, HoTen, GioiTinh, Email, Quyen)
	SELECT 'ngoctram', '12345', N'Lê Thị Ngọc Trâm', N'Nữ', 'nt3012@gmail.com', 'Member'
INSERT INTO LOGIN(TenDN, MatKhau, HoTen, GioiTinh, Email, Quyen)
	SELECT 'trunghieu', '12345', N'Nguyễn Trung Hiếu', N'Nam', 'th0102@gmail.com', 'Member'
INSERT INTO LOGIN(TenDN, MatKhau, HoTen, GioiTinh, Email, Quyen)
	SELECT 'hoangyen', '12345', N'Nguyễn Hoàng Yến', N'Nữ', 'hy03048@gmail.com', 'Member'



---------------------------DỮ LIỆU BẢNG DIEMTHI-------------------------------------------
INSERT INTO DIEMTHI (MaSV, HoTen, MaLop, MaMH,DiemLT, DiemTH, DiemThi, DiemTK, HanhKiem, HocKy, GhiChu)
	SELECT '18115461', N'Phạm Văn Châu', 'DTH01', 'QTM-PTTKHTM', 8.5, 8, 8, 8.3, N'Tốt', 1, N''
INSERT INTO DIEMTHI (MaSV, HoTen, MaLop, MaMH, DiemLT, DiemTH, DiemThi, DiemTK, HanhKiem, HocKy, GhiChu)
	SELECT '18115462', N'Vũ Khắc Chung', 'DTH01', 'QTM-PTTKHTM', 7, 7, 8.5, 8.3, N'Tốt', 1, N''
INSERT INTO DIEMTHI (MaSV, HoTen, MaLop, MaMH, DiemLT, DiemTH, DiemThi, DiemTK, HanhKiem, HocKy, GhiChu)
	SELECT '18115464', N'Nguyễn Thị Thu Hiền', 'DTH03', 'LT-KTTMT', 8, 9, 8.3, 8.7, N'Tốt', 1, N''
INSERT INTO DIEMTHI (MaSV, HoTen, MaLop, MaMH, DiemLT, DiemTH, DiemThi, DiemTK, HanhKiem, HocKy, GhiChu)
	SELECT '18115465', N'Lê Thị Ngọc Bích', 'DTH07', 'LT-ĐACSKTPM', 2, 1, 3 , 1.3, N'Tốt', 4, N'Thi lại'
INSERT INTO DIEMTHI (MaSV, HoTen, MaLop, MaMH, DiemLT, DiemTH, DiemThi, DiemTK, HanhKiem, HocKy, GhiChu)
	SELECT '18115467', N'Trần Hoài Nam', 'DTH19', 'LT-CĐNET', 7, 9, 7.5 , 8.4, N'Tốt', 4, N''


--------------------------------DỮ LIỆU BẢNG DIEMTHILAN--------------------
INSERT INTO DIEMTHILAI (MaSV, HoTen, MaLop, TenMH, DiemLT, DiemTH, DiemThiLai, HocKy)
	SELECT '18115465', N'Lê Thị Ngọc Bích', 'DTH07', N'Đồ án cơ sở KTPM', 8, 9, 10, 4
---------------------------------
SELECT * FROM NGANH
SELECT * FROM LOP
SELECT * FROM MONHOC
SELECT * FROM SINHVIEN
SELECT * FROM LOGIN
SELECT * FROM DIEMTHI
SELECT * FROM DIEMTHILAI
