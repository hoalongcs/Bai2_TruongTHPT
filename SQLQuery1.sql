USE TruongTHPT
GO

--update student
CREATE PROCEDURE Sua_HS (@MaHS nchar(10), @HovaTen nvarchar(50), @GT nchar(3), @NgaySinh date,
				@DiaChi nvarchar(50), @PhuHuynh nvarchar(50), @MaLop nchar(10))
AS
BEGIN
 UPDATE tblHocSinh
 SET HovaTen = @HovaTen, GT = @GT, NgaySinh = @NgaySinh, DiaChi = @DiaChi, PhuHuynh = @PhuHuynh, MaLop = @MaLop
 WHERE MaHS = @MaHS
END

--delete student
CREATE PROCEDURE Xoa_HS (@MaHS nchar(10))
AS
BEGIN
 DELETE FROM tblHocSinh WHERE MaHS = @MaHS
END

-- update teacher
CREATE PROCEDURE Sua_GV (@MaGV nchar(10), @HoTen nvarchar(50), @GT nchar(3), @NgaySinh date, @DiaChi nvarchar(50),
				@SDT int, @Luong bigint, @MaMon nchar(10))
AS
BEGIN
 UPDATE tblGiaoVien
 SET HoTen = @HoTen, GT = @GT, NgaySinh = @NgaySinh, DiaChi = @DiaChi, SDT = @SDT, Luong = @Luong, MaMon = @MaMon
 WHERE MaGV = @MaGV
END

--delete teacher
CREATE PROCEDURE Xoa_GV (@MaGV nchar(10))
AS
BEGIN
 DELETE FROM tblGiaoVien WHERE MaGV = @MaGV
END