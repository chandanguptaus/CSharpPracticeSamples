// public class Employee
// {
//     public string? FirstName { get; set; }
//     public string? LastName { get; set; }
//     public bool IsManager { get; set; }

// }

record Employee(string FirstName, string LastName, int age);    // positional record type created  three read only properties
record Developer : Employee  /// Traditional syntax to create a record.
{
    public int _salary { get; }
    public Developer(string fName, string lname, int age, int Salary) : base(fName, lname, age) => _salary = Salary;
    public string FullName { get => $"{FirstName} { LastName}"; }
    public string SayHello() => $"Hello from {FullName}";
}

// record Developer(string fName, string lname, int age, int Salary) : Employee(fName, lname, age)   // New Positional syntax to create properties inheritnac from other recprd.
// {       
//        public string ShortName => FirstName.Substring(1,2);
//        public string FullName { get => $"{FirstName} { LastName}"; }
//        public string SayHello() => $"Hello from {FullName}";
// };