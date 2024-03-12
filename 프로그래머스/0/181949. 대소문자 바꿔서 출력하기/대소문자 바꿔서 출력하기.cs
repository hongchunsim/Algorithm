using System;

public class Example
{
    public static void Main()
    {
        String s;
        String result = "";

        Console.Clear();
        s = Console.ReadLine();
        
        foreach (char c in s) {
            if (char.IsUpper(c)) {
                result += char.ToLower(c);
            } else {
                result += char.ToUpper(c);
            }
        }
        
        Console.WriteLine(result);
    }
}