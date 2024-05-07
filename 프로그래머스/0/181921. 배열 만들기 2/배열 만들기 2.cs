using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int l, int r) {
        List<int> answer = new List<int>();
        bool isRight;
        
        for (int i = l; i <= r; i++) {
            isRight = true;
            
            foreach(char c in i.ToString()) {
                if (c == '0' || c == '5') {
                    isRight = true;
                    continue;
                } else {
                    isRight = false;
                    break;
                }
            }
            
            if (isRight) {
                answer.Add(i);
            }
        }
        
        if (answer.Count == 0) {
            answer.Add(-1);
        }
        
        return answer.ToArray();
    }
}