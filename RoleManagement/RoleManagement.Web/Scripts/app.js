﻿var myApp = angular.module('myApp', ['angularUtils.directives.dirPagination']);


myApp.controller('myController', function ($scope, $http) {
    console.log("In myContoller...");
    $scope.RoleDetails = {};
    $scope.modaltitle = "ADD ROLE";

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
           var result =  confirm("Do you want to delete");
            if (result == false)
                return;
            GetAll()
        },
            function () {
                alert("Failed to delete");
            });
    }

    $scope.GetRole = function (Details) {
        if (Details != undefined && Details != null && Details.id != null) {
            $scope.modaltitle = "EDIT ROLE";
        }
        $scope.RoleDetails = Details;
        $scope.RoleDetails.EffectiveFrom = new Date(Details.EffectiveFrom);

    }
});