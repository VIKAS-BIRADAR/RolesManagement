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
  Name =@R_Name,RoleTypeId= @R_RoleTypeId,EffectiveFrom=@R_EffectiveFrom,isActive=@R_isActive,CreateDate=@R_CreateDate,ModifyDate=@R_ModifyDate where id = @R_id
  END

  Execute UpdateData 
 @R_id = 4,
 @R_Name ='Admin',
 @R_RoleTypeId =2,
 @R_EffectiveFrom = '2-02-2021',
 @R_isActive = 1,
 @R_CreateDate = '3-01-2022',
 @R_ModifyDate ='11-05-2021'

 Execute GetData

 Drop Procedure UpdateData

 Create Procedure DeleteData(@R_id int)
 As
 Begin
 Delete from Roles Where id = @R_id
 END

 Execute DeleteData
 @R_id = 13

 Create Procedure GetRoleType
 As
BEGIN
      select * from RoleType
END 

Exec GetRoleType

Create Procedure InsertRoleTypeData(@R_Name varchar(10), @R_isActive int)
As
Begin 
     insert into RoleType(Name,isActive) values (@R_Name,@R_isActive )
END   

Exec InsertRoleTypeData
 @R_Name ='Admin',
 @R_isActive = 1


  Create Procedure UpdateRoleData(@R_id int,@R_Name Varchar(10), @R_isActive int)
  As
  Begin
  Update RoleType set
  Name=@R_Name,isActive=@R_isActive where ID = @R_id
  END

 



 Exec UpdateRoleData
 @R_id=4,
 @R_Name ='HR',
 @R_isActive = 0

 Exec GetRoleType
 
 Create Procedure DeleteRoleData(@R_id int)
 As
 Begin
 Delete from RoleType Where ID = @R_id
 END

 Exec DeleteRoleData
 @R_id = 4











