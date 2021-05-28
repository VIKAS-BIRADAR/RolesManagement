var App = angular.module("App", ['ngRoute']);
App.config(['$routeProvider',function ($routeProvider) {
    $routeProvider
        .when('/login', {
            templateUrl: 'Login.html',
            controller:'loginController'
        })
      
}]);

App.controller("loginController", function ($scope, myService) {
    $scope.showError = false; 
    $scope.showSuccess = false;

    $scope.authenticate = function () {
        var flag = false;
        var User = {
            Username :$scope.uName,
            Password :$scope.password
        };
        var getData = myService.userLogin(User); 
        getData.then(function (msg) {
            if (msg.data == "1") {
                flag = 1;
                window.location.href = "/index.html";

            }
            else {
                
                flag = false;
            }
            if (flag) {
                $scope.showError = false;
                $scope.showSuccess = true;
            }
            else {
                $scope.showError = true;
                $scope.showSuccess = false;
            }
        });
    }

})
