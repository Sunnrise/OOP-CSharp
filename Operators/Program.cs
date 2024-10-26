#region Null Conditional Operator ?

//Person person = null;
//if (DateTime.Now.Day == 30)
//    person = new();

////if(person != null)
////    Console.WriteLine(person.Name);


//// Null Conditional Operator
//Console.WriteLine(person?.Name);


//class Person
//{
//    public string Name { get; set; }
//}

#endregion

#region Null Coalescing Assignment Operator ??

//Person person = null;

////if (person == null)
////{

////    person = new();
////}

//// Null Coalescing Operator
//person ??= new();

//class Person
//{

//}

#endregion

#region null(?) Operator & Nullablee<T>

#endregion

#region Is operator

Person person = new()
{
    Name= "Alperen",
    Age = 25,
    Married = false
};

if(person.Name =="Alperen"&& person.Age >=20)
{
    Console.WriteLine("Name is string");
}

if(person is { Name: "Alperen", Age: >= 20, Married: false })
{
    Console.WriteLine("Name is string");
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public bool Married { get; set; }
}
#endregion