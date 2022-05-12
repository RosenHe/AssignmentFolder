<h2 align="center"> 
Conceptual Questions:
</h2>

### Difference between WHERE and HAVING?
- Where: 
    - used to filter the records from the table or used while joining more than one table.
    - It can be used with SELECT, UPDATE, DELETE statements.
    - used before GROUP BY
- Having:
    - used to filter the records from the groups based on the given condition.
    - Those groups who will satisfy the given condition will appear in the final result.
    - Only used with SELECT statement. Contain aggregate function
    - used after GROUP BY

### Difference between RANK() and DenseRank() 
- RANK:
    - skips the number of positions after records with the same rank number.
- DENSERANK:
    - it doesn't skip records with the same rank number.

### What is correlated subquery?
- used for row-by-row processing. A correlated subquery is evaluated once for each row processed by the parent statement. The parent statement can be a SELECT, UPDATE, or DELETE statement. 
### Criteria of Union and Union all?
- Union: 
    - Union means joining two or more data sets into a single set. In SQL Server, Union is used to combine two queries into a single result set using the select statements. Union extracts all the rows that are described in the query.
- Union All:
    - A union is used for extracting rows using the conditions specified in the query while Union All is used for extracting all the rows from a set of two tables.
### Difference between UNION and UNION ALL
- Unions : used to combine different result sets vertically by adding rows from multiple result sets
- Union all: Keep duplicates
### Difference between Union and JOIN
- Join: 
    - combines data from many tables based on a matched condition between them.
    - combines data into new columns.
    - selected from each table may not be same.
    - it may not return distinct columns.
- Union:
    - combines the result-set of 2 or more Select statements.
    - combines data into new rows.
    - Datatypes of corresponding columns selected from each table should be same.
    - return distinct rows.

<h2 align="center"> 
SQL Practice Questions:
</h2>

### 1.Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables. Join them and produce a result set similar to the following.
```
Select c.name 'Country', s.name 'Province'
From person.CountryRegion c
inner join Person.StateProvince s 
on c.CountryRegionCode = s.CountryRegionCode
```

### 2. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables and list the countries filter them by Germany and Canada. Join them and produce a result set similar to the following.
```
Select c.name 'Country', s.name 'Province'
From person.CountryRegion c
inner join Person.StateProvince s 
on c.CountryRegionCode = s.CountryRegionCode
Where c.name in ('Germany', 'Canada')
```

### 3. List all Products that has been sold at least once in last 25 years.
```
select distinct p.ProductName 
from Products p inner join [Order Details] d
on p.ProductID = d.ProductID
inner join Orders o
on o.OrderID = d.OrderID
where DATEADD(year,  25, o.OrderDate) < GETDATE()
```

### 4. List top 5 locations (Zip Code) where the products sold most in last 25 years.
```
select top 5 o.ShipPostalCode
from Products p inner join [Order Details] d
on p.ProductID = d.ProductID
inner join Orders o
on o.OrderID = d.OrderID
where DATEADD(year,  25, o.OrderDate) < GETDATE()
Group by o.ShipPostalCode
```

### 5. List all city names and number of customers in that city.   
```
Select city, Count(c.City) as Number
from Customers c
group by City
```

### 6. List city names which have more than 2 customers, and number of customers in that city
```
Select city, Count(c.City) as Number
from Customers c
group by City
having Count(c.city) > 2
```

### 7. Display the names of all customers  along with the  count of products they bought
```
Select c.ContactName, Sum(d.Quantity) as CountOfProducts
from Customers c left join Orders o on c.CustomerID = o.CustomerID
left join [Order Details] d on d.OrderID = o.OrderID
group by c.ContactName
```

### 8. Display the customer ids who bought more than 100 Products with count of products.
```
Select c.ContactName, Sum(d.Quantity) as CountOfProducts
from Customers c left join Orders o on c.CustomerID = o.CustomerID
left join [Order Details] d on d.OrderID = o.OrderID
group by c.ContactName
Having Sum(d.Quantity)  > 100
```

### 9. List all of the possible ways that suppliers can ship their products. Display the results as below
- Supplier Company Name                Shipping Company Name
```
Select sup.CompanyName as 'Supplier Company name', ship.CompanyName as 'Shipping Company Name'
from Suppliers sup cross join Shippers ship
Order By sup.SupplierID
```

### 10. Display the products order each day. Show Order date and Product Name.
```
select distinct p.productName, o.OrderDate
from Orders o left join [Order Details] d
on o.OrderID = d.OrderID left join Products p
on d.ProductID = p.ProductID
```

### 11. Displays pairs of employees who have the same job title.
```
select e.FirstName + ' ' + e.LastName as 'Employee 1', m.FirstName + ' ' + m.LastName as 'Employee 2'
from Employees e inner join Employees m
on e.Title = m.Title
where e.FirstName != m.FirstName
```

### 12. Display all the Managers who have more than 2 employees reporting to them.
```
select e.EmployeeID, e.LastName, e.FirstName, e.Title 
from Employees e inner join
Employees m
on e.EmployeeID = m.ReportsTo
--where e.Title like '%manager%'
group by e.EmployeeID, e.LastName, e.FirstName, e.Title
having count(m.ReportsTo) > 2
```

### 13. Display the customers and suppliers by city. The results should have the following columns
```
select c.City, c.CompanyName, c.ContactName, 'Customer' [Type]
from Customers c
union
select s.City, s.CompanyName, s.ContactName, 'Supplier'
from Suppliers s
```

### 14. List all cities that have both Employees and Customers.
```
select Distinct e.City
from Employees e, Customers c
where e.City = c.City
```
### 15. List all cities that have Customers but no Employee.
```
-- a. not use sub-query
select distinct c.City
from Customers c
except 
select city from Employees


--sub-query:
select distinct city
from Customers
where city not in(
select city
from Employees)
```

### 16. List all products and their total order quantities throughout all orders.
```
select p.ProductName, sum(d.Quantity) as 'Total Quantities'
from Orders o join [Order Details] d
on o.OrderID = d.OrderID join Products p
on p.ProductID = d.ProductID
group by p.ProductName
```

### 17. List all Customer Cities that have at least two customers.
```
--use union
Select c.City
from Customers c
Group by c.city
having count(c.city) >2
union
Select c.City
from Customers c
Group by c.city
having count(c.city) =2

--use subquery and no union
Select distinct c.City
from Customers c
where c.city in(
Select c.City
from Customers c
Group by c.city
having count(c.city) >=2
)
```

### 18. List all Customer Cities that have ordered at least two different kinds of products.
```
select c.City, count( d.ProductID) as 'CountOfProductID'
from Customers c join Orders o 
on c.City = o.ShipCity join [Order Details] d
on d.OrderID = o.OrderID
group by c.City
```

### 19. List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
```
select top 5 p.ProductName, o.ShipCity, Avg(d.UnitPrice) as 'Average Price', Max(d.Quantity) as 'Most Quantity'
from [Order Details] d  join Orders o
on d.OrderID = o.OrderID join Products p
on d.ProductID = p.ProductID
group by p.ProductName, o.ShipCity
```

### 20. List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered
from. (tip: join  sub-query)
```
select top 1 e.City, Count(o.OrderID) as 'Order Number sold'
from Orders o join [Order Details] d 
on o.OrderID = d.OrderID join Employees e
on o.EmployeeID = e.EmployeeID
join(
select top 1 e.City [city], Max(d.Quantity) as 'Most Quantity'
from Orders o join [Order Details] d 
on o.OrderID = d.OrderID join Employees e
on o.EmployeeID = e.EmployeeID
group by e.City) dummy
on e.city = dummy.city
group by e.City
```

### 21. How do you remove the duplicates record of a table?
- If we uses union, that will remove the duplicates,
- Or we can add Distinct before rows in select statement.
- Uses Comman table expression(CTE) the PARTITION BY clause.
- Use the SQL RANK function to remove the duplicate rows as well. SQL RANK function gives unique row ID for each row irrespective of the duplicate row.