using System;

class Solution{
    public static void Main(string[] args){
        string a = "this is a test";
        int n = a.Length;
        Console.WriteLine(n);

        string upper = a.ToUpper();
        Console.WriteLine(upper);

        string lower = a.ToLower();
        Console.WriteLine(lower);

        string x = " this  is test  ";
        string trim = x.Trim();
        // it  trim the space from end to start
        Console.WriteLine(trim);

        bool flag = x.Contains("is");
        Console.WriteLine(flag);
        string sub = x.Substring(0,2);
        Console.WriteLine(sub);
    }
}