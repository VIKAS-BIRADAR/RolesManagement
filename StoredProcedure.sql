select * from Roles
select * from RoleType

Create Procedure GetData
As
BEGIN
      select * from Roles
END 

Execute GetData

Create Procedure InsertData(@R_Name Varchar(20), @R_RoleTypeId int,@R_EffectiveFrom date,@R_isActive int,@R_CreateDate date,@R_ModifyDate date)
As
Begin 
     insert into Roles(Name,RoleTypeId,EffectiveFrom,isActive,CreateDate,ModifyDate) values (@R_Name , @R_RoleTypeId ,@R_EffectiveFrom ,@R_isActive ,@R_CreateDate ,@R_ModifyDate)
END    

Execute InsertData 
 @R_Name ='AdminReader',
 @R_RoleTypeId =2,
 @R_EffectiveFrom = '2-02-2021',
 @R_isActive = 1,
 @R_CreateDate = '3-01-2021',
 @R_ModifyDate ='11-05-2021'

 select * from Roles

 Create Procedure UpdateData(@R_id int,@R_Name Varchar(20), @R_RoleTypeId int,@R_EffectiveFrom date,@R_isActive int,@R_CreateDate date,@R_ModifyDate date)
  As
  Begin
  Update Roles set
  Name =@R_Name,RoleTypeId= @R_RoleTypeId,EffectiveFrom=@R_EffectiveFrom,@R_isActive=isActive,CreateDate=@R_CreateDate,ModifyDate=@R_ModifyDate where id = @R_id
  END

  Execute UpdateData 
 @R_id = 5,
 @R_Name ='Admin',
 @R_RoleTypeId =2,
 @R_EffectiveFrom = '2-02-2021',
 @R_isActive = 1,
 @R_CreateDate = '3-01-2022',
 @R_ModifyDate ='11-05-2021'

 Execute GetData

 Create Procedure DeleteData(@R_id int)
 As
 Begin
 Delete from Roles Where id = @R_id
 END

 Execute DeleteData
 @R_id = 5



