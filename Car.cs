
// C# 9 Initializations. Becomes immutable after the class is set as init.
public class Car
{
    public string? Brand { get; init; }
    public string? Color { get; init; }
}


// old school way to make a class immuable means not changing after it has been created. New way above using C# 9.
public class Car1
{
    public string? Brand { get;}  // readonly property  only setters in C# 9.0
    //  public string? Brand {get;private set;}  // Property can only be set from inside the class while init only once set becomes immutable 
    public string? Color { get;}   // readonly only can only be set from inside the class during the contructor.

    public Car1()
    {

    }
    public Car1(string brand, string color)
    {
        Brand = brand;
        Color = color;
    }
    public void SetVal(string brand)
    {
        // Brand = brand;     // INIT ONLY properties can only be set thorugh constructor during construction phase. Only private set can be set from inside
        // the class
    }
}