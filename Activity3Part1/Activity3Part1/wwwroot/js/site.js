// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function () {
    console.log("page is ready");

    $(".customerRadio").change(function () {
        console.log("Radio Button Changed");
        doCustomerUpdate();
    });

    function doCustomerUpdate() {
        $.ajax({
            type: "POST",
            url: 'Customer/OnSelectCustomer',
            data: $("form").serialize(),
            success: function (data) {
                console.log(data);
                $("#customerInformationArea").html(data);            
            }
        });
        $.ajax({
            type: "POST",
            url: 'Customer/GetMoreInfo',
            data: $("form").serialize(),
            success: function (data) {
                console.log(data);
                alert(data);
            } 
        });
    }

    $("#selectCustomer").click(function () {
        event.preventDefault();
        console.log("select button was clicked");
        doCustomerUpdate();        
    });
});