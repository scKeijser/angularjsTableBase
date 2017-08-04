var planeApp = angular.module('planeApp', []);
planeApp.controller('planeController', ['$scope', '$http', function ($scope, $http) {
    //ScopeVariable for Collection Data
    $scope.planes;
    $scope.passengers;
    //End Collection Data
    $scope.data = { 'StartLoc': '', 'EndLoc': '', 'PlaneID': '', 'Passengers': [] };

    $scope.getPlanes = function () {
        //Fetch Plane Data
    };

    $scope.getPassengers = function () {
        //Fetch Passenger Data
    };

    $scope.sub = function () {
        //Submit data
    };


    //Sorting
    $scope.reverse = true;
    $scope.sortBy = function (propertyName) {
        $scope.reverse = ($scope.propertyName === propertyName) ? !$scope.reverse : false;
        $scope.propertyName = propertyName;
    };

}]);