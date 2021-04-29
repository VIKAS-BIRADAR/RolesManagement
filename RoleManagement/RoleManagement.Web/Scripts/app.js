var myApp = angular.module('myApp', ['angularUtils.directives.dirPagination']);

myApp.controller('myController', function ($scope, $http) {
    console.log("In myContoller...");


    GetAll();
    function GetAll() {
        $http.get('https://localhost:44362/api/Roles').then(function (response) {
            alert("Succesfully able to get records");
            $scope.Roles = response.data
        },
            function () {
                alert("Failed to get records")
            })
    }


});