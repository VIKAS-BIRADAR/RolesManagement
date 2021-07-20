App.controller("loginController", function ($rootScope, $scope, myService, $http, $location) {
    $scope.inputType = "password",
        $scope.showHideClass = "glyphicon glyphicon-eye-open"

    $scope.showPassword = function () {
        if ($scope.password != null) {
            if ($scope.inputType == 'password') {
                $scope.inputType = 'text',
                    $scope.showHideClass = 'glyphicon glyphicon-eye-close'
            }
            else {
                $scope.inputType = 'password',
                    $scope.showHideClass = 'glyphicon glyphicon-eye-open'
            }
        }
    }
    /* User Authentication*/
    $scope.showError = false;
    $scope.showSuccess = false;

    $scope.userDetails = function (email) {
        debugger;
        $http.get('https://localhost:44362/api/Login').then(function (response) {
            debugger;
            if (response.data != null && response.data.length > 0) {
                for (var i = 0; i < response.data.length; i++) {
                    if (response.data[i]['Email'] == email) {
                        $rootScope.userName = response.data[i]['Username'];
                        $rootScope.firstName = response.data[i]['FirstName'];
                        $rootScope.lastName = response.data[i]['LastName'];
                        $rootScope.userEmail = response.data[i]['Email'];
                        debugger;
                        $location.url("/dashboard");
                    }
                }
            }

        })
    }

    $scope.authenticate = function () {
        var flag = false;
        var User = {
            Email: $scope.Email,
            Password: $scope.password
        };
        var getData = myService.userLogin(User);
        getData.then(function (msg) {
            if (msg.data == "1") {
                flag = 1;
                $scope.userDetails($scope.Email);

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