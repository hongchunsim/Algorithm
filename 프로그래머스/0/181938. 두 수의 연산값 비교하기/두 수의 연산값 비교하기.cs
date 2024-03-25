using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        string str1 = a.ToString() + b.ToString();
        
        if (int.Parse(str1) >= 2 * a * b) {
            answer = int.Parse(str1);
        } else {
            answer = 2 * a * b;
        }
        
        return answer;
    }
}