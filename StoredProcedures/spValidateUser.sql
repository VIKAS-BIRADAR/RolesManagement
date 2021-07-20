Create  PROCEDURE spValidateUser(@R_Email nvarchar(50),@R_Password nvarchar(10))
AS
BEGIN
IF EXISTS(SELECT * FROM Login WHERE Email = @R_Email AND Password = @R_Password)
      SELECT CAST(1 AS BIT) AS UserExists
ELSE
    SELECT CAST(0 AS BIT) AS UserExists
END