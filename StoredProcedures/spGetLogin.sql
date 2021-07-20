Create procedure spGetLogin
AS
BEGIN
select Firstname,LastName, Email,Username,Password from Login
END

