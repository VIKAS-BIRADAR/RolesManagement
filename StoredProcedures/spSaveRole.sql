Create Procedure spSaveRole (@R_id int, @R_Name nvarchar(20),  @R_RoleTypeId int, @R_EffectiveFrom datetime)
As
Begin
     if @R_id>0
             Update Roles set  Name =@R_Name,RoleTypeId= @R_RoleTypeId,EffectiveFrom=@R_EffectiveFrom,
             ModifyDate=GETDATE() where id = @R_id
     else
         insert into Roles(Name,RoleTypeId,EffectiveFrom,isActive,CreateDate,ModifyDate) values 
	     (@R_Name , @R_RoleTypeId ,@R_EffectiveFrom ,1,GETDATE() ,NULL)

END

  


