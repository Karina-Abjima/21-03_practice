class MyClass
{
    
    string color = "red";        
    int maxSpeed = 200;          
    public void fullThrottle()  
    {
        Console.WriteLine("The car is going as fast as it can!");
    }
    static void Main(string []args)
    {
        MyClass obj = new MyClass();
        obj.color = "red";
        Console.WriteLine(obj.color);
        obj.fullThrottle();
    }
}
