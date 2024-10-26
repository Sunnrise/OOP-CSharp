MyRecordStruct m = new MyRecordStruct(1,2);

MyRecord m2 = new MyRecord(1, "2");

Console.WriteLine(m.ToString());
Console.WriteLine(m2.ToString());

//m.x = 1;

var m3 = m with { x = 2, y = 5 };


readonly record struct MyRecordStruct(int x, int y)
{
    public static void StaticMethod() { }
    public void NonStaticMethod() { }
    public static int StaticProperty { get; set; }
}

record class MyRecord(int x, string y)
{
   
}