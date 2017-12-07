(function () {

    var app = angular.module("App", []);

    var FileController = function ($scope, $http) {
        alert("hej")
    }

    app.controller("FileController", ['$scope', '$http', FileController]);

}());