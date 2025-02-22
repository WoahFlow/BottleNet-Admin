<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>BottleNet Dashboard</title>
    <link rel="stylesheet" href="/CSS FILES/Analytics.css">
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
            <li><a href="#" class="tab-link active" data-tab="analytics">Analytics</a></li>
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
        

        <div class="overview-container">
        <div class="overview-header">
    <h1>Analytic Report</h1>
    <div class="tab-buttons">
        <button class="tab-btn">Weekly</button>
        <button class="tab-btn">Monthly</button>
        <button class="tab-btn">Yearly</button>
    </div>
</div>

</div>

<!-- Dashboard Layout -->
<div class="dash">
    <!-- Left Side (Bottle Count) -->
    <div class="container_count">
        <div class="overview"><h1>Bottle Count</h1></div>
        <div class="tab-content active" id="weekly-bottles">
            <p>Weekly Bottle Count: 500</p>
        </div>
        <div class="tab-content" id="monthly-bottles">
            <p>Monthly Bottle Count: 2000</p>
        </div>
        <div class="tab-content" id="yearly-bottles">
            <p>Yearly Bottle Count: 24000</p>
        </div>
    </div>

    <!-- Right Side (Bin Storage Capacity + Tabs) -->
    <div class="right-container">
    

        <div class="container_data">
            <div class="overview"><h1>Bin Storage Capacity</h1></div>
            <div class="tab-content active" id="weekly-storage">
                <p>Weekly Bin Storage: 60%</p>
            </div>
            <div class="tab-content" id="monthly-storage">
                <p>Monthly Bin Storage: 75%</p>
            </div>
            <div class="tab-content" id="yearly-storage">
                <p>Yearly Bin Storage: 90%</p>
            </div>
        </div>
    </div>
</div>




    </div>
    <script src="/JS FILES/Analytics.js"></script>
</body>
</html>