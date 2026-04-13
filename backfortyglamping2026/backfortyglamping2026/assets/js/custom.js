// custom.js

// 2. Navbar Scroll Logic (Header Fix)
$(document).ready((function() {
    $(window).scroll((function() {
        // console.log($(window).scrollTop()); // Keeping this line is fine for development, but remove it for production.
        
        if ($(window).scrollTop() > 20) {
            $(".navbar_top").addClass("navbar-fixed-top");
        } else {
            $(".navbar_top").removeClass("navbar-fixed-top");
        }
    }));
}));

// 3. Side Navigation Open Click
$(".navbartoggler").click((function() {
    $(".sidenav").addClass("open");
}));

// 4. Side Navigation Close Click
$(".closebtn").click((function() {
    $(".sidenav").removeClass("open");
}));

// 3. Side Navigation Open Click
$(".navbartoggler").click((function() {
    $(".header-sec").addClass("opennew");
}));

// 4. Side Navigation Close Click
$(".closebtn").click((function() {
    $(".header-sec").removeClass("opennew");
}));

$(document).ready(function () { var d = new Date(); document.getElementById('labeldate').innerHTML = d.getFullYear(); });
var cmenuId = "." + $("#MenuId").text();
$(cmenuId).parent().addClass('active');


document.querySelectorAll(".nav-item.dropdownnew").forEach(dropdown => {

    const menu = dropdown.querySelector(".dropdown-hover");
    if (!menu) return;

    const leftBox = menu.querySelector(".dropdown-hoverleft");
    const items = menu.querySelectorAll(".dropdown-hoverright .dropdown-item");
    if (!leftBox || !items.length) return;

    const firstImg = items[0].querySelector("img");

    /* 🔹 show default image when dropdown OPENS */
    dropdown.addEventListener("shown.bs.dropdown", () => {
        if (firstImg) {
            leftBox.style.backgroundImage = `url(${firstImg.src})`;
        }
        items.forEach(i => i.classList.remove("active-item"));
        items[0].classList.add("active-item");
    });

    /* hover on links */
    items.forEach(item => {
        item.addEventListener("mouseenter", () => {
            const img = item.querySelector("img");
            if (!img) return;

            leftBox.style.backgroundImage = `url(${img.src})`;

            items.forEach(i => i.classList.remove("active-item"));
            item.classList.add("active-item");
        });
    });

    /* reset on full dropdown leave */
    menu.addEventListener("mouseleave", () => {
        if (firstImg) {
            leftBox.style.backgroundImage = `url(${firstImg.src})`;
        }
        items.forEach(i => i.classList.remove("active-item"));
        items[0].classList.add("active-item");
    });

});

