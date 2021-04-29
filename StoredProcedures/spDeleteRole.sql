 Create Procedure spDeleteRole(@R_id int)
 As
 Begin
 Delete from Roles Where id = @R_id
 END

 Exec spDeleteRole @R_id=14