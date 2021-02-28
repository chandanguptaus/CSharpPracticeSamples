public class Person
{
    public string FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string LastName { get; set; }
    public Person(string fName, string lName)
    {
        FirstName = fName;
        LastName = lName;
    }
    public Person(string fName, string mName, string lName)
    {
        FirstName = fName;
        MiddleName = mName;
        LastName = lName;
    }
}