App.service("resetService", function ($http) {
    this.updatePassword = function (Details) {
        var response = $http({
            method: "post",
            url: "https://localhost:44362/api/Login/resetPassword",
            data: JSON.stringify(Details),
            dataType: "json"
        });
        return response;
    }
});