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