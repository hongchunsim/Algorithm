function solution(a, b) {
    var ab = Number(String(a) + String(b));
    var ba = Number(String(b) + String(a));
    return ab >= ba ? ab : ba;
}