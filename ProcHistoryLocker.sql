CREATE PROCEDURE history_locker_key @locker_id int
AS
select Staff.* from Staff where Staff.id in (
select Staff.id from Locker, Staff, Dept, Pos, Shoes  where Locker.id = Staff.locker_id and Staff.shoes_id = Shoes.id group by Staff.id, Staff.locker_id
) and Staff.locker_id = @locker_id
