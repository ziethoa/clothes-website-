Create database FinalProject
Go

Create Table Account(
	IDAccount int NOT NULL PRIMARY KEY,	
	AccountName nchar(100),
	Password nchar(100),
	FirstName nvarchar(100),
	LastName nvarchar(100),
	Country nvarchar(100),
	Email nchar(50),
	Address nvarchar(150),
	Town_City nvarchar(100),
	Postcode_ZIP nvarchar(150),
	Phone nchar(15)
)
Go

Create Table Home(
	IDHome int NOT NULL PRIMARY KEY,
	Topic nvarchar(100),
	Title nvarchar(150),
	ImgProduct nchar(100),
	ShortDes nvarchar(100),
)

Create Table Categogy(
	IDCategogy int NOT NULL PRIMARY KEY,
	NameCategogy nvarchar(100),
	IDProduct int
)

Create Table Contact(
	IDContact int NOT NULL PRIMARY KEY,
	IDAccount int,
	PhoneContact nchar(15) ,
	AddressContact nvarchar(150) ,
	Message nvarchar(500),
	LinkGoogleMap nvarchar(500) ,
	Description [nvarchar](500)
)

Create Table Product(
	IDProduct int NOT NULL PRIMARY KEY,	
	NameProduct nvarchar(100),
	ImgProduct nchar(100),
	Price float,
	Color nvarchar(20),
	Size nchar(10),
	Quantity int,
	Rating nchar(10),
	Description nvarchar(500)
)
Create Table ShoppingCart(
	IDShoppingCart int NOT NULL PRIMARY KEY,
	IDProduct int,
	PriceTotal float,
	Total float,
	IDDiscount int
)

Create Table Discount(
	IDDiscount int NOT NULL PRIMARY KEY,
	DiscountCode nchar(100)
)
Create Table AboutUs(
	IDAboutUs int NOT NULL PRIMARY KEY,
	NameAboutUs nvarchar(100),
	ImgAboutUS nchar(100),
	ShortDes nvarchar(100),
	FullDes nvarchar(500)
)
Create Table Brand(
	IDBrand int NOT NULL PRIMARY KEY,
	NameBrand nvarchar(100),
	IDProduct int
)
Drop table Brand

ALTER TABLE Contact ADD CONSTRAINT FK_Account FOREIGN KEY (IDAccount) REFERENCES Account(IDAccount); 
ALTER TABLE ShoppingCart ADD CONSTRAINT FK_Product FOREIGN KEY (IDProduct) REFERENCES Product(IDProduct);
ALTER TABLE ShoppingCart ADD CONSTRAINT FK_Discount FOREIGN KEY (IDDiscount) REFERENCES Discount(IDDiscount);
ALTER TABLE Categogy ADD CONSTRAINT FKProduct FOREIGN KEY (IDProduct) REFERENCES Product(IDProduct);

ALTER TABLE Brand ADD CONSTRAINT FK_Brand FOREIGN KEY (IDProduct) REFERENCES Product(IDProduct);