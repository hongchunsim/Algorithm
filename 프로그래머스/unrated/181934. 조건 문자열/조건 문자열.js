function solution(ineq, eq, n, m) {
    var op = ineq.concat(eq)
    if(op === ">=")
        return n >= m ? 1 : 0
    else if(op === "<=")
        return n <= m ? 1 : 0
    else if(op === ">!")
        return n > m ? 1 : 0
    else
        return n < m ? 1 : 0
}