function togglePassword() {
    var passwordField = document.getElementById("password");
    var eyeIcon = document.getElementById("eye-icon");

    if (passwordField.type === "password") {
        passwordField.type = "text";
        eyeIcon.src = "/Images/hide-password.png"; // Change to open eye icon
    } else {
        passwordField.type = "password";
        eyeIcon.src = "/Images/show-password.png"; // Change to closed eye icon
    }
}


document.addEventListener("DOMContentLoaded", function () {
    const loginForm = document.querySelector(".login-form");

    loginForm.addEventListener("submit", function (event) {
        event.preventDefault(); // Prevents default form submission
        
        // Example: Add validation (optional)
        const username = document.getElementById("username").value;
        const password = document.getElementById("password").value;

        if (username.trim() === "" || password.trim() === "") {
            alert("Please enter both username and password.");
            return;
        }

        // Redirect to Dashboard.php upon successful login
        window.location.href = "Dashboard.php";
    });
});

// Toggle password visibility function
function togglePassword() {
    const passwordField = document.getElementById("password");
    const eyeIcon = document.getElementById("eye-icon");

    if (passwordField.type === "password") {
        passwordField.type = "text";
        eyeIcon.src = "/Images/hide-password.png"; // Change to hide icon
    } else {
        passwordField.type = "password";
        eyeIcon.src = "/Images/show-password.png"; // Change to show icon
    }
}
