(function () {

    var app = angular.module("App", []);

    app.controller("FileController", function($scope, $http)
    {

        $scope.getFiles = function()
        {

            $http({
                url: "/File/GetFiles",
                method: "GET",
                params: { company: "TestCompany1", department: "TestDepartment1" }
            }).then(function (response) {

                $scope.files = response.data;
                alert($scope.files)
            });
        }

        $scope.ViewFile = function(filename)
        {
            alert(filename)
            $http({
                url: "/File/ViewFile",
                method: "POST",
                params: { company: "TestCompany1", department: "TestDepartment1", file: filename }
            }).then(function (response) {

            });

        }
    });

}());