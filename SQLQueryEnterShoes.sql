CREATE PROCEDURE enter_shoes @from int ,@to int, @soo1tu int, @loaitu nvarchar(10)
AS
declare @index int = @from;
while @index <= @to
begin
	declare @j int = 1;
	while @j <= @soo1tu
	begin

		insert into Shoes (shoes_number, shoes_index,shoes_type,state)
		values (@index, @j,@loaitu,'AVAIABLE')
		set @j = @j+1;
	end;
set @index = @index + 1;
end;