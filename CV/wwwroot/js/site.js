// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//hides and shows the menu
document.querySelector(`#menuIcon`).addEventListener(`click`, ev => {

    document.querySelector(`nav div`).classList.toggle(`show`);

})