using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        string str1 = a.ToString() + b.ToString();
        string str2 = b.ToString() + a.ToString();
        
        if(int.Parse(str1) >= int.Parse(str2)) {
            answer = int.Parse(str1);
        } else {
            answer = int.Parse(str2);
        }
        
        return answer;
    }
}