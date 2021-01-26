use LICHTHI
go

---------------------------
select * from HOCPHAN
select * from KHOA
select * from LICHTHI
select * from SINHVIEN
---------------------------

-- Cau 1: Viết store có tên “sp_ThiTatCa” trả về thông tin các sinh viên (MaSV, Ho, Ten, khoa) 
-- dự thi tất cả các học phần mà khoa của sinh viên mở trong năm học, học kỳ (input: Khoa, nh, hk) 

IF OBJECT_ID('sp_ThiTatCa','p') IS NOT NULL
	DROP PROC sp_ThiTatCa
GO
create proc sp_ThiTatCa
	@Khoa varchar(15),
	@nh varchar(10),
	@hk varchar(10)
as
begin
	select sv.MaSV, sv.HoTen, sv.MaKhoa
	from SINHVIEN sv
	where sv.MaKhoa = @Khoa
	and not exists (select hp.NH, hp.HK, hp.MaHP
					from HOCPHAN hp
					where hp.NH = @nh and hp.HK = @hk and hp.MaKhoa = @Khoa
					except 
					select lt.NH, lt.HK, lt.MaHP
					from LICHTHI lt
					where lt.MaSV = sv.MaSV and lt.NH = @nh and lt.HK = @hk)
end
go
exec sp_ThiTatCa 'D460101', '18-19', '1'
go

-- 
