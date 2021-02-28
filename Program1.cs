using System.Collections;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

//var result = Program.TwoProduct(new int[] { 1, 2, 3, 4, 13, 5 }, 39);
//var result = Program.TwoProduct(new int[] { 11, 2, 7, 3, 5, 0 }, 55);

    Console.WriteLine("C# 8.0 Asynchronouse stream example from Program1.cs");
    await foreach (int i in GenerateSequence())

    Console.WriteLine(i);

// (string a, string b) letters = ("Rabina","Chandan");
// var letters1 = letters;
 
//  letters1.a = "Nivaan";
//  letters1.b = "Shanaya";
//  Console.WriteLine(letters.a);
//  Console.WriteLine(letters.b);
//  Console.WriteLine(letters1.a);
//  Console.WriteLine(letters1.b);

// var developer = new Developer(fName:"Chandan",lname:"Gupta",Salary:1400, age:14);  //

// Car car = new() { Brand = "2",Color ="Red"};   // Init only property can be set duging obkect initialization oor during instance constructor.
// Car1 car1 = new(brand:"2", color:"red");     // Read only property Can only be set from constructor.




static async IAsyncEnumerable<int> GenerateSequence()
{
    for (int i = 0; i < 10; i++)
    {
        if (i % 3 == 0)
            await Task.Delay(1000);
        yield return i;
    }
}





// public class Program
// {
//     public static int[] TwoProduct(int[] arr, int prod)
//     {
//         var lookup = new Hashtable();
//         int[] output = new int[2];
//         for (int i = 0; i < arr.Length; i++)
//         {
//             if (arr[i] == 0) continue;
//             var isRemainder = prod % arr[i];
//             var dividend = prod / arr[i];

//             if (lookup.ContainsKey(arr[i]))
//             {

//                 if (prod / arr[i] < arr[i])
//                     output = new int[] { prod / arr[i], arr[i] };
//                 else
//                     output = new int[] { arr[i], prod / arr[i], };
//                 break;
//             }
//             if (isRemainder == 0)
//             {
//                 lookup.Add(dividend, true);
//             }
//         }
//         return output;
//     }
//     public static bool CheckPalindrome(string arr)
//     {
//         bool result = false;
//         int j = arr.Length - 1;
//         int length = arr.Length;
//         int midpoint = length % 2 == 0 ? length / 2: (length / 2)  + 1;
//         for (int i = 0; i < midpoint; i++)
//         {
//             if (arr[i] == arr[j])
//             {
//                 j = j - 1;
//                 result = true;
//             }
//             else
//             {
//                 result = false;
//                 break;
//             }

//         }
//         return result;
//     }
// }