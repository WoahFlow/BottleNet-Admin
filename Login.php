<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>BottleNet Admin Login</title>
    <link rel="stylesheet" href="/CSS FILES/Login.css">
</head>
<body>
    <div class="login-wrapper">
        <div class="login-header">
            <img src="/Images/Logo.png" alt="BottleNet Logo" class="logo">
            <h1>BottleNet Admin</h1>
        </div>
        <div class="login-container">
            <form class="login-form">
                <div class="form-group">
                    <input type="text" id="username" name="username" placeholder="Username" required>
                </div>
                <div class="form-group password-group">
                    <input type="password" id="password" name="password" placeholder="Password" required>
                    <span class="toggle-password" onclick="togglePassword()">
                        <img src="/Images/show-password.png" id="eye-icon" alt="Toggle Password">
                    </span>
                </div>
                <button type="submit" class="login-button">Login</button>
                <a href="#" class="forgot-password">Forgot Password?</a>
            </form>
        </div>
    </div>
    <script src="/JS FILES/Login.js"></script>
</body>
</html>
