
--  Product Table
Create table Products(
   Id int primary key identity(1,1),
   Name nvarchar(100),
   Price decimal(18,2)
);

--   Create Product
create procedure InsertProduct
       @Name nvarchar(100),
	   @Price decimal(18,2)
as
begin
       Insert into Products(Name, Price) Values(@Name, @Price)
end;

--    Get all Product

create procedure GetProducts as
begin
Select * from Products
end;


--    Get Product

create procedure GetProduct
      @Id int
as
begin
Select * from Products where Id=@Id;
end;




--   Update product

create procedure UpdateProduct
   @Id int,
   @Name nvarchar(100),
   @Price decimal(18,2)
as
begin
   Update Products set Name = @Name, Price = @Price where Id = @Id;
end;

--   Delete product

create procedure DeleteProduct
   @Id int
as
begin
   Delete from Products where Id = @Id;
end;