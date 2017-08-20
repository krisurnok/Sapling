angular.module('sbAdminApp')
    .controller('PlantTreeCtrl', ['$interval', '$scope', 'PlantTreeService','$state', function ($interval, $scope, PlantTreeService, $state) {
        var vm = this;
        vm.saplingSaveModal = {
            Id: 0,
            Latitude: '',
            Longitude: '',
            TreeId: 0,
            NickName: '',
            PlantedBy: '',
            ReasonForNotExists: '',
            Address: '',
            NextActionText: '',
            Description: '',
            IsExists: false
        }

        vm.TreeDetail = [{ Id: 0, Tree: 'Select' }, { Id: 1, Tree: 'Neem' }, { Id: 2, Tree: 'Lemon' }, { Id: 3, Tree: 'Banyan Tree' }, { Id: 4, Tree: 'Peepal Tree' }, { Id: 4, Tree: 'Arjuna Tree' }]
       
        vm.latitude = "13.07412756";
        vm.longitude = "80.26611328";


        vm.saveSapling = function (data) {
            data.latitude = vm.latitude;
            data.longitude = vm.longitude;
            debugger;
            PlantTreeService.SaveSapling(data)
               .success(function (data) {
                   $state.go('dashboard.home');
               })
               .error(function (data, status) {
                   var errorMessage = (data && data.Message) ? data.Message : data;

                   if (status != 404)
                       alert(errorMessage);
                   //appServices.alertNotify(errorMessage, "bg-red word-break");

                   return false;
               });
        }
      

        navigator.geolocation.getCurrentPosition(function (location) {
            vm.latitude = location.coords.latitude;
            vm.longitude = location.coords.longitude;

        
           
        });

      
    }]);