
$(document).ready(function () {


    var theForm = $("#theForm");

    var button = $("#buyButton");
    button.on("click", function () {

        console.log("Buy item");
    });

    var prodInfo = $(".product-props li");

    prodInfo.on("click", function () {

        console.log("You clicked" + $(this).text());
    });

    var $loginToggle = $("#loginToggle");
    var $popupForm = $(".popup-form");

    $loginToggle.on("click", function () {

        $popupForm.toggle(400);
    })

});