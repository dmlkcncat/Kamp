Select ContactName Adi, City Sehir from Customers

Select * from Customers Where City = 'London'

Select * from Products where CategoryId = 1 or categoryId = 3

Select * from Products where CategoryId = 1 and unitprice > 10

select *from Products order by Unitprice desc

select count(*) from Products

select CategoryID, count(*) from products group by CategoryID having count(*)< 10

select Products.ProductID, Products.ProductName,  Products.UnitPrice , Categories.CategoryName 
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID

select *from products p left join [order Details] od
on p.productId = od.productId

select ProductName from Products  Order By ProductName asc

select Products.ProductName, SUM([Order Details].UnitPrice * [Order Details].Quantity)from Products 
inner join [Order Details] ON Products.ProductID = [Order Details].ProductID
inner join Orders ON [Order Details].OrderID = Orders.OrderID
Group By ProductName
Order By ProductName

