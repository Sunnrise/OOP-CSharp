//MyClass m = new MyClass();
//MyClass.StaticMethod();

//class MyClass
//{
//    public static int staticField;
//    public int nonStaticField;
//    public static void StaticMethod() { }
//    public void NonStaticMethod() { }
//    public static int StaticProperty { get; set; }
//    public int NonStaticProperty { get; set; }

//}

MyClass1 m = new MyClass1();

class MyClass1 : MyClass2
{
    public MyClass1()
    {
        protectedField = 1;
    }
}

class MyClass2
{
    protected static int protectedField;
}