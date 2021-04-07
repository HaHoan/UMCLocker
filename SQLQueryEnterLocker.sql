USE [UMCLOCKER]
GO
/****** Object:  StoredProcedure [dbo].[enter_locker]    Script Date: 06/09/2020 9:53:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[enter_locker] @from int ,@to int, @soo1tu int, @loaitu nvarchar(10)
AS
declare @index int = @from;
while @index <= @to
begin
	declare @j int = 1;
	while @j <= @soo1tu
	begin

		insert into Locker (locker_number, locker_index,locker_type,state)
		values (@index, @j,@loaitu,'AVAIABLE')
		set @j = @j+1;
	end;
set @index = @index + 1;
end;