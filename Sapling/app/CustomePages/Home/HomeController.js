angular.module('sbAdminApp')
    .controller('HomeCtrl', ['$interval', '$scope', 'HomeService', function ($interval, $scope, HomeService) {
        var vm = this;
        vm.saplingViewModal = {
            Id: 0,
            Position: [],
            TreeName: '',
            IsAll: true
        }
        vm.showDetails = {
            Id: 0,
            IsMine: false,
            Position: [],
            TreeName: '',
            NickName: '',
            PlantedBy: '',
            Photo: [''],
            Address: '',
            Description: '',
        }
        vm.latitude = "13.07412756";
        vm.longitude = "80.26611328";

        vm.myLocation = [vm.latitude, vm.longitude];

        navigator.geolocation.getCurrentPosition(function (location) {
            vm.latitude = location.coords.latitude;
            vm.longitude = location.coords.longitude;

            //get list of saplings by current location
            vm.saplingViewModal.Position = [vm.latitude, vm.longitude];
            HomeService.GetSaplings(vm.saplingViewModal)
                .success(function (data) {
                    vm.positions = data;
                })
                .error(function (data, status) {
                    var errorMessage = (data && data.Message) ? data.Message : data;

                    if (status != 404)
                        alert(errorMessage);
                    //appServices.alertNotify(errorMessage, "bg-red word-break");

                    return false;
                });
        });

        vm.showDetails = false;
        //vm.positions = [
        //    [12.974354, 80.242265], [12.976358, 80.247269], [12.973362, 80.243273], [12.973341, 80.243251]

        //];
        
       
        vm.click = function (event, p) {
            debugger
            HomeService.GetSaplingById(p.Id)
                .success(function (data) {
                    vm.SaplingData = data;
                    vm.showDetails = true;
                })
                .error(function (data, status) {
                    var errorMessage = (data && data.Message) ? data.Message : data;

                    if (status != 404)
                        alert(errorMessage);
                    //appServices.alertNotify(errorMessage, "bg-red word-break");

                    return false;
                });
        

            // map.setZoom(8);
            // map.setCenter(marker.getPosition());
           
        }
        vm.closePopup = function () {
            vm.showDetails = false;
            // vm.myLocation=[17.884659,76.816406]
        }
    }]);