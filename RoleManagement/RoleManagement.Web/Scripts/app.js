var myApp = angular.module('myApp', ['angularUtils.directives.dirPagination']);

myApp.controller('myController', function ($scope, $http) {
    console.log("In myContoller...");
    $scope.RoleDetails = {};


    $http.get('https://localhost:44362/api/RoleType').then(function (response) {
        $scope.RoleTypes = response.data;
    });


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

    $scope.saveRole = function () {

        $http.post('https://localhost:44362/api/Roles', $scope.RoleDetails).then(function (response) {
            
            alert("Successful"); GetAll();
            $scope.RoleDetails = {};
           
        },
            function () {
                alert("Unsuccessful")
            });

    }
    $scope.DeleteRole = function (id) {
        $http.delete('https://localhost:44362/api/Roles/' + id).then(function (response) {
            confirm("Do you want to delete");
            GetAll()
        },
            function () {
                alert("Failed to delete");
            });
    }

    $scope.GetRole = function (Details) {
        $scope.RoleDetails = Details;
        $scope.RoleDetails.EffectiveFrom = new Date(Details.EffectiveFrom);
    }
});