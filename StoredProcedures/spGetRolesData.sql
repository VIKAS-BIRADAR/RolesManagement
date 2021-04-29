Create Procedure spGetRolesData
As
BEGIN
      select R.id,R.Name as RoleName,RT.Name as RoleType,R.EffectiveFrom,R.CreateDate from Roles R
	  join RoleType RT on R.RoleTypeId = RT.ID and RT.isActive= 1 
	  where R.isActive=1
END 

Exec spGetRolesData