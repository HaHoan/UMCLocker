create proc delete_range_shoes @from int ,@to int, @soo1tu int, @loaitu nvarchar(10)
as
declare @index int = @from;
while @index <= @to
begin
	declare @j int = 1;
	while @j <= @soo1tu
	begin
		delete from Shoes where shoes_number = @index and shoes_index = @j and shoes_type = @loaitu
		set @j = @j+1;
	end;
set @index = @index + 1;
end;