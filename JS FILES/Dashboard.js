document.addEventListener("DOMContentLoaded", () => {
    const profileBtn = document.getElementById("profile-btn");
    const profileMenu = document.getElementById("profile-menu");
    const logoutBtn = document.getElementById("logout-btn");
    const logoutModal = document.getElementById("logout-modal");
    const confirmLogout = document.getElementById("confirm-logout");
    const cancelLogout = document.getElementById("cancel-logout");

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
});
