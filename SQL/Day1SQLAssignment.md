<h2 align="center"> 
SQL Basic FAQ:
</h2>

- What does SQL Profiler do?  
    - SQL Server Profiler is an interface to create and manage traces and analyze and replay trace results.
- What's the life scope of local variable in SQL Server?
  - The life scope of local variable in SQL server is within a block or procedure.
- What are the databases in system databases folder and what's their functionalities?
    - Master database : Records all the system-level information for an instance of SQL server.
    - Msdb database: Used by SQL server Agent for scheduling alerts and jobs.
    - Model database: Used as the template for all database created on the instance of SQL server.
    - Resource database:  It is a read-only databse that contains system objects that are included with SQL server.
    - Tempdb database: It is a workspace for holding temporary objects or intermediate result sets.
- Which statements are DDL statements, which are DML statements?
    - DDL statements: Data Definition Language
       - Create, alter, and drop schema objects
       - Grant and revoke privileges and roles
       - Analyze information on a table, index, or cluster
       - Establish auditing options
       - Add comments to the data dictionary
            -   ALTER ... (All statements beginning with ALTER)
            -   ANALYZE
            -   ASSOCIATE STATISTICS
            -   AUDIT
            -   COMMENT
            -   CREATE ... (All statements beginning with CREATE)
            -   DISASSOCIATE STATISTICS
            -   DROP ... (All statements beginning with DROP)
            -   FLASHBACK ... (All statements beginning with FLASHBACK)
            -   GRANT
            -   NOAUDIT
            -   PURGE
            -   RENAME
            -  REVOKE
            -   TRUNCATE
            -   UNDROP
    - DML statements: Data Manipulation Language
        - Access and manipulate data in existing schema objects
            -   CALL
            -   DELETE
            -   EXPLAIN PLAN
            -   INSERT
            -   LOCK TABLE
            -   MERGE
            -   SELECT
            -   UPDATE

<h2 align="center"> 
Assignment 1 SQL
</h2>

## Conceptual Questions:
### 1. What does CRUD stand for?
- Create Read Update Delete
### 2. What are the System Databases?
- System Databases are installed during the SQL Server installation.
- Master database, Msdb database, Model database, Resource database, Tempdb database
### 3. What is OLAP and OLTP?
- OLAP: Online analytical processing. A technology that organizes large business databases and supports complex analysis. it can be used to perform complex analytical queries without negatively affecting transactional systems. OLAP systems were designed to help extract this business intelligence information from the data in a highly performant way, optimized for heavy read, low write workloads.
- OLTP: Online transaction processing. The databases that a business uses to store all its transactions and records. these databases usually have records that are entered one at a time. It contains the valuable data information to the organization.
### 4. What is the difference between DDL vs. DML?
- DDL: Data Definition Language.
    - Used to create database schema and can be used to define some constraints as well.
    defines the column(attributes) of the table. Basic command presend in ddl are CREATE, DROP, RENAME, ALTER etc. DDL does not use WHERE clause in its statement.
- DML: Data Manipulation Language.
    - Used to add, retrieve or update the data. Add or update the row of the table, these rows are called as tuple. Basic command present in DML are UPDATE, INSERT, MERGE etc. DML uses WHERE clause in its statement.
### 5.What does the “Like” keyword do?
- Like used in a WHERE clause to search for a specified pattern in a column.
### 6. List the wildcards available for the Like Operator.
- % 
    - Any string with zero or more characters in the search pattern.
- _
    - Any single character search with the specified pattern.
- []
    - Any single character search within the specified range.
- [^]
    - Any signle character search not within the specified range. 
### 7. What's the difference between left join and inner join?
- Left Join
    - returns all rows from the left table and matched records from the right table, for those no matched rows will have NULL value.
- Inner Join
    - returns records that have matching values in both tables


## Write queries for following scenarios - Using AdventureWorks Database
### 1. Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, with no filter. 
```
Select ProductID, Name, Color, ListPrice
From Production.Product
```
### 2. Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, excluding the rows that ListPrice is 0.
```
Select ProductID, Name, Color, ListPrice
From Production.Product
Where ListPrice != 0
```
### 3. Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, the rows that are not NULL for the Color column.
```
Select ProductID, Name, Color, ListPrice
From Production.Product
Where Color is not Null
```
### 4. Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, the rows that are not NULL for the column Color, and the column ListPrice has a value greater than zero.
```
Select ProductID, Name, Color, ListPrice
From Production.Product
Where Color is not Null and ListPrice > 0
```

### 5. Write a query that concatenates the columns Name and Color from the Production.Product table by excluding the rows that are null for color.
```
Select concat(Name,',', color) as Name
From Production.Product 
Where color is not null
```
### 6. Write a query that generates the following result set from
- Production.Product:
    - NAME: LL Crankarm  --  COLOR: Black
    - NAME: ML Crankarm  --  COLOR: Black
    - NAME: HL Crankarm  --  COLOR: Black
    - NAME: Chainring Bolts  --  COLOR: Silver
    - NAME: Chainring Nut  --  COLOR: Silver
    - NAME: Chainring  --  COLOR: Black_
```
Select name, color
From Production.Product
Where name like '%Crankarm%' or name like '%Chainring%' 
Order By ProductID asc
```
### 7. Write a query to retrieve the to the columns ProductID and Name from the Production.Product table filtered by ProductID from 400 to 500 using between
```
Select ProductID, Name
From Production.Product 
Where ProductID between 400 and 500
```
### 8. Write a query to retrieve the to the columns ProductID, Name and color from the Production.Product table restricted to the colors black and blue
```
Select ProductID, Name, Color
From Production.Product 
Where Color = 'black' or Color = 'blue'
```
### 9. Write a query to get a result set on products that begins with the letter S.

```
Select *
From Production.Product 
Where Name like 'S%'
```
OR (result set -> return every columns) (it doesn't said filter by the Name or the ProductNumber)
```
Select *
From Production.Product 
Where ProductNumber like 'S%'
```
### 10. Write a query that retrieves the columns Name and ListPrice from the Production.Product table. Your result set should look something like the following. Order the result set by the Name column. The products name should start with either 'A' or 'S'
```
Select Name, ListPrice
From Production.Product 
Where Name like 'A%' or Name like 'S%'
Order by Name asc
```
### 11. Write a query so you retrieve rows that have a Name that begins with the letters SPO, but is then not followed by the letter K. After this zero or more letters can exists. Order the result set by the Name column.
```
Select Name
From Production.Product 
Where Name like 'SPO%' and Name not like 'SPOK%'
Order by Name asc
```
### 12. Write a query that retrieves the unique combination of columns ProductSubcategoryID and Color from the Production.Product table. We do not want any rows that are NULL.in any of the two columns in the result. (Hint: Use IsNull)
```
Select distinct cast(ProductSubcategoryID as nvarchar) +' '+ color 
From Production.Product
where ProductSubcategoryID is not null and Color is not null
```