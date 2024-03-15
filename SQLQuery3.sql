--Select
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

Select * from Customers where City = 'Berlin'

Select * from Products where CategoryID = 1 or CategoryID=3

Select * from Products where CategoryID = 1 and UnitPrice>=10

Select * from Products order by ProductName

Select count(*) Adet from Products where CategoryID =2

select categoryID,count(*) from products group by CategoryID

select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName 
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

Select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

Select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID

Select * from Customers c inner join Orders o
on c.CustomerID = o.CustomerID

Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null



