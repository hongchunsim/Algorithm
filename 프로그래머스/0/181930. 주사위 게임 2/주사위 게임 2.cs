using System;

public class Solution {
    public int solution(int a, int b, int c) {
        double answer = 0;
        
        if (a == b || b == c || a == c) {
            answer = (a + b + c) * (Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2));
            
            if (a == b && b == c) {
                answer *= (Math.Pow(a, 3) + Math.Pow(b, 3) + Math.Pow(c, 3));
            }
        } else {
            answer = a + b + c;
        }
        
        return Convert.ToInt32(answer);
    }
}