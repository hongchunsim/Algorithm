using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list) {
        int size = num_list.Length;
        int[] answer = new int[size+1];
        
        Array.Copy(num_list, answer, size);
        
        answer[size] = num_list[size-1] > num_list[size-2] ? num_list[size-1] - num_list[size-2] : num_list[size-1] * 2;
        
        return answer;
    }
}