USE [UMCLOCKER]
GO
/****** Object:  Trigger [dbo].[trg_Staff]    Script Date: 06/24/2020 10:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[trg_Staff] on [dbo].[Staff]
For Delete, Insert
AS
update Locker set owned = NULL, state = 'AVAIABLE' from Locker,Deleted d where Locker.id = locker_id
update Shoes set owned = NULL, state = 'AVAIABLE' from Shoes,Deleted d where Shoes.id = shoes_id

update Locker set owned = i.id , state = 'USED' from Locker,Inserted i where Locker.id = locker_id
update Shoes set owned = i.id, state = 'USED' from Shoes,Inserted i where Shoes.id = shoes_id
