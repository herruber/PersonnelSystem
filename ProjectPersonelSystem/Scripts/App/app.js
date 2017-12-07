(function () {

    var app = angular.module("App", []);

    var FileController = function ($scope, $http) {

        $scope.InitFileHandling = function () {

        }

        $scope.getFiles = function (company, department) {
            $http.get('/File/GetFiles?company=' +company +'&department='+department)
            .then(function (response) {
                $scope.allFiles = response.data;
            });
        }

        $scope.getFileName = function(path)
        {

            var filename = path.split(/(\\|\/)/g).pop();
            return filename;
        }

        $scope.ViewFile = function(path)
        {
            $http.get('/File/ViewFile?filename=' + path)
            .then(function (response) {

                alert("hej")
            });
        }

        
    }

    app.controller("FileController", ['$scope', '$http', FileController]);

}());