using System;
using System.Linq;

public class Solution {
    public int solution(int[] num_list) {
        int mul = 1;
        double sumpow = Math.Pow(num_list.Sum(), 2);
        
        foreach (int i in num_list) {
            mul *= i;
        }
        
        return mul < sumpow ? 1 : 0;
    }
}