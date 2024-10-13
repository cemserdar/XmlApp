$(document).ready(() => {
    fnSetActions();
    fnPrepareSidebar();
});

const fnPrepareSidebar = () => {
    $(".nav-link").removeClass("active");

    const currentPath = window.location.pathname.toLowerCase();
    $(".nav-link").each(function () {
        const linkPath = $(this).attr("href").toLowerCase();
        if (currentPath === linkPath) {
            $(this).addClass("active");
        }
    });
}

const fnSetActions = () => {
}

const fnSetNavItemActive = (e) => {
    $(".nav-link").removeClass("active");
    $(e.currentTarget).find(".nav-link").addClass("active");

    const linkHref = $(e.currentTarget).find(".nav-link").attr("href");
    localStorage.setItem('activeNavLink', linkHref);
}