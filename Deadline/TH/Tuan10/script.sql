use BANHANG
go


alter function tongtienhoadon(@mahd varchar(50))
returns int
as
begin
		return (select SUM(sl*dongia)
					from CTHOADON
					where mahd = @mahd)
end

go
create proc updateTongtien
	@tong int, @mahd varchar(20)
as
begin
	update HOADON set tongtien = @tong where mahd = @mahd
end

exec dbo.updateTongtien 100000, 'HD0002'

select dbo.tongtienhoadon('HD0002')
-----------------------------------------------------------------------
-- Viết Function trả về danh sách các quốc gia cung cấp sản phẩm.
create function xuatxu()
returns table
as
return (select distinct xuatxu from HANGHOA)


select * from dbo.xuatxu()


-----------------------------------------------------------------------

-- Viết Store Procedure liệt kê chi tiết hóa đơn (bao gồm: mahd, mahh, tenhh, dvt, xuatxu, sl, dongia) của một hóa đơn.
go
create proc lietkehoadon
	@mahoadon varchar(20)
as
begin
		select ct.mahd, ct.mahh, hh.tenhh, hh.dvt, hh.xuatxu, ct.sl, ct.dongia
		from CTHOADON ct join HANGHOA hh on ct.mahh = hh.mahh
		where ct.mahd = @mahoadon
end

exec dbo.lietkehoadon 'HD0002'



-- Viết Store Procedure liệt kê các hóa đơn bán được nhiều hàng nhất
go
alter proc hdbannhieunhat
as
begin
		select mahd, sum(sl) slhh into #temp from CTHOADON group by mahd

		select * from #temp where slhh >= all (select sum(sl) slhh from CTHOADON group by mahd)
end

go
exec dbo.hdbannhieunhat

-- Viết Store Procedure liệt kê các hóa đơn bán được nhiều hàng nhất theo xuat xu
go
create proc hdbannhieunhattheoxuatxu
	@xuatxu varchar(20)
as
begin
		select ct.mahd, sum(sl) slhh into #temp
		from HANGHOA hh join CTHOADON ct on hh.mahh = ct.mahh join HOADON hd on hd.mahd = ct.mahd
		where xuatxu = @xuatxu
		group by ct.mahd

		select * from #temp t where slhh >= all (select sum(sl) slhh
												from HANGHOA hh 
												join CTHOADON ct on hh.mahh = ct.mahh 
												join HOADON hd on hd.mahd = ct.mahd
												where xuatxu = @xuatxu
												group by ct.mahd)
end



-- Viết Store Procedure liệt kê các hóa đơn bán được ít hàng nhất theo xuat xu
go
create proc hdbanitnhattheoxuatxu
	@xuatxu varchar(20)
as
begin
		select ct.mahd, sum(sl) slhh into #temp
		from HANGHOA hh join CTHOADON ct on hh.mahh = ct.mahh join HOADON hd on hd.mahd = ct.mahd
		where xuatxu = @xuatxu
		group by ct.mahd

		select * from #temp t where slhh <= all (select sum(sl) slhh
												from HANGHOA hh 
												join CTHOADON ct on hh.mahh = ct.mahh 
												join HOADON hd on hd.mahd = ct.mahd
												where xuatxu = @xuatxu
												group by ct.mahd)
end



-- Viết Store Procedure liệt kê các hàng hóa đến từ Mỹ mà hóa đơn HD0004 không mua
go
create proc hhkhongmua
as
begin
		select *
		from HANGHOA hh 
		where hh.xuatxu = N'Mỹ'
		and not exists (select *
		 from CTHOADON ct where ct.mahh = hh.mahh and ct.mahd = 'HD0004')
end

exec dbo.hhkhongmua


-- Viết Store Procedure liệt kê các hóa đơn đã mua tất cả các mặt hàng có xuất xứ từ một quốc gia nào đó (quốc gia được truyền vào từ tham số)
go
create proc tatcahd
	@maqg nvarchar(20)
as
begin
		select *
		from HOADON hd
		where not exists (select hh.mahh
							from HANGHOA hh
							where hh.xuatxu = @maqg
							except
							select ct.mahh
							from CTHOADON ct
							where ct.mahd = hd.mahd)
end


exec dbo.tatcahd N'Mỹ'