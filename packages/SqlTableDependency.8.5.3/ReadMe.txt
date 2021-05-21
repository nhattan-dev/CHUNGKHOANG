﻿================================================================================================================================================================
SqlTableDependency NuGet Package
================================================================================================================================================================
Copyright (c) 2015-2019 Christian Del Bianco 
MIT License
Repository: https://github.com/christiandelbianco/monitor-table-change-with-sqltabledependency
Home site: http://sqltabledependency.somee.com/

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 8.5.3.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* https://github.com/christiandelbianco/monitor-table-change-with-sqltabledependency/issues/117

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 8.5.2.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* https://github.com/christiandelbianco/monitor-table-change-with-sqltabledependency/issues/110
* https://github.com/christiandelbianco/monitor-table-change-with-sqltabledependency/issues/100
* https://github.com/christiandelbianco/monitor-table-change-with-sqltabledependency/issues/93

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 8.5.1.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
ADD FEATURES:
* Support for .NET Core 2.0, .Net Standard 2.0
* https://github.com/christiandelbianco/monitor-table-change-with-sqltabledependency/pull/89
* https://github.com/christiandelbianco/monitor-table-change-with-sqltabledependency/pull/83
* https://github.com/christiandelbianco/monitor-table-change-with-sqltabledependency/pull/79
* https://github.com/christiandelbianco/monitor-table-change-with-sqltabledependency/pull/78
* https://github.com/christiandelbianco/monitor-table-change-with-sqltabledependency/pull/77
* https://github.com/christiandelbianco/monitor-table-change-with-sqltabledependency/pull/76
* https://github.com/christiandelbianco/monitor-table-change-with-sqltabledependency/pull/63
* Solution Refactoring: TableDependency and TableDependency Where are now part of SqlTableDependency project.

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 7.5.0.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* https://github.com/christiandelbianco/monitor-table-change-with-sqltabledependency/issues/75

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 7.4.0.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* https://github.com/christiandelbianco/monitor-table-change-with-sqltabledependency/issues/18

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 7.3.0.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* https://github.com/christiandelbianco/monitor-table-change-with-sqltabledependency/issues/66
* https://github.com/christiandelbianco/monitor-table-change-with-sqltabledependency/issues/65

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 7.2.0.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* https://github.com/christiandelbianco/monitor-table-change-with-sqltabledependency/issues/58

ADD FEATURES:
* TableDependency.SqlClient.Where.dll for sql WHERE condition creation

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 7.1.0.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* https://github.com/christiandelbianco/monitor-table-change-with-sqltabledependency/issues/57

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 7.0.0.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* https://github.com/christiandelbianco/monitor-table-change-with-sqltabledependency/issues/56
* https://github.com/christiandelbianco/monitor-table-change-with-sqltabledependency/issues/54
* https://github.com/christiandelbianco/monitor-table-change-with-sqltabledependency/issues/53

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 6.2.0.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* https://github.com/christiandelbianco/monitor-table-change-with-sqltabledependency/issues/43
* https://github.com/christiandelbianco/monitor-table-change-with-sqltabledependency/issues/38
* https://github.com/christiandelbianco/monitor-table-change-with-sqltabledependency/issues/18
* https://github.com/christiandelbianco/monitor-table-change-with-sqltabledependency/issues/2

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 6.1.0.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* http://tabledependency.codeplex.com/workitem/72

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 6.0.0.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
REMOVED FEATURES:
* Stop() and Start(). See release Release 5.0.0.0

BUG FIXES:
* http://tabledependency.codeplex.com/workitem/64
* http://tabledependency.codeplex.com/workitem/67
* http://tabledependency.codeplex.com/workitem/68
* http://tabledependency.codeplex.com/workitem/71
* http://tabledependency.codeplex.com/workitem/70

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 5.3.0.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* Conversation population explosion: http://tabledependency.codeplex.com/discussions/662262

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 5.2.0.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
NEW FEATURES:
* Database logging

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 5.1.0.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
NEW FEATURES:
* Support for SQL Server 2008 R2
* WHERE condition for filtering notifications: Please refer to https://sqltabledependencywhere.codeplex.com

// Define WHERE filter specifing the WHERE condition
Expression<Func<Product, bool>> expression = p => (p.CategoryId == 1 || p.CategoryId == 2) && p.ItemsInStock <= 10;

ITableDependencyFilter whereCondition = new SqlTableDependencyFilter<Product>(expression);

var dep = new SqlTableDependency<Product>(connectionString, filter: whereCondition))

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 5.0.0.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
NEW FEATURES:
* Stop() and Start(): When SqlTableDependency host program crashes or stops, the SqlTableDependency stops tracking the changes and all the database objects 
created by SqlTableDependency are deleted. Since all the objects are deleted when the program stops, we are losing track of all the changes that happened since 
the program was down.

It is now possible to continue capture record table changes even if the program containing the SqlTableDependency stops; when the SqlTableDependency host 
program starts again, we will receive record table changes stored in the queue:

string sqlTableDependencyDbObjectsName = null;

try
{
    // Specifying teardown = false we will say SqlTableDependecy do NOT drops database QUEUE, TRIGGER and related batabase objects.
    tableDependency = new SqlTableDependency<TeardownTestSqlserver1Model>(ConnectionString, teardown: false);
    tableDependency.OnChanged += TableDependency_Changed;
    tableDependency.Start();
    
    sqlTableDependencyDbObjectsName = tableDependency.DataBaseObjectsNamingConvention;
                
    Console.WriteLine(@"Waiting for receiving notifications...");
    Console.WriteLine(@"Press a key to stop");
    Console.ReadKey();
}
finally
{
    tableDependency?.Dispose();
}

....
// Table recod changes happening here will be stored in SqlTableDependecy database QUEUE...
....

// To retrieve changes happened when SqlTableDependency was down, set namingForObjectsAlreadyExisting contructor parameter to naming convention get 
// from DataBaseObjectsNamingConvention property: 
try
{
    // Specifying teardown = false we will say SqlTableDependecy do NOT drops database QUEUE, TRIGGER and related batabase objects.
    tableDependency = new SqlTableDependency<TeardownTestSqlserver1Model>(ConnectionString, namingForObjectsAlreadyExisting: sqlTableDependencyDbObjectsName);
    tableDependency.OnChanged += TableDependency_Changed;
    tableDependency.Start();
    
    namingForObjectsAlreadyExisting = tableDependency.DataBaseObjectsNamingConvention;
                
    Console.WriteLine(@"Waiting for receiving notifications...");
    Console.WriteLine(@"Press a key to stop");
    Console.ReadKey();
}
finally
{
    tableDependency?.Dispose();
}

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.8.6.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* https://tabledependency.codeplex.com/workitem/57

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.8.5.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* https://tabledependency.codeplex.com/workitem/55

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.8.4.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* https://tabledependency.codeplex.com/discussions/660073

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.8.3.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* https://tabledependency.codeplex.com/workitem/54

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.8.2.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* Fix on DB objects disposition

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.8.1.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* https://tabledependency.codeplex.com/workitem/46

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.8.0.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* http://tabledependency.codeplex.com/workitem/48

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.6.7.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* http://tabledependency.codeplex.com/discussions/658146

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.6.6.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* ISSUE https://tabledependency.codeplex.com/workitem/42

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.6.5.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* ISSUE https://tabledependency.codeplex.com/workitem/41

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.6.4.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* ISSUE http://tabledependency.codeplex.com/workitem/40

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.6.3.1
---------------------------------------------------------------------------------------------------------------------------------------------------------------
NEW FEATURES:
* Strong Key

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.6.3.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* Internal fix to END Service Broker comminucation

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.6.3.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* Internal fix to END Service Broker comminucation

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.6.2.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* ISSUE https://tabledependency.codeplex.com/workitem/31

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.6.1.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
NEW FEATURES:
* Event on status change:

using (var tableDependency = new SqlTableDependency<SeatsAvailability>(connectionString, "FlightBookings"))
{
    tableDependency.OnStatusChanged += TableDependency_OnStatusChanged;
    tableDependency.Start();

    Console.WriteLine(@"Waiting for receiving notifications...");
    Console.WriteLine(@"Press a key to stop");
    Console.ReadKey();
    
    tableDependency.Stop();
}
            
private static void TableDependency_OnStatusChanged(object sender, StatusChangedEventArgs e)
{
    Console.WriteLine(@"Status: " + e.Status);
}

BUG FIXES:
* ISSUE http://tabledependency.codeplex.com/workitem/19

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.6.0.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
NEW FEATURES:
* Log:

using (var tableDependency = new SqlTableDependency<Customer>(connectionString, "Customer"))
{
   tableDependency.OnStatusChanged += TableDependency_OnStatusChanged;
   tableDependency.OnChanged += TableDependency_Changed;
   tableDependency.OnError += TableDependency_OnError;
   tableDependency.TraceLevel = TraceLevel.Verbose;
   
   tableDependency.TraceListener = new TextWriterTraceListener(Console.Out);

   OR
 
   tableDependency.TraceListener = new TextWriterTraceListener(File.Create("c:\\temp\\output.txt"));
   
   tableDependency.Start();

   Console.WriteLine(@"Waiting for receiving notifications...");
   Console.WriteLine(@"Press a key to stop");
   Console.ReadKey();
   tableDependency.Stop();
}

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.5.8.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* ISSUE https://tabledependency.codeplex.com/discussions/655211

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.5.7.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* ISSUE https://tabledependency.codeplex.com/workitem/24

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.5.6.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* ISSUE https://tabledependency.codeplex.com/workitem/27

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.5.5.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* ISSUE https://tabledependency.codeplex.com/workitem/21

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.5.4.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* ISSUE https://tabledependency.codeplex.com/workitem/29
* ISSUE https://tabledependency.codeplex.com/workitem/22

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.5.3.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* ISSUE https://tabledependency.codeplex.com/workitem/18
* ISSUE https://tabledependency.codeplex.com/workitem/17
* ISSUE https://tabledependency.codeplex.com/workitem/16

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.5.2.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
NEW FEATURES:
* Events only when the value change https://tabledependency.codeplex.com/discussions/650517

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.5.1.4
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* ISSUE http://tabledependency.codeplex.com/discussions/649610

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.5.1.3
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* ISSUE https://tabledependency.codeplex.com/workitem/14

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.5.1.2
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* ISSUE https://tabledependency.codeplex.com/workitem/10

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.5.1.1
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* ISSUE https://tabledependency.codeplex.com/workitem/11

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.5.1.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
NEW FEATURES:
* Possibility to define Encoding. By default this value is set to Encoding.Unicode. 

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.5.0.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
NEW FEATURES:
* Possibility to define DML database trigger, specifying INSERT, DELETE and or UPDATE. The following initialization will generate a trigger only for INSERT 
  operations. This means that SqlTableDependency will receive notification about only Insert and Update operations.

  SqlTableDependency<Item> tableDependency = new SqlTableDependency<Item>(
    ConnectionString,
    TableName,
    mapper,
    (IList<string>)null,
    DmlTriggerType.Insert | DmlTriggerType.Update,
    true);

* Model with System.ComponentModel.DataAnnotations support. Supposing a model as follow:

    [Table("Customers")]
    public class Client
    {
      public long Id { get; set; }
      public string Name { get; set; }
      [Column("Surname")]
      public string FamilyName { get; set; }
    }
  
  It is possible to create a SqlTableDependency without specifying table name and mapper:
  
    SqlTableDependency<Item4> tableDependency =  new SqlTableDependency<Client>(ConnectionString);
    tableDependency.OnChanged += TableDependency_Changed;
    tableDependency.Start();
  
  In case you do not want use data annotation, specify table name parameter constructor as well as ModelToTableMapper parameter.

* Possibility to define an UpdateOf list using lamba expression instead of List<string> only. With the following snippet we will
  receive a notification only when the FamilyName model property is changed (that is when the mapped database table column is
  updated):
    
    var updateOfModel = new UpdateOfModel<Client>();
    updateOfModel.Add(i => i.FamilyName);
    
    SqlTableDependency<Item> tableDependency = new SqlTableDependency<Client>(ConnectionString, updateOfModel);
    tableDependency.OnChanged += TableDependency_Changed;
    tableDependency.Start();
    
---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.2.0.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* ISSUE https://tabledependency.codeplex.com/workitem/9

CHANGES:
* .NET Framework 4.5.1 OR later versions (MANDATORY)

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Release 4.1.1.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
BUG FIXES:
* ISSUE https://tabledependency.codeplex.com/workitem/8
    
---------------------------------------------------------------------------------------------------------------------------------------------------------------
Version 4.1.0.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
NEW FEATURES:

* SqlTableDependency can accept a naming convention to use during its initialization. This means that it can reuse database Service Broker and Queue created
  previously. In case those objects are not present, SqlTableDependency create for you. In order to reuse Service Broker and Queue, create SqlTableDependency
  with automatic DatabaseObjectsTeardown constructor parameter set to false, in order to mantains the database objects when SqlTableDependency is disposed.

  Here is an example:I create SqlTableDependency. Then the application is closed. Because SqlTableDependency was create with
  automatic DatabaseObjectsTeardown = false, the queue is still alive and can continue to receive change notification and queuing the messages.

    var namingToUse = "CustomNaming";

    var mapper = new ModelToTableMapper<Check_Model>();
    mapper.AddMapping(c => c.Name, "FIRST name").AddMapping(c => c.Surname, "Second Name");

    using (var tableDependency = new SqlTableDependency<Check_Model>(ConnectionString, TableName, mapper, null, false, namingToUse))
    {
        tableDependency.OnChanged += TableDependency_Changed;
        tableDependency.Start();               
        ....
    }

  When the application restart we simply specify the same database object naming convention to use. SqlTableDependency detects that DB objects are
  in place and so it use them. In case those objects are not present, SqlTableDependency will create for us.

    var namingToUse = "CustomNaming";

    using (var tableDependency = new SqlTableDependency<Check_Model>(ConnectionString, TableName, mapper, null, false, namingToUse))
    {
        tableDependency.OnChanged += TableDependency_Changed;
        tableDependency.Start();
        ....
    }

---------------------------------------------------------------------------------------------------------------------------------------------------------------
Version 4.0.0.0
---------------------------------------------------------------------------------------------------------------------------------------------------------------
NEW FEATURES:   

* SqlTableDependency can accept VARCHAR(MAX), NVARCHAR(MAX), BINARY(8000), VARBINARY(MAX) and XML table column types.