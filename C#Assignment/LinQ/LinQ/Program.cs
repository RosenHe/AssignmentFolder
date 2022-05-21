// See https://aka.ms/new-console-template for more information
/*
 In-Memory: data/memory stored in collections List<>, Dictionary<>, Arrays<> can use LinQ on these
 Output of LinQ on these is IEnumerable

 Out-Memory: databases of outside sources: LinQ can be used on these:
 Output of LinQ on these is IQueryable<>


 LinQ Providers:
 -- LinQ to Objects: In memory sources
 -- LinQ to entities: processing data stored in External database and modeled with ORMS
 -- LinQ to XML: not that common practice anymore.

Object Relational mapping: connect the ASP.Net Application to SQL Server without any "impendance mismatch"
ORMs need providers: they are the connections that will connect your LinQ to SQL server

//Extension methods: where, order by, select...
//Lamda functions/ Delegate
//LinQ Query Comprehensive Syntax(query syntax(optional)) it is similar to SQL queries in the fact it uses the same keywords
//Select, From, Where, in.

First: returns the first data when there is one or more matching found; if tehre are no matching values throw exception
First
SingleOrDefult: returns a signular macthing record, if there 
 
Quantifier Operators:
All():Checks if ALL the elements satisfy the specific condition, if yes, return true, if no -> return false.
Any():Checks if ANY the elements satisfy the specific condition, if yes, return true, if no -> return false.
 */
using LinQ;

ManageEmployees ManageEmployees = new ManageEmployees();
ManageEmployees.Run();