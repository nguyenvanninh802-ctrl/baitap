
const customers = [
  {
    id: 1,
    name: "Nguyễn Văn Ninh",
    email: "ninh.nguyen@gmail.com",
    phone: "0868771245",
    bookings: [
      {
        id: 101,
        title: "Phòng Deluxe - 3 đêm",
        body: "Check-in: 12/09/2025\nCheck-out: 15/09/2025\nYêu cầu: Phòng view biển"
      },
      {
        id: 102,
        title: "Phòng Standard - 1 đêm",
        body: "Check-in: 20/09/2025\nCheck-out: 21/09/2025\nThanh toán tại quầy"
      }
    ]
  },
  {
    id: 2,
    name: "Trần Thị Mai",
    email: "mai.tran@yahoo.com",
    phone: "0987654321",
    bookings: [
      {
        id: 201,
        title: "Suite VIP - 2 đêm",
        body: "Check-in: 25/09/2025\nCheck-out: 27/09/2025\nYêu cầu: Thêm giường phụ"
      }
    ]
  }
];

const customerList = document.getElementById("customerList");
const customerTitle = document.getElementById("customerTitle");
const bookingList = document.getElementById("bookingList");

customers.forEach(customer => {
  const li = document.createElement("li");
  li.innerHTML = `
    <strong>${customer.name}</strong><br>
    <small>${customer.email}</small><br>
    <small>${customer.phone}</small>
  `;

  li.addEventListener("click", () => {
 
    document.querySelectorAll("#customerList li").forEach(el => el.classList.remove("active"));
    li.classList.add("active");

    customerTitle.textContent = `Đơn đặt phòng của ${customer.name}`;
    bookingList.innerHTML = "";

    customer.bookings.forEach(b => {
      const div = document.createElement("div");
      div.className = "booking";
      div.innerHTML = `
        <h3>${b.title}</h3>
        <pre>${b.body}</pre>
      `;
      bookingList.appendChild(div);
    });
  });

  customerList.appendChild(li);
});