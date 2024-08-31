using System;

class Solution
{
    public static void Main(string[] args)
    {
        decimal d = 100.909090m; // Use 'm' to specify that it's a decimal

        // Convert decimal to various types
        int intValue = Convert.ToInt32(d);
        long longValue = Convert.ToInt64(d);
        float floatValue = Convert.ToSingle(d);
        double doubleValue = Convert.ToDouble(d);
        bool boolValue = Convert.ToBoolean(d); // Non-zero decimal converts to true

        // Output the converted values
        Console.WriteLine($"Converted to int: {intValue}");
        Console.WriteLine($"Converted to long: {longValue}");
        Console.WriteLine($"Converted to float: {floatValue}");
        Console.WriteLine($"Converted to double: {doubleValue}");
        Console.WriteLine($"Converted to bool: {boolValue}");
    }
}