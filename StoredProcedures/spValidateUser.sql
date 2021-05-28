CREATE  PROCEDURE spValidateUser(@R_Username nvarchar(10),@R_Password nvarchar(10))
AS
BEGIN
IF EXISTS(SELECT * FROM Login WHERE Username = @R_Username AND Password = @R_Password)
    SELECT 'true' AS UserExists
ELSE
    SELECT 'false' AS UserExists

END