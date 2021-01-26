use QLSV
go


create proc kq_DKHP_sv
	@mssv varchar(10),
	@hk	  int
as
begin
		select *
		from DKHP
		where MaSV = @mssv and HK = @hk
end
go


create proc dkhp_sv
	@nh varchar(10),
	@hk int,
	@mssv varchar(10),
	@mamh varchar(10),
	@sotc int,
	@diadiem nvarchar(20)
as
begin
		declare @tongSoTC int, @tongSoMon int
		declare @tb table (sts int, somon int, sotc int)
		set @tongSoTC = 0
		
		-- check valid input
		if not exists (select * from DKHP dk
						where dk.NH = @nh and dk.HK = @hk and dk.MaSV = @mssv and dk.MaMH = @mamh)
		begin
				insert into @tb values(-1, 0, 0)
				select * from @tb
				return
		end
		--set @tongSoTC
		set @tongSoTC = (select SUM(dk.SoTC) from DKHP as dk
						 where dk.MaSV = @mssv and dk.NH = nh and dk.HK = hk)
		-- check @tongSoTC
		if(@tongSoTC > 20)
		begin
			return;
		end
		else
		begin
			-- insert input to db
			insert into DKHP values (@nh, @hk, @mssv, @mamh, @sotc, @diadiem, NULL)
			-- output
			set @tongSoMon = (select COUNT(*) from DKHP as dk
						 where dk.MaSV = @mssv and dk.NH = nh and dk.HK = hk
						 group by dk.MaSV)
			set @tongSoTC = (select SUM(dk.SoTC) from DKHP as dk
						 where dk.MaSV = @mssv and dk.NH = nh and dk.HK = hk)
			-- print output for console
			insert into @tb values(1, @tongSoMon, @tongSoTC)
			select * from @tb
		end
end
go