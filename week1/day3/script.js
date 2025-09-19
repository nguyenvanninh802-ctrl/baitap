function evaluateExpression(expression) {
    try {
        const result = new Function("return " + expression)();
        return result;
    } catch {
        return "Lỗi: Biểu thức không hợp lệ";
    }
}

function calculate() {
    const expr = document.getElementById("expression").value;
    document.getElementById("result").innerText = evaluateExpression(expr);
}