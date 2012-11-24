--drop table DocumentLine
--drop table Document
--go

create table Document
(
	DocumentID int not null primary key identity,
	Name nvarchar(32) not null
)
go

create table DocumentLine
(
	LineID int not null primary key identity,
	DocumentID int not null foreign key references Document(DocumentID),
	ItemName nvarchar(128) not null,
	GivenQty int not null,
	Qty int null
)
go

declare @DocumentID int

insert into Document(Name) values(N'������� 1')
select @DocumentID = @@IDENTITY

insert into DocumentLine(DocumentID, ItemName, GivenQty) values(@DocumentID, N'����� 1', 10)
insert into DocumentLine(DocumentID, ItemName, GivenQty) values(@DocumentID, N'����� 2', 5)
insert into DocumentLine(DocumentID, ItemName, GivenQty) values(@DocumentID, N'����� 3', 12)

insert into Document(Name) values(N'������� 2')
select @DocumentID = @@IDENTITY

insert into DocumentLine(DocumentID, ItemName, GivenQty) values(@DocumentID, N'����� 4', 1)
insert into DocumentLine(DocumentID, ItemName, GivenQty) values(@DocumentID, N'����� 5', 4)
