var App = angular.module("App", ['ngRoute']);


App.controller("loginController", function ($scope, myService) {
    $scope.inputType = "password",
    $scope.showHideClass = "glyphicon glyphicon-eye-open"

    $scope.showPassword = function () {
        if ($scope.password != null) {
            if ($scope.inputType == 'password') {
                $scope.inputType = 'text',
                $scope.showHideClass = 'glyphicon glyphicon-eye-close'
            }
            else
            {
                $scope.inputType = 'password',
                    $scope.showHideClass = 'glyphicon glyphicon-eye-open'
            }

        }

    }

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
                window.location.href = "/dashboard.html";

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
