
function isValidExpression(expression) {
  return expression && expression.trim().length > 0;
}
function evaluateExpression(expression) {
  try {
    if (!isValidExpression(expression)) {
      return "Lỗi: Biểu thức trống";
    }
    const result = new Function("return " + expression)();
    return result;
  } catch {
    return "Lỗi: Biểu thức không hợp lệ";
  }
}

function handleCalculate() {
  const inputElement = document.getElementById("expression");
  const resultElement = document.getElementById("result");

  const expression = inputElement.value;
  const result = evaluateExpression(expression);

  resultElement.innerText = result;
}