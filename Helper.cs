public static class Helper
{
    public static bool IsLetter(this char c) =>
            c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';    // Patter Matching enhancements. C# 9  / Relational pattern matching is > < >= <=
             public static bool IsLetterOrSeparator(this char c) =>
                c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',';     /// Pattern matching enhance,emts    // Logical pattern matching is, and, or , & not
}