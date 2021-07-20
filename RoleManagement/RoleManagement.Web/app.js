var App = angular.module('App', ['angularUtils.directives.dirPagination', 'ngRoute'])
/*Routing Configuration*/
App.config(['$routeProvider',
    function ($routeProvider) {
        $routeProvider
            .when("/login", {
                templateUrl: "HTML/Login.html",
                controller: "loginController"
            })
            .when("/forgotPassword", {
                templateUrl: "HTML/forgotPassword.html",
                controller:"forgotPassword"
            })
            .when("/resetPassword", {
                templateUrl: "HTML/resetPassword.html",
                controller: "resetPassword"
            })
            .when("/dashboard", {
                templateUrl: "HTML/dashboard.html",
                controller: "dashboardController"
            }, {
                templateUrl: "HTML/dashboard.html",
                controller:"loginController"
            })
            .when("/", {
                templateUrl:"HTML/home.html"
            })

    }]);
