const container = document.querySelector(".container");
const allMenus = document.querySelectorAll(".menu");

// Active-link highlighting based on current URL pathname.
(function highlightActive() {
  const path = window.location.pathname.replace(/\/+$/, "") || "/";
  document.querySelectorAll(".navigation-menu__inner a").forEach(a => {
    const href = (a.getAttribute("href") || "/").replace(/\/+$/, "") || "/";
    const match = href === "/" ? path === "/" : (path === href || path.startsWith(href + "/"));
    if (match) a.classList.add("active");
  });
})();

// Hide menus on body click
document.body.addEventListener("click", () => {
  allMenus.forEach(menu => {
    if (menu.classList.contains("open")) {
      menu.classList.remove("open");
    }
  });
});

// Reset menus on resize
window.addEventListener("resize", () => {
  allMenus.forEach(menu => {
    menu.classList.remove("open");
  });
});

// Handle desktop menu
allMenus.forEach(menu => {
  const trigger = menu.querySelector(".menu__trigger");
  const dropdown = menu.querySelector(".menu__dropdown");

  trigger.addEventListener("click", e => {
    e.stopPropagation();

    if (menu.classList.contains("open")) {
      menu.classList.remove("open");
    } else {
      // Close all menus...
      allMenus.forEach(m => m.classList.remove("open"));
      // ...before opening the current one
      menu.classList.add("open");
    }

    if (dropdown.getBoundingClientRect().right > container.getBoundingClientRect().right) {
      dropdown.style.left = "auto";
      dropdown.style.right = 0;
    }
  });

  dropdown.addEventListener("click", e => e.stopPropagation());
});
