using System;

class Solution{
    public static void Main(string[] args){
        string x = "1000";
        int32 num = int32.Parse(x);
        // also use decimal float int64 int128 int256 to convert the value
        Console.WriteLine(num);

        string a = "true";
        bool flag = bool.Parse(a);
        Console.WriteLine(flag);
    }
}