var ReshController = function ($scope, $routeParams) {
   
}

ReshController.$inject = ['$scope', '$routeParams'];

ReshApplication.controller('ReshController', function ($scope, ReshService) {

    getStudents();
    function getStudents() {
        ReshService.getStudents()
            .success(function (studs) {
                $scope.students = studs;
                console.log($scope.students);
            })
            .error(function (error) {
                $scope.status = 'Unable to load customer data: ' + error.message;
                console.log($scope.status);
            });
    }
});