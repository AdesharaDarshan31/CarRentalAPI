document.getElementById("contactForm").addEventListener("submit", (e) => {
    e.preventDefault();

    const data = {
        name: document.getElementById("name").value,
        email: document.getElementById("email").value,
        message: document.getElementById("message").value,
        sentAt: new Date().toISOString()
    };

    fetch(`${API_BASE_URL}/api/ContactMessages`, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(data)
    })
        .then(res => res.ok ? res.json() : Promise.reject())
        .then(() => {
            document.getElementById("responseMessage").textContent = "Message sent!";
            document.getElementById("contactForm").reset();
        })
        .catch(() => {
            document.getElementById("responseMessage").textContent = "Error sending message!";
        });
});
