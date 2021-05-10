Create Procedure spGetRole
As
BEGIN
      select R.id, R.Name as RoleName, RT.ID as RoleTypeId, RT.Name as RoleType, R.EffectiveFrom,R.CreateDate from Roles R
	  join RoleType RT on R.RoleTypeId = RT.ID and RT.isActive= 1 
	  where R.isActive=1
END 