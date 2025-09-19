function addTask() {
  const input = document.getElementById("taskInput");
  const task = input.value.trim();
  if (task === "") return alert("Nhập công việc!");
  const li = document.createElement("li");
  li.textContent = task + " ";
  const editBtn = document.createElement("button");
  editBtn.textContent = "Sửa";
  editBtn.className = "edit";
  editBtn.onclick = function() {
    input.value = task;  
    li.remove();         
  };
  const deleteBtn = document.createElement("button");
  deleteBtn.textContent = "Xóa";
  deleteBtn.className = "delete";
  deleteBtn.onclick = function() {
    li.remove();
  };
  li.appendChild(editBtn);
  li.appendChild(deleteBtn);
  document.getElementById("taskList").appendChild(li);
  input.value = ""; 
}