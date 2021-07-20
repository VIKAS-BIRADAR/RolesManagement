App.controller("resetPassword", function ($scope, $http, resetService) {
    $scope.IsVisible = false;

    $scope.Send = function () {
        debugger;
        var Details = {
            Email: $scope.email,
            Password: $scope.oldpassword,
            NewPassword: $scope.newpassword
        };
        var updatePassword = resetService.updatePassword(Details);
        updatePassword.then(function (msg) {
            if (msg.data == "1") {
                alert("Password updated succesfully");
             }
            else {
                alert("Failed to update password");
            }
        });
    }
    $scope.Compare = function () {
        if ($scope.newpassword != $scope.confirmpassword) {
            $scope.IsVisible = true;
        } else {
            $scope.IsVisible = false;
        }
    }

})