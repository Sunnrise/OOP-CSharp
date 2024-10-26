

#region 
//using System.ComponentModel;
//using System.Reflection;

//DatabaseType dbType = DatabaseType.mysql;
//Console.WriteLine(dbType);

//string dbTypeString = "postgresql";

//DatabaseType databaseType = (DatabaseType)Enum.Parse(typeof(DatabaseType), dbTypeString);

//Console.WriteLine(databaseType);

//int d = 2;

//DatabaseType databaseType2 = (DatabaseType)d;
//Console.WriteLine(databaseType2);

//Console.WriteLine((int)DatabaseType.postgresql);

//Enum.GetValues(typeof(DatabaseType)).Cast<DatabaseType>().ToList().ForEach(x => Console.WriteLine(x));

//DatabaseType dbType2 = DatabaseType.mysql;
//var description = dbType2.GetType()
//    .GetField(dbType2.ToString()).GetCustomAttribute<DescriptionAttribute>().Description;

//Console.WriteLine(description);

//dbType2.GetType().GetFields().Select(f =>
//{
//var descriptionAttribute = f.GetCustomAttribute<DescriptionAttribute>();
//return descriptionAttribute == null ? f.Name : descriptionAttribute.Description;

//})
//    .Where(d => d != null)
//    .ToList().ForEach(d => Console.WriteLine(d));

//Console.WriteLine(description);
//enum DatabaseType
//{
//    [Description("MySQL Database")]
//    mysql,
//    [Description("Microsoft SQL Server Database")]
//    mssql,
//    [Description("Oracle Database")]
//    oracle,
//    [Description("PostgreSQL Database")]
//    postgresql = 25,
//    [Description("MongoDB Database")]
//    mongodb
//}
#endregion

#region PermissionEnum

Permissions permissions = Permissions.X | Permissions.Y | Permissions.Z;
Console.WriteLine(permissions);

[Flags]
enum Permissions
{
    X=1,
    Y=2, 
    Z=4,
    W=8
}
#endregion