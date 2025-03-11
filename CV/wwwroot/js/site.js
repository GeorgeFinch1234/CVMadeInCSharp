// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//hides and shows the menu
document.querySelector(`#menuIcon`).addEventListener(`click`, ev => {

    document.querySelector(`nav div`).classList.toggle(`show`);

})

//for the carousel

let slideIndex = 0;
showSlides();

function showSlides() {

    let i;
    let slides = document.getElementsByClassName("slide");
    
        for (i = 0; i < slides.length; i++) {
            slides[i].style.display = "none";
        }
        slideIndex++;
        if (slideIndex > slides.length) { slideIndex = 1 }
        slides[slideIndex - 1].style.display = "block";
   
    setTimeout(showSlides, 5000); // Change image every 2 seconds
}