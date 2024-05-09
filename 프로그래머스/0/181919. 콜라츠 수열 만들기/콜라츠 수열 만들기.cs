using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        // int[] answer = new int[] {};
        List<int> answer = new List<int>();
        
        while(true) {
            answer.Add(n);
            
            if (n == 1) {
                break;
            } else if (n % 2 == 0) {
                n /= 2;
            } else {
                n = 3 * n + 1;
            }
        }
        
        return answer.ToArray();
    }
}