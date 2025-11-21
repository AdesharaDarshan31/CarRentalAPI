document.addEventListener("DOMContentLoaded", () => {
    fetch(`${API_BASE_URL}/api/Users`)
        .then(res => res.json())
        .then(data => {
            const tbody = document.querySelector("#usersTable tbody");
            tbody.innerHTML = "";

            data.forEach(user => {
                tbody.innerHTML += `
                    <tr>
                        <td>${user.id}</td>
                        <td>${user.name}</td>
                        <td>${user.email}</td>
                        <td>${user.role}</td>
                    </tr>`;
            });
        })
        .catch(() => {
            document.getElementById("errorMessage").textContent =
                "Could not load users. Is API running?";
        });
});
