using System;

public class Solution {
    public long solution(string numbers) {
        string answer = "";
        string str = "";
        
        foreach (char c in numbers) {
            str += c.ToString();
            
            switch(str) {
                case "one":
                    answer += '1'.ToString();
                    str = "";
                    break;
                case "two":
                    answer += '2'.ToString();
                    str = "";
                    break;
                case "three":
                    answer += '3'.ToString();
                    str = "";
                    break;
                case "four":
                    answer += '4'.ToString();
                    str = "";
                    break;
                case "five":
                    answer += '5'.ToString();
                    str = "";
                    break;
                case "six":
                    answer += '6'.ToString();
                    str = "";
                    break;
                case "seven":
                    answer += '7'.ToString();
                    str = "";
                    break;
                case "eight":
                    answer += '8'.ToString();
                    str = "";
                    break;
                case "nine":
                    answer += '9'.ToString();
                    str = "";
                    break;
                case "zero":
                    answer += '0'.ToString();
                    str = "";
                    break;
            }
        }
        
        return long.Parse(answer);
    }
}