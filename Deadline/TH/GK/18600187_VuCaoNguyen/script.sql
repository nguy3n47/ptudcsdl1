use HANGHOA
go

-- Cau 1
IF OBJECT_ID('fc_SoHH ','fn') IS NOT NULL
	DROP FUNCTION fc_SoHH 
GO
create function fc_SoHH (@nhom varchar(10), @loai varchar(10))
returns int
as
begin
	declare @dem int
	select @dem = count(*) from HANGHOA where Nhom = @nhom and LOAI = @loai
	return @dem
end
go
select dbo.fc_SoHH( 'NH001', 'DL')

--Cau 2
IF OBJECT_ID('sp_TTLHH','p') IS NOT NULL
	DROP PROC sp_TTLHH
GO
create proc sp_TTLHH
	@nhom varchar(10),
	@loai varchar(10)
as
begin
	select distinct nhh.TenNhom,l.TenLoai,l.SanPhamDD,hh.DonViTinh
	from HANGHOA hh join LOAI l on hh.Loai=l.Loai join NHOMHH nhh on hh.Nhom=nhh.Nhom
	where hh.Nhom=@nhom and hh.Loai=@loai
end
go
exec sp_TTLHH 'NH001','DL'
go