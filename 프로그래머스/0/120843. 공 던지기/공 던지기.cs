using System;

public class Solution {
    public int solution(int[] numbers, int k) {
        int answer = 0;
        int cnt = 0;
        
        for (int i = 0; cnt < k; i+=2) {            
            if (i >= numbers.Length)
                i -= numbers.Length;
            
            answer = numbers[i];
            cnt++;
        }
        
        return answer;
    }
}