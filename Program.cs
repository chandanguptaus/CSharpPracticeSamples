using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;
namespace Practice
{
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
             #region C#7
    //         //////
            // 1. Binary literals
            // 2. Digit separators, 
            // 3. Out variable
            // 4. Local functions, 
            // 5. Ref returns and locals, 
            // 6. Tuples, 
            // 7. Pattern matching, 
            // 8. Deconstruction
            #region Out variable improvements
            // EXP - reduce the pain of writing extra code and you can just pass argument without initializing them.
            // 1.  Inline Out variable declaration
            // if (DateTime.TryParse("01/01/2019", out var dt))
            // {
            //     Console.WriteLine(dt);
            // }
            // string input;   // non need to iniitizlie a variable.
            //   AssignValue(out string input);   // pass directly to the method using data type Can define variable as argument directly.
            // AssignValue(out var input);   // pass directly to the method using var C# give freedom to use a var
            //   Console.WriteLine(input);

            #endregion
            #region PatternMatching
            // to bring power to expression and statements
            /// can perform on any data type in two cases is expression and switch statements. can extract values from yur expression
            // 2. Pattern Matching C# typecast
            //     string age ="21";
            //     object ageVal = age;
            //     if (ageVal is string ageparse)
            //     {
            //         Console.WriteLine($"Your age is " + ageparse);
            //     }
            //   //  Example 2
            //   var emp = new Employee("Chandan","Gupta",true);  // record type C# 9 feature
            //   var emp1  = new Employee("Chandan", "Gupt1a", true);
            //   Console.WriteLine(emp.Equals(emp1));

            //     // Employee emp2 = new Employee { FirstName = "Rabina", LastName = "Gupta", IsManager = false };
            //     Customer cust1 = new Customer { FirstName = "Vivek", LastName = "Gupta", TotalDollarsSpent = 1300 };
            //     Customer cust2 = new Customer { FirstName = "Annie", LastName = "Gupta", TotalDollarsSpent = 1000 };
            //     List<object> people = new List<object> { emp, cust1,cust2 };

            //     foreach (var p in people)
            //     {
            //         switch (p)
            //         {
            //             case Employee e when (e.IsManager == false):     // Resolves employee and puts in variable e.
            //                 Console.WriteLine($"Employee  type is general is {e.FirstName} {e.LastName}");
            //                 break;
            //             case Employee e when (e.IsManager == true):
            //                 Console.WriteLine($"Employee type is manager {e.FirstName} {e.LastName}");
            //                 break;
            //             case Customer c when (c.TotalDollarsSpent > 1200):
            //                 Console.WriteLine($"Priviliged Customer is {c.FirstName} {c.LastName}");
            //                 break;
            //            case Customer c:
            //                 Console.WriteLine($"Normal Customer is {c.FirstName} {c.LastName}");
            //                 break;
            //             default:
            //                 break;

            //         }
            //     }
            #endregion
            #region Throw in Expressions in Line
            // try
            // {
            //     Employee emp1 = new Employee { FirstName = "Chandan", LastName = "Gupta", IsManager = false };
            //     Employee emp2 = new Employee { FirstName = "Rabina", LastName = "Gupta", IsManager = false };

            //     List<Employee> empList = new List<Employee> { emp1, emp2 };



            //     var mgrEmp = empList.Where(s => s.IsManager == true).FirstOrDefault() ?? throw new Exception("There was a problem finding the manager");  // throw in expressions

            //     // if (mgrEmp == null)  // DONT NEED TO ADD THIS LINE OF code 
            //     // {

            //     // }
            //     Console.WriteLine($"The manager name is {mgrEmp.FirstName} {mgrEmp.LastName}");
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine(ex.Message);
            // }
            #endregion
            #region Improved Tuples object with multiple values - Return more than 1 return value
            // often we want to return more than multiple methods.
            // previpusly ising class, out parameters and anonymous type.
            // its a data structure that provides an easy way to represent a single set of data. System.tuple class provides static class to create tuple objects.
            // Return multiple values from a method by return tuple ()
            //    var name = SplitName("Chandan Gupta");

            //  (string fName, string lname) name = SplitName("Chandan Gupta");
            //     Console.WriteLine($"{name.fName} and last name is  {name.lname}");

            // static (string FirstName, string lastName) SplitName(string name)
            // {
            //     string[] vals = name.Split(" ");

            //     return (vals[0], vals[1]);
            // }
            // using tuple consturctor. need to tell the type.
            // var author = new Tuple<string, string, int>("Chandan","Rabina",22);
            // Console.WriteLine($"{author.Item1} {author.Item2} {author.Item3}");

            // using create method
            // var author = Tuple.Create("Chandan", "Rabina", 22);
            // Console.WriteLine($"{author.Item1} {author.Item2} {author.Item3}");

            #endregion
            #region BinaryLiteral format-- Binary is prefixed with 0b prefix in front. Internally its an int just dressed to looklike a binary.
            // var i = 0b101010101;
            // var j = 0b101011101;
            // Console.WriteLine(i);
            // Console.WriteLine(i.GetType());
            //         Console.WriteLine(i + j);   // support addition.
            // #endregion
            #endregion
            #region Digit Separator
            // Improves the readability of the code. Add _ to the numeric literal to improve the readability.
            //// lIMITATION - Can't be added at the first and end of numeric value;
            // Can't appear next to decimal... 0_.01 cant do this. Cant be used for exponential character 1.1e_1;
            /// cant be used next to the  hexadecimal or binary prefix characters so you can do this 0x_11111 nor can you do this 0b_1c;
            // int bin = 0b1001_1010_0001_0100;
            // int data = 1_2_3_4_5_6_7;
            // double weed = 123_2.58;

            // Console.WriteLine(bin);
            // Console.WriteLine(data);
            //  Console.WriteLine(weed);


            #endregion
            #region Local functions in C# 7
            /// declarations - Convert  a private methid to a local method
            // less code in the outer method . no need to create extra privtae method
            /// local function can access local variables of the method see below.

            //  int a = 1;
            //  int b = 2;
            // Console.WriteLine(Add());
            // int  Add() => a + b;
            // int Add(int i, int j)
            // {
            //     return i + j;

            // }

            #endregion
            #region Ref returns and local
            // value can be returned and stored locally by reference
            //  improved ref keyworkd that can be used to return by ref.
            // Ref can also be used for storing values by ref in the local variable.
            // int[] numbers = {1,2,3,4,5,6};

            // // call a method that returns by ref.
            // ref int item = ref GivemeNumbers(numbers,2);
            // Console.WriteLine(item);
            // item = 40;   // REPLACE 3rd item in array to 40;
            // Console.WriteLine(item.GetType());
            // Console.WriteLine(numbers[2]);

            // ref int GivemeNumbers(int[] arr, int index)
            // {
            //          return ref arr[index];
            // }


            #endregion

            /// Summary
            // out variables can declare andused in an excpression
            // patern matching if (x is Foo f)
            // case Fooo f when 
            // Local function declaration
            // anywhere in containin function
            // ref locals work on vars and arrays not strings/list etc
            // no real validity checks
            // some code constructs dont work wel  with ref
            // Ref returns from methods.
            // shortcuts - CTRL K + 0 Fold all Search anything CTRL + SHIFT + P;
            //
            // Collapse All is Fold All in Visual Studio Code.
            // Press Ctrl + K + S for All keyboard shortcuts settings. Assign a key which you want for Fold All. By default it's Ctrl + K + 0.
            // Shift + Alt + F to organize everything.
            #endregion

            #region C# 7.1
            #region Default literal
            //    int i = default;
            //    int? defvalue = default;  // null
            //    string s = default;
            //Console.WriteLine(defvalue);
            //    Double dbl = default;
            #endregion
            #region Enhanced Tuples
            // tuples
            //var me = (name:"Chandan", age: 1);
            //Console.WriteLine(me.name + me.age);
            //  var me = ("Chandan", age: 1);
            //  Console.WriteLine(me.Item1 + me.Item2);

            #endregion
            #region Implicit type array and tuples
            // Implicit type array
            // var months = new[] { "Chandan", "Rabina", "Vivek", "Annie" };  // Dont need to define the array type implicit type array declaration
            // var result = months.Select(m=> (length:m.Length,FirstCharacter:m[0])).Where(t => t.length > 6);
            // WriteLine(String.Join(",",result));

            // var dt = DateTime.Now;
            // var u = (dt.Hour, dt.Minute);
            // var v = ((u.Hour, u.Minute) = (1,2)); // CAN ASSIGN tuples to assigna new value

            // WriteLine(v);
            #endregion
            #endregion

            #region C# 8.0
            /// Summary More modern more productive
            // #region Pattern based null check
            // // Handling nulls
            // Person person = new Person("Ashwani", "Gupta");
            // var length = GetMiddleNameLength(person);
            // Console.WriteLine(length);
            // int GetMiddleNameLength(Person person)
            // {
            //     //  if (person?.MiddleName is null) return 0;  // Pattern matching
            //     /// check if an object 
            //     // if (person?.MiddleName is {} middle ) return middle.Length
            //     if (person?.MiddleName is { Length: var length })    // Pattern based null checking assign length to var length
            //         return length;   //{} is object or means something
            //     return 0;

            //     //  return person.MiddleName?.Length ?? 0;  // ?? nulll coealescing operator
            // }
            #region ReadOnly Members
            /*
             see coordinates struct below
            You can apply the readonly modifier to members of a struct. It indicates that the member doesn't
            modify state. It's more granular than applying the readonly modifier to a struct declaration.
            Consider the following mutable struct:
            */
            #endregion
            #region Using Declaration
            // Using declaration now has a shortcut
            // using (var con = new class())   // its basically a try catch finalluy block
            //    {
            //    } /// dispose connection object here

            // New way without curly braces
            //    using var con = new Conn()   // connection is disposed at end of function dispose is called
            // or when con object goes out of scope.
            #endregion
            #region Default interface method
            /* 
            Adds default interface implementation for upgrading interfaces.
            add a default method to interface so all clasess inherting the interafce can use this or provide its own implementation.
            Extending an interface by adding new implementations without breakign the current impementations.
            This language feature enables API authors to add methods to an interface in 
            later versions without breaking source or binary 
            compatibility with existing implementations of that interfac
            */
            // ShoppingCart cart = new ShoppingCart();
            // IShoppingCart icart = cart;
            // icart.CalculateSubTotal();   // Default impementation added to interfaces which all classes can make use of.

            #endregion
            #region Asynchronouse streams
            /*
             Starting with C# 8.0, you can create and consume streams asynchronously. 
            A method that returns an asynchronous stream has three properties:
            It's declared with the async modifier.
            It returns an IAsyncEnumerable<T>.
            The method contains yield return statements to return successive elements in the asynchronous stream.
            */
            // await foreach (var number in GenerateRandom())
            // {
            //     Console.WriteLine(number);
            // }
            #endregion
            #region More Patterns in more places
            /*  
              1  Switch expressions 
                    -- See Patterns.cs
            2. Property Pattern
                  See Patterns.cs Address
        3.   Tuple pattern matches on multiple values.

            */
            #endregion
            #region IndicesAndRanges
            /*
            Indices and ranges provide a succinct syntax for accessing single elements 
            or ranges in a sequence.
            */
            // var places = new string[] { "first", "second", "third", "fourth", "fifth" };

            // Console.WriteLine($"The last item in the list is {places[^1]}");
            // Console.WriteLine($"The last item in the list is {places[^2]}");

            // foreach (var item in places[2..4])
            // {
            //     // Console.WriteLine($"The  item in the list is {item}");
            // }

            // foreach (var item in places[1..^1])  // from 2 untill second last not inclduign last
            // {
            //     // Console.WriteLine($"The  item in the list is {item}");
            // }

            // foreach (var item in places[..^1])  // from 1 untill second last not inclduing last
            // {
            //     // Console.WriteLine($"The  item in the list is {item}");
            // }
            // foreach (var item in places[1..])  // from 2 untill second last 
            // {
            //     Console.WriteLine($"The  item in the list is {item}");
            // }
            #endregion
            #region NullCoalescingAssignment
            /* ??=  Check for null and if null then assign it to object.
             You can use the ??= operator to assign the value of its right-hand operand to its
              left-hand operand only if the left-hand operand evaluates to null.
            /*
            List<int> numbers = null;
             int? i = null;
            numbers ??= new List<int>();
            numbers.Add(i ??= 17);
            numbers.Add(i ??= 20);

            */
            #endregion
            #region NullableReferenceType
            /*
            <Nullable>enable</Nullable> in .csproj file.
            add ? to referencet types
            */
            #endregion
            #region static Local Function
            /*
            The following code contains a static local function. It can be static because it doesn't access any variables in the enclosing scope                
             */
            // int M()
            // {
            //     int y = 5;
            //     int x = 7;
            //     return Add(x, y);
            //     static int Add(int left, int right) => left + right;
            // }
            #endregion
            #region Enhancement of interpolated verbatim strings
            /**
             Order of the $ and @ tokens in interpolated verbatim strings can be any:
              both $@"..." and @$"..." are valid interpolated verbatim strings.
            */
            #endregion
            #region Async Await Example
            // var Tea = Kitchen.MakeTeaAsync();
            // Console.WriteLine("Making Tea");

            // var teacontent = await Tea;
            // Console.WriteLine(teacontent);
            #endregion
            #endregion

            #region C#9.0
            #region Top Level statements
            // 1. top level code 
            // 1. Top Level Statements -  In .NET 5.0 No need to add Main method
            // a. Remove unncessary ceremonies and main method
            // b. Make code much simpler to use
            // c. Only one class can have top level statements
            // d. Shortcut
            // e. If you need args then you need full Main method
            // example
            // using System;
            // Console.WriteLine("Hello World!");
            // Console.Writeline(Add(x + y));
            // Static double Add(double x, double y)
            // {
            //     Return x +y;
            // }
            #endregion
            #region Init Only Setters
            //Car1 car1 = new Car1("Hona", "red");   /// Can be set using constructor or construction phase.<!-- Once its set it becoms read only-->
            //car.Brand ="";    // cant do this because record has already been created.
            //Car car = new() { Brand = "Toyota",Color = "White" };  // Use property initializers syntax to set 
            //Car car = new Car() {Brand = "Toyota",Color = "White"}; // can declare like this as well.
            //// values in create expressions.

            //car.Brand ="";    // again cant do this 
            // // Callers can use property initializer syntax to set the values, 
            // // while still preserving the immutability:
            // // because record has already been created and properties initialized using create expressions.
            // // But, changing an observation after initialization is an error by assigning
            // // to an init-only property outside of initialization:
            #endregion
            #region Shortening the object type creation
            // Car car = new();   // Dont use type again new Car(). Shortening the object construction type
            // Car car1 = new Car { Brand = "Hinda", Color = "red" };  // Done need to use Car class again
            // Car car2 = new() { Brand = "Hinda", Color = "red" };   // New syntax to initialize properties.

            // Car car3;
            // car3 = new();    // Dont DO THIS. Its valid but type is not known.
            // Car1 car4 = new(brand: "", color: "red");   // New syntax to initialize properties using constructor .


            #endregion
            #region Relational Pattern Matching in Switch Expression
            // Type pattern based on matcing type.
            // Relational pattern matching is > < >= <=
            //// Logical pattern matching is, and, or , & not
            //Type patterns match a variable is a type
            // Parenthesized patterns enforce or emphasize the precedence of pattern combinations ()
            // Conjunctive and patterns require both patterns to match
            // Disjunctive or patterns require either pattern to match
            // Negated not patterns require that a pattern doesn’t match
            // Relational patterns require the input be less than, greater than, less than or equal, or greater than or equal to a given constant.

            // WeatherForeCastService weatherservices = new();  /// Seee WeatehrForeCasetService.cs
            // var dt = new DateTime();
            // dt = DateTime.Parse("13/12/2021");
            // WeatherForecast[] result =  weatherservices.GetForeCastAsync(dt);
            // foreach (var item in  result)
            // {
            //     Console.WriteLine($"{item.TemperatureInF} {item.Summary}");
            // }
            //Console.WriteLine(Helper.IsLetter('c'));    // Pattern matching example Extesion method.
            //Console.WriteLine(Helper.IsLetterOrSeparator('0'));    // Extesion method.


            #endregion
            #region Records
            /* 
            1. Immutable reference types that cant be changed.
            2. Thread safe. Easy ./ safe to share.
            3. records See Employee.cs record Employee(string FirstName, string LastName, bool IsManager);    // record type
            4. No need for boiler plate code.converts into a single line and less error prone clearn code
            5. Records are immutable reference types. Read only properties. Immutable value cant be changed. Its read only.
            6.They provide value based and type based equality check instead of comparing the references for classes.
            7. Can write thread safe code
            8. Gethascode by default.
            9. Copy and clone
            When to use records
             1. API Calls. Capturing external data that doesnt change.
             2. Processing data but not changing data.
             3. Anytime you want to work with read only data.<!--
            When not to use records
              -When you need to change data.

             Deconstruct a method using tuple. Support inheritance. Automatically generates all the functionality and methods above.
            */

            // var developer = new Developer("Chandan", "Gupta", 37, 5000); 
            //  Developer developer = new(fName:"Chandan", lname:"Gupta", age:37, Salary:5000);  // declare like this named arguments
            // var emp = new Employee("Chandan", "Gupta", 37);
            // //emp.FirstName = ""    /// Its immutable.It creates init only properties whcih can onl be initialized during obkect initilzed.
            // var result = developer == emp;

            //  (string fname, string lname, int age1) = developer;   // Object Deconsrtcution in a tuple.

            //  Console.WriteLine(developer);
            //  Console.WriteLine(developer.SayHello());

            //developer.FirstName = "Rabina"  /// Cant do this as its immutable.
            // we can clone or make a copy of a record using with to create a new object with changed property values.
            //var developer1 = developer with {FirstName = "Rabina"};  // Returns a new record copy object with different name value.
            //  var developer2 = developer with {};  // Returns a new instance object with similar values and type.
            // Console.WriteLine(developer1.ToString());
            //Console.WriteLine(developer == developer1); /// False as name differs
            //Console.WriteLine(developer == developer2); /// False as name differs

            //**************
            /* DO NOT DO THIS */
            // donot us set properties. It will make then mutable.
            // No constructor so no destructor.

            //****************

            #endregion

            // Memory Dump. Learning C# 9.0
            /// Remember T,R,R,I,S  
            // Top level statements, Records, Relational pattern matching, Init setters and shorterning the object creation
            #endregion

            // private static void AssignValue(out string sttName)
            // {
            //     sttName = "From out";

            // // }
            // public static async IAsyncEnumerable<int> GenerateRandom()
            // {
            //     Random rnd = new Random();
            //     for (int i = 0; i <= 5; i++)
            //     {
            //         await Task.Delay(2000);
            //         yield return rnd.Next();
            //     }
            // }
            // public Person Population(List<object> persons)
            // {
            //     foreach (var person in persons)
            //     {
            //         person switch
            //         {
            //             Employee emp when (emp.IsManager == true):


            //         }
            //      }
            // }

            // Challenges

            //     }
            // }

            // public struct Point
            // {
            //     public double X { get; set; }
            //     public double Y { get; set; }
            //     public readonly double Distance => Math.Sqrt(X * X + Y * Y);

            //     public readonly override string ToString() =>   // Members of a struct can be made read only.
            //         $"({X}, {Y}) is {Distance} from the origin";
            //}


    //     }
    // }
}