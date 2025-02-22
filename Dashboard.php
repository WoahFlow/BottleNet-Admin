<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>BottleNet Dashboard</title>
    <link rel="stylesheet" href="/CSS FILES/Dashboard.css">
</head>
<body>

    <!-- Navigation -->
    <nav class="navbar">
        <div class="logo">
            <img src="/Images/Logo.png" alt="BottleNet Logo">
            <h1>Bottlenet</h1>
        </div>
        <ul class="nav-links">
            <li><a href="#" class="tab-link active" data-tab="dashboard">Dashboard</a></li>
            <li><a href="/Analytics.php">Analytics</a></li>
            <li><a href="/Accounts.php">Accounts</a></li>
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
        <h1>Overview</h1>
    </div>
</div>

<!-- Dashboard Layout -->
<div class="dash">
    <!-- Left Side -->
    <div class="container_bottle">
        <div class="overview"><h1>Bottle Count</h1></div>
    </div>

    <!-- Right Side -->
    <div class="right-container">
        <div class="container_bin">
            <div class="overview"><h1>Bin Storage Capacity</h1></div>
        </div>
        <div class="container_network">
            <div class="overview"><h1>Network Consumption</h1></div>
        </div>
    </div>


    </div>
    <script src="/JS FILES/Dashboard.js"></script>
</body>
</html>