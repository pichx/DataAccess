--Create tables

CREATE TABLE dbo.[Type]
(
	TypeId int not null identity primary key,
	TypeDescription nvarchar(100) not null,
	ChangeDate datetime not null default getdate()
);

CREATE TABLE dbo.[Status]
(
	StatusId int not null identity primary key,
	StatusDescription nvarchar(100) not null,
	ChangeDate datetime not null default getdate()
);

CREATE TABLE dbo.[Item]
(
	ItemId int not null identity primary key,
	ItemDescription nvarchar(100) not null,
	TypeId int not null,
	StatusId int not null,
	ChangeDate datetime not null default getdate()
);
