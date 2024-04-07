using System;

public class Solution {
    public int solution(int[] num_list) {
        string str1 = "";
        string str2 = "";
        
        foreach(int i in num_list) {
            if (i % 2 == 1) {
                str1 += i.ToString();
            } else {
                str2 += i.ToString();
            }
        }
        
        return int.Parse(str1) + int.Parse(str2);
    }
}