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