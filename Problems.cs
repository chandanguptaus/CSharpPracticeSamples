// using System;
// using System.Collections.Generic;
// using System.Text.Json;
// using System.Threading.Tasks;

// public interface IPatternMatchingService
// {
//     string FindMatchingPattern(string input, int patternLength);
// }
// #region Extension Method
// public static class StringHelper
// {
//     /// static method accepting string and patter length  int
//     // return multiple patterns key value pair Dictionary

//     // extemsion method.
//     public async static Task<string> FindMatchingPattern(this string input, int patternLength)
//     {
//         // Main concept use of Dictionary lookup to search for key value pairs.
//         // Dictionary lookup TimeComplexity is BigO(1) Space Complexity O(N)

//         // validation messages
//         const string emptyInputMesage = "Search String input or pattern length can't be empty.Please supply a valid input";
//         const string stingLessThanPatternLength = "Pattern length value should be less or equal to search string length. Please provide a valid string length or pattern length";
//         //input ??= string.Empty; // Check if input is null make it an empty string null coalescing assignment operator in C# 8


//         #region  Input Validations
//         // Validate if valid input supplied
//         // if (string.IsNullOrEmpty(input) || (patternLength <= 0))
//         //     throw new ArgumentNullException(emptyInputMesage); // string null validation check return empty output

//         // if (input.Length < patternLength)
//         //     throw new ArgumentOutOfRangeException(stingLessThanPatternLength); // string null validation check return empty output

//         var ex = ValidateInput(input, patternLength);  // Use of local function to Validate input. The scope is local to method.
//         if (ex is {} && ex.Message is not "") throw ex;  // logical pattern matching from C# 9.

//         #endregion
//         try
//         {
//             // Declare local variables.
//             Dictionary<string, int> output = new();  // Output multiple patterns and occurence of each pattern. key value pair.
//             Dictionary<string, int> lookupDict = new();
//             int looplength = input.Length - (patternLength - 1);  //To Fetch the length as per last occurence of pattern

//             // loop through the length of string uptill length - patternlength - 1
//             for (int i = 0; i < looplength; i++)
//             {
//                  await Task.Delay(1000);
//                 // Find the matching pattern length substring.
//                 var ptrnStrng = input.Substring(i, patternLength);
//                 // Check if key(sub-string) exists in Dictionary then increment occurence value by 1.
//                 if (lookupDict.ContainsKey(ptrnStrng))
//                 {
//                     lookupDict[ptrnStrng]++;
//                     int occurence = lookupDict[ptrnStrng];
//                     // set final output
//                     if (output.ContainsKey(ptrnStrng))
//                         output[ptrnStrng] = occurence;
//                     else
//                         output.Add(ptrnStrng, occurence);
//                 }
//                 else
//                     lookupDict.Add(ptrnStrng, 1);
//             }
//             return JsonSerializer.Serialize(output);
//             // (string input, in)
//             //         Exception exception = new Exception();
//             //         if (string.IsNullOrEmpty(input) || (patternLength <= 0))
//             //         exception = new ArgumentNullException(emptyInputMesage); // string null validation check return empty output
//             //     if (input.Length < patternLength)
//             //         exception = new ArgumentOutOfRangeException(stingLessThanPatternLength); // string null validation check return empty output
//             //     return exception;
//             // };

//         }
//         catch (Exception excption)
//         {
//             throw excption;
//         }
//         // C# 9 static local functions inside a method,
//         Exception ValidateInput(string input, int patternlength) =>
//         (input, patternLength) switch
//         {
//             var (x, y) when string.IsNullOrEmpty(x) || y is <= 0 => new ArgumentNullException(emptyInputMesage),
//             var (x, y) when x.Length < y => new ArgumentOutOfRangeException(stingLessThanPatternLength),
//             _ => new Exception("")
//         };


//     }
// }
// #endregion

// // #region UsingInterfaces
// // public class PatternMatchingService : IPatternMatchingService
// // {
// //     public string FindMatchingPattern(string input, int patternLength)
// //     {
// //         // Copy same code goes here as inside string helper static class extension method.
// //     }
// // }
// // #endregion