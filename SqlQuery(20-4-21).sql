Create Database RolesManagement

Create table RoleType( 
ID int identity(1,1) primary key,
Name varchar(10) not null,
isActive int 
)
insert into RoleType values('Partner',1)
insert into RoleType values('Customer',0)
insert into RoleType values('Admin',1)

select * from RoleType


Drop table Roles

Create table Roles(
id int identity(1,1),
Name varchar(20) not null,
RoleTypeId int foreign key references RoleType(ID),
EffectiveFrom date,
isActive int,
CreateDate date,
ModifyDate date
)

insert into Roles values('SystemAdmin',1,'08-02-2021',1,'1-03-2021','5-03-2021')
insert into Roles values('SystemReader',1,'09-05-2021',1,'1-06-2021','5-07-2021')
insert into Roles values('CustomerAdmin',2,'5-05-2021',1,'4-09-2021','8-11-2021')
insert into Roles values('CustomerReader',2,'08-25-2021',1,'1-11-2021','5-16-2021')

select * from roles
select * from roletype

update roletype set isActive = 1 where ID = 2