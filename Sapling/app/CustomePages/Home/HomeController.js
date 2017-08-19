angular.module('sbAdminApp')
    .controller('HomeCtrl', function ($interval, $scope) {
        var vm = this;
        vm.latitude = "13.07412756";
        vm.longitude = "80.26611328";

        vm.myLocation = [vm.latitude, vm.longitude];

        navigator.geolocation.getCurrentPosition(function (location) {
            vm.latitude = location.coords.latitude;
            vm.longitude = location.coords.longitude;

            console.log(vm.myLocation);
            $scope.$apply(function () {
                vm.myLocation = [vm.latitude, vm.longitude];
            });
            console.log(vm.myLocation);
        });

        vm.showDetails = false;
        vm.positions = [
            [12.974354, 80.242265], [12.976358, 80.247269], [12.973362, 80.243273], [12.973341, 80.243251]

        ];

        vm.click = function (event, p) {
            debugger;
            vm.Selected = [p[0], p[1]];
            // map.setZoom(8);
            // map.setCenter(marker.getPosition());
            vm.showDetails = true;
        }
        vm.closePopup = function () {
            vm.showDetails = false;
            // vm.myLocation=[17.884659,76.816406]
        }
    });