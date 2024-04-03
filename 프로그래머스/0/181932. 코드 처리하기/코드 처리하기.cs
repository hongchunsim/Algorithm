using System;

public class Solution {
    public string solution(string code) {
        string ret = "";
        bool mode = true;
        
        for(int idx = 0; idx < code.Length; idx++) {
            if (code[idx] == '1') {
                mode = !mode;
            } else {
                if (mode) {
                    if (idx % 2 == 0)
                        ret += code[idx];
                } else {
                    if (idx % 2 == 1) {
                        ret += code[idx];
                    }
                }
            }
        }
        
        return String.IsNullOrEmpty(ret) ? "EMPTY" : ret;
    }
}