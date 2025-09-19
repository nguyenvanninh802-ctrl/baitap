
function showUser({
  name = "Ẩn danh",
  age,
  contact: { email, phone },
  ...rest
}) {
  console.log(`👤 Tên: ${name}`);
  console.log(`🎂 Tuổi: ${age}`);
  console.log(`📧 Email: ${email}`);
  console.log(`📱 Phone: ${phone}`);
  console.log("🔎 Thông tin khác:", rest);
}

const user = {
  name: "Ninh",
  age: 20,
  contact: { email: "ninh.nguyenvan@tpssoft.com", phone: "0868771245" },
  gender: "Nam",
  hobby: "Da bóng",
};

showUser(user);