App.service("myService", function ($http) {
    this.userLogin = function (User) {
        var response = $http({
            method: "post",
            url: "https://localhost:44362/api/Login",
            data: JSON.stringify(User),
            dataType: "json"
           });
        return response;
    }
});