<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>BottleNet Dashboard</title>
    <link rel="stylesheet" href="/CSS FILES/Accounts.css">
</head>
<body>

    <!-- Navigation -->
    <nav class="navbar">
        <div class="logo">
            <img src="/Images/Logo.png" alt="BottleNet Logo">
            <h1>Bottlenet</h1>
        </div>
        <ul class="nav-links">
            <li><a href="/Dashboard.php">Dashboard</a></li>
            <li><a href="/Analytics.php">Analytics</a></li>
            <li><a href="#" class="tab-link active" data-tab="accounts">Accounts</a></li>
        </ul>
        <!-- Profile Section -->
<div class="profile">
    <img src="/Images/profile.png" alt="Profile" id="profile-btn">
    <div class="profile-menu" id="profile-menu">
        <button id="logout-btn">Logout</button>
    </div>
</div>


<!-- Logout Confirmation Modal -->
<div id="logout-modal" class="modal">
    <div class="modal-content">
        <h2>Confirm Logout</h2>
        <p>Are you sure you want to log out?</p>
        <div class="modal-buttons">
            <button id="confirm-logout">Yes, Logout</button>
            <button id="cancel-logout">Cancel</button>
        </div>
    </div>
</div>

    </nav>
        
    <!-- Overview Container -->
    
    <!-- Overview Section -->
<div class="overview-container">
    <div class="overview">
        <h1>Accounts Manager</h1>
    </div>
</div>

<!-- Dashboard Layout -->
<div class="dash">
    <!-- Left Side -->
    <div class="container_accounts">
    

    <!-- Search, Filter, and Add Account Buttons -->
    <div class="actions-container">
    <div class="search-wrapper">
        <img src="/Images/search.png" alt="Search Icon" class="search-icon">
        <input type="text" class="search-bar" placeholder="Search by Account ID or Name">
    </div>
    <div class="button-group">
        <button class="filter-btn">Filter</button>
        <button class="add-account-btn">+ New Account</button>
    </div>
</div>


</div>
    <script src="/JS FILES/Dashboard.js"></script>
</body>
</html>