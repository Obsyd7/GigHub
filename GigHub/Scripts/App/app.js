
var GigsController = function() {

    var init = function() {
        $(".js-toggle-attendance").click(toggleAttendance);
          
    };

    var toggleAttendance = function(e) {
        var button = $(e.target);
        if (button.hasClass("btn-default")) {
            $.post("/api/attendances", { gigId: button.attr("data-gig-id") })
                .done(function () {
                    button
                        .removeClass("btn-default")
                        .addClass("btn-info")
                        .text("Going");
                })
                .fail(fail);
        } else {

            $.ajax({
                    url: "/api/attendances/" + button.attr("data-gig-id"),
                    method: "DELETE"
                })
                .done(function() {
                    button
                        .removeClass("btn-info")
                        .addClass("btn-default")
                        .text("Going?");
                })
                .fail(fail);
        }   
    };

    var done = function() {

    };

    var fail = function() {
        alert("Something went wrong");
    };

    return {
        init: init
    }

}();