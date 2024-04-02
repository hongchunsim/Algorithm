public class Solution {
    public bool solution(int x) {
        bool answer = true;
        string str = x.ToString();
        int num = 0;
        
        for (int i = 0; i < str.Length; i++) {
            num += int.Parse(str[i].ToString());
        }
        
        answer = (x % num == 0) ? true : false;
        
        return answer;
    }
}