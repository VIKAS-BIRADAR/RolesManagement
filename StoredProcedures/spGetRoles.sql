Create Procedure spGetRoles
As
BEGIN
      select R.id,R.Name as RoleName,RT.Name as RoleType,R.EffectiveFrom,R.CreateDate from Roles R
	  join RoleType RT on R.RoleTypeId = RT.ID and RT.isActive= 1 
	  where R.isActive=1
END 

Exec spGetRoles

Create Procedure spGetRole
As
Begin
select * from Roles
END

Exec spGetRole

Create Procedure spInsertRole(@R_Name nvarchar(20), @R_RoleTypeId int,@R_EffectiveFrom datetime,@R_isActive bit,@R_CreateDate datetime,@R_ModifyDate datetime)
As
Begin 
     insert into Roles(Name,RoleTypeId,EffectiveFrom,isActive,CreateDate,ModifyDate) values (@R_Name , @R_RoleTypeId ,@R_EffectiveFrom ,@R_isActive ,@R_CreateDate ,@R_ModifyDate)
END

Execute spInsertRole
 @R_Name ='AdminReader',
 @R_RoleTypeId =2,
 @R_EffectiveFrom = '2-02-2021',
 @R_isActive = 1,
 @R_CreateDate = '3-01-2021',
 @R_ModifyDate ='11-05-2021'


  Create Procedure spUpdateRole(@R_id int,@R_Name nvarchar(100), @R_RoleTypeId int,@R_EffectiveFrom datetime,@R_isActive bit,@R_CreateDate datetime,@R_ModifyDate datetime)
  As
  Begin
  Update Roles set
  Name =@R_Name,RoleTypeId= @R_RoleTypeId,EffectiveFrom=@R_EffectiveFrom,isActive=@R_isActive,CreateDate=@R_CreateDate,ModifyDate=@R_ModifyDate where id = @R_id
  END

    Execute spUpdateRole
 @R_id = 14,
 @R_Name ='Adminv',
 @R_RoleTypeId =1,
 @R_EffectiveFrom = '2-02-2021',
 @R_isActive = 0,
 @R_CreateDate = '3-01-2022',
 @R_ModifyDate ='11-05-2021'
 Exec spGetRole

  Create Procedure spDeleteRole(@R_id int)
 As
 Begin
 Delete from Roles Where id = @R_id
 END

 Exec spDeleteRole @R_id=14

 Create Procedure spGetRoleType
 As
BEGIN
      select * from RoleType
END

exec spGetRoleType
