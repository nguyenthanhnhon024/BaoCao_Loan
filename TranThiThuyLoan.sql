----Tạo database---
Create database TranThiThuyLoanDB
Use TranThiThuyLoanDB
go
-----Tạo bảng-----
Create table UserAccount
(
	ID int primary key identity(1,1),
	UserName varchar(50) not null,
	Password varchar(50) not null,
	Status varchar(50)
)
go
Create table Category
(
	ID int primary key identity(1,1),
	Name nvarchar(500) not null,
	Description nvarchar(500)
)
go
Create table Product
(
	ID int primary key identity(1,1),
	Name nvarchar(500) not null,
	UnitCost money not null,
	Quantity int not null,
	Image varchar(50),
	Description nvarchar(500),
	Status bit,
	IDCate int,
	CONSTRAINT FK_ProCate
	FOREIGN KEY (IDCate) REFERENCES Category(ID)
)
go
-----Chèn dữ liệu-----
insert into UserAccount(UserName,Password,Status)
values	('Loan','loan','Active'),
		('Admin','admin','Active'),
		('Hoa','hoa','Active'),
		('le','le','Blocked'),
		('Xuan','xuan','Blocked');
		
insert into Category(Name,Description)
values	(N'Hoa khai trương',N'Kệ hoa chúc mừng vào dịp lễ khai trương'),
		(N'Hoa sinh nhật',N'Kệ hoa chúc mừng sinh nhật người thân bạn bè'),
		(N'Hoa bó',null),
		(N'Hoa chúc mừng',N'Kệ hoa các ngày kỉ niệm đặc biệt của bản thân'),
		(N'Hoa lễ',null);
insert into Product(Name,UnitCost,Quantity,Description,Image,Status,IDCate)
values	(N'Tự hào',120,3,N'Hoa hướng dương luôn hướng về phía mặt trời đầy sức sống và mạnh mẽ, một lẵng hoa được thiết kế cùng tông màu vàng tươi của hướng dương được cắm cao tượng trưng cho tinh thần luôn cầu tiến, vươn cao đến những bậc cao mới','anh1.jpg','true',1),
		(N'Vững Vàng',150,3,null,'anh2.jpg','true',1),
		(N'Hân Hoan',100,3,null,'anh3.jpg','true',1),
		(N'Bó hoa chúc mừng tốt nghiệp',200,3,N'Bó hoa chúc mừng tốt nghiệp - Hãy vươn lên như lời cổ vũ tinh thần, mang sắc vàng tươi đến cho người được tặng để chúc mừng ngày họ tốt nghiệp, ngày ra trường... ','anh4.jpg','true',5),
		(N'Bó Hoa Đỏ Thắm',170,3,null,'anh5.jpg','true',3);