// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
window.addEventListener("DOMContentLoaded", function () {
    let timerContainer = document.querySelector(".timer");
    let timeInput = document.querySelector(".dateAndTime");

    let select = document.querySelector('.selectbox');
    select.addEventListener("change", (e) => {
        console.log(e.target.value);
    })

    setInterval(() => {
    let timer = new Date().toLocaleString();
        timerContainer.textContent = timer;
        timeInput.value = timer;
    }, 900)

    let selectbox = document.querySelector("#select");
    let submitBtn = document.querySelector("#submitBtn");

    submitBtn.setAttribute("disabled", "true")
    selectbox.addEventListener("change", (e) => {
        if (e.target.value !== "null" || e.target.value !== "") {
            submitBtn.removeAttribute("disabled");
        }
    })

})