USE QLDIEMTHI
GO

CREATE PROC [dbo].[DoiMatKhau]
@User NVARCHAR(50),
@OldPass NVARCHAR(50),
@NewPass NVARCHAR(50)
AS
BEGIN
    IF exists (SELECT * FROM LOGIN WHERE TenDN = @User and MatKhau = @OldPass)
    BEGIN
        UPDATE LOGIN SET MatKhau = @NewPass WHERE TenDN = @User
        SELECT 1 AS code, N'Thay đổi mật khẩu thành công !!' AS MSG
    END
    ELSE
        SELECT 0 AS code, N'Tài khoản hoặc mật khẩu sai, mời nhập lại !!' as MSG
END
