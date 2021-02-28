using System;
using CommercialRegistration;
using ConsumerVehicleRegistration;
using LiveryRegistration;


/*
C# 7.0
Type Pattern and Cosntant pattern by comparing type of an object  
C# 8.0
Switch Expression.
Positional using Decostructor
Property by comparing the property of an object.
Tuple by comparng more then 1 value
Relational  /// Realtional > < >= <=     C # 9
Logical   //// Logical pattern matching is, and, or , & not C # 9

Mind map - P_P_T_T_RL   Positional , Property, Tuple , Type, Relational, Recursive, lOGICAL.
case 0: is the familiar constant pattern. 
case IEnumerable<int> childSequence: is a type pattern. 
case int n when n > 0: is a type pattern with an additional when condition. 
case null: is the null pattern. 
default: is the familiar default case. 
*/
public class RainbowClass
{
    public enum Rainbow
    {
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Indigo,
        Violet
    }

    /// New Switch Expression
    public static string FromRainbow(Rainbow colorBand) =>
     colorBand switch
     {
         Rainbow.Red => "",
         Rainbow.Orange => "",
         Rainbow.Blue => "",
         Rainbow.Green => "",
         Rainbow.Yellow => "",
         Rainbow.Indigo => "",
         Rainbow.Violet => "",
         _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(colorBand)),
     };

    // Property Pattern lets you match on class object Properties.
    public class Address
    {
        public string? State { get; set; }
        public string? City { get; set; }

    }
    public static decimal ComputeSalesTax(Address location, decimal salePrice) =>
    location switch
    {
        { State: ("WA" or "AZ") } and { City: "Bellevue" or "Phoenix" } => salePrice * 0.06M,
        { State: ("WA" or "AZ") } and { City: "Redmond" or "Mesa" } => salePrice * 0.06M,
        //{ State: "MN" } => salePrice * 0.075M,
        { State: "MI" } => salePrice * 0.05M,
        // other cases removed for brevity...
        _ => 0M
    };

    /* 
   //Tuple patterns
   Some algorithms depend on multiple inputs. 
   Tuple patterns allow you to switch based on multiple values expressed as a tuple. 
   */
    public static string RockPaperScissors(string first, string second)
    => (first, second) switch
    {
        ("rock", "paper") => "rock is covered by paper. Paper wins.",
        ("rock", "scissors") => "rock breaks scissors. Rock wins.",
        ("paper", "rock") => "paper covers rock. Paper wins.",
        ("paper", "scissors") => "paper is cut by scissors. Scissors wins.",
        ("scissors", "rock") => "scissors is broken by rock. Rock wins.",
        ("scissors", "paper") => "scissors cuts paper. Scissors wins.",
        (_, _) => "tie"
    };

    /*
    Positional patterns
    When a Deconstruct method is accessible, you can use positional
     patterns to inspect properties of the object and use those properties for a pattern. Co
    */
    public class Point
    {
        public int X { get; }
        public int Y { get; }
        public Point(int x, int y) => (X, Y) = (x, y);
        public void Deconstruct(out int x, out int y) =>
            (x, y) = (X, Y);
    }
    public enum Quadrant
    {
        Unknown,
        Origin,
        One,
        Two,
        Three,
        Four,
        OnBorder
    }
    static Quadrant GetQuadrant(Point point) => point switch
    {
        (0, 0) => Quadrant.Origin,
        var (x, y) when x > 0 && y > 0 => Quadrant.One,
        var (x, y) when x < 0 && y > 0 => Quadrant.Two,
        var (x, y) when x < 0 && y < 0 => Quadrant.Three,
        var (x, y) when x > 0 && y < 0 => Quadrant.Four,
        var (_, _) => Quadrant.OnBorder,   // discard
        _ => Quadrant.Unknown
    };

    // Type matching patterns
    //The case keyword is omitted, and the result of each arm is an expression.
    public class TollCalculator
    {
        public decimal CalculateToll(object vehicle) =>
            vehicle switch
            {
                DeliveryTruck d when d.GrossWeightClass > 40 => 1.00M,  // Type matching and conditional expression.
                Car { Brand: "Honda" } and { Color: "Silver" } => 2.00m,  /// this is a switch arm Constant pattern Property matching
                Car c when c.Brand is "Honda" => 2.00m,
                Car { Brand: "Honda" } => 2.10m,  /// this is a switch arm Type and Property matching
                Car { Brand: "Toyota" } => 3.00m,  /// this is a switch arm  Type and // Property matching
                Taxi { Fares: 0 } => 3.50m + 1.00m,
                Taxi { Fares: 1 } => 3.50m,
                Taxi { Fares: 2 } => 3.50m - 0.50m,
                Taxi t => 3.50m - 1.00m,
                Bus b when ((double)b.Riders / (double)b.Capacity) < 0.50 => 5.00m + 2.00m, // Relational pattern matching and Type matching
                Bus b when ((double)b.Riders / (double)b.Capacity) > 0.90 => 5.00m - 1.00m,
                Bus b => 5.00m,
                DeliveryTruck t => 10.00m,
                ///any non null object that did match an earlier arm
                { } => throw new ArgumentException(message: "Not a known vehicle type", paramName: nameof(vehicle)),
                null => throw new ArgumentNullException(nameof(vehicle))  
                // Property
            };


        public decimal CalculateNewToll(object vehicle) =>
            vehicle switch
            {
                CarNew c => c.Passengers switch   // Type matching Recursive pattern on Property.
                {
                    0 => 2.00m + 0.5m,
                    1 => 2.0m,
                    2 => 2.0m - 0.5m,
                    _ => 2.00m - 1.0m
                },

                Taxi t => t.Fares switch    // Recursive pattern
                {
                    0 => 3.50m + 1.00m,
                    1 => 3.50m,
                    2 => 3.50m - 0.50m,
                    _ => 3.50m - 1.00m
                },

                Bus b when ((double)b.Riders / (double)b.Capacity) < 0.50 => 5.00m + 2.00m,
                Bus b when ((double)b.Riders / (double)b.Capacity) > 0.90 => 5.00m - 1.00m,
                Bus b => 5.00m,

                DeliveryTruck t when (t.GrossWeightClass > 5000) => 10.00m + 5.00m,
                DeliveryTruck t when (t.GrossWeightClass < 3000) => 10.00m - 2.00m,
                DeliveryTruck t => 10.00m,

                { } => throw new ArgumentException(message: "Not a known vehicle type", paramName: nameof(vehicle)),
                null => throw new ArgumentNullException(nameof(vehicle))
            };
    }

}

namespace ConsumerVehicleRegistration
{
    public class CarNew
    {
        public int Passengers { get; set; }
    }
}

namespace CommercialRegistration
{
    public class DeliveryTruck
    {
        public int GrossWeightClass { get; set; }
    }
}

namespace LiveryRegistration
{
    public class Taxi
    {
        public int Fares { get; set; }
    }

    public class Bus
    {
        public int Capacity { get; set; }
        public int Riders { get; set; }
    }
}