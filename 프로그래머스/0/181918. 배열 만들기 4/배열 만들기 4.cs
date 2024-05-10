using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        List<int> stk = new List<int>();
        int i = 0;
        
        while (i < arr.Length) {
            if (stk.Count == 0) {
                stk.Add(arr[i]);
                i++;
            } else if (stk.Last() < arr[i]) {
                stk.Add(arr[i]);
                i++;
            } else {
                stk.RemoveAt(stk.Count - 1);
            }
        }
        
        return stk.ToArray();
    }
}