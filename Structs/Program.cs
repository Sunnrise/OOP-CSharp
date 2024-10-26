MyStruct myStruct = new ();


myStruct.x = 10;
myStruct.y = 5;
myStruct.z = true;
myStruct.Display();

myStruct.NewStruct();
Console.WriteLine(myStruct.y);
Console.WriteLine(myStruct.x);

Console.WriteLine(myStruct.y+myStruct.x);
struct MyStruct
{
    public bool z;
    public int x;
    public int y;
    public void Display()
    {
        if(z)
        {
            Console.WriteLine(x + y);
        }
        else
        {
            Console.WriteLine(x - y);
        }
    }
    public int MyProperty { get; set; }
    public void NewStruct()
    {
        this = new MyStruct();
    }
}