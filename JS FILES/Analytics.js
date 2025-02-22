document.addEventListener("DOMContentLoaded", () => {
    const profileBtn = document.getElementById("profile-btn");
    const profileMenu = document.getElementById("profile-menu");
    const logoutBtn = document.getElementById("logout-btn");
    const logoutModal = document.getElementById("logout-modal");
    const confirmLogout = document.getElementById("confirm-logout");
    const cancelLogout = document.getElementById("cancel-logout");
    const tabButtons = document.querySelectorAll(".tab-btn");
    const bottleContents = document.querySelectorAll(".container_count .tab-content");
    const storageContents = document.querySelectorAll(".container_data .tab-content");

    profileBtn.addEventListener("click", (event) => {
        event.stopPropagation();
        profileMenu.style.display = profileMenu.style.display === "block" ? "none" : "block";
    });

    logoutBtn.addEventListener("click", (event) => {
        event.stopPropagation();
        logoutModal.style.display = "flex";
        profileMenu.style.display = "none";
    });

    cancelLogout.addEventListener("click", () => {
        logoutModal.style.display = "none";
    });

    confirmLogout.addEventListener("click", () => {
        window.location.href = "/Login.php";
    });

    window.addEventListener("click", (event) => {
        if (event.target === logoutModal) {
            logoutModal.style.display = "none";
        }
    });

    // Set default active tab
    tabButtons[0].classList.add("active");
    document.getElementById("weekly-bottles").classList.add("active");
    document.getElementById("weekly-storage").classList.add("active");

    // Tab switching logic
    tabButtons.forEach((button, index) => {
        button.addEventListener("click", () => {
            // Remove active class from all buttons
            tabButtons.forEach(btn => btn.classList.remove("active"));
            button.classList.add("active");

            // Hide all tab contents
            bottleContents.forEach(content => content.classList.remove("active"));
            storageContents.forEach(content => content.classList.remove("active"));

            // Show the corresponding tab content
            if (index === 0) {
                document.getElementById("weekly-bottles").classList.add("active");
                document.getElementById("weekly-storage").classList.add("active");
            } else if (index === 1) {
                document.getElementById("monthly-bottles").classList.add("active");
                document.getElementById("monthly-storage").classList.add("active");
            } else if (index === 2) {
                document.getElementById("yearly-bottles").classList.add("active");
                document.getElementById("yearly-storage").classList.add("active");
            }
        });
    });
});
