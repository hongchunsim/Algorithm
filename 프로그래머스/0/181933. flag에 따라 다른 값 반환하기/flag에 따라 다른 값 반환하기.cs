using System;

public class Solution {
    public int solution(int a, int b, bool flag) {
        int answer = 0;
        
        answer = flag ? a + b : a - b;
        
        return answer;
    }
}