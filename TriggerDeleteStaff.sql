USE [UMCLOCKER]
GO
/****** Object:  Trigger [dbo].[trg_Staff]    Script Date: 06/05/2020 15:54:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER trigger [dbo].[trg_Staff] on [dbo].[Staff]
For Delete, Insert
AS
update Locker set owned = NULL, state = 'AVAIABLE' from Locker,Deleted d where Locker.id = locker_id
update Shoes set owned = NULL, state = 'AVAIABLE' from Shoes,Deleted d where Shoes.id = shoes_id

update Locker set owned = i.id , state = 'USED' from Locker,Inserted i where Locker.id = locker_id
update Shoes set owned = i.id, state = 'USED' from Shoes,Inserted i where Shoes.id = shoes_id
