angular.module('sbAdminApp')
    .controller('PlantTreeCtrl', ['$interval', '$scope', 'PlantTreeService', '$state', 'FileUploader', function ($interval, $scope, PlantTreeService, $state, FileUploader) {
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
            IsExists: false,
            files:[]
        }

        vm.photoUploader = [];

        vm.TreeDetail = [{ Id: 0, Tree: 'Select' }, { Id: 1, Tree: 'Neem' }, { Id: 2, Tree: 'Lemon' }, { Id: 3, Tree: 'Banyan Tree' }, { Id: 4, Tree: 'Peepal Tree' }, { Id: 4, Tree: 'Arjuna Tree' }]
       
        vm.latitude = "13.07412756";
        vm.longitude = "80.26611328";

        vm.files = [];

        vm.saveSapling = function (data) {
            data.latitude = vm.latitude;
            data.longitude = vm.longitude;
         
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
      
        vm.upload = function () {
            alert(vm.files.length + " files selected ... Write your Upload Code");
            PlantTreeService.Upload(vm.files).success(function (data) {
                alert("Succes");
            })
               .error(function (data, status) {
                   var errorMessage = (data && data.Message) ? data.Message : data;

                   if (status != 404)
                       alert(errorMessage);
                   //appServices.alertNotify(errorMessage, "bg-red word-break");

                   return false;
               });

        };
        navigator.geolocation.getCurrentPosition(function (location) {
            vm.latitude = location.coords.latitude;
            vm.longitude = location.coords.longitude;

        
           
        });

        vm.photoUploader = new FileUploader({
            url: '/api/Upload/Upload/',
            ////headers: { 'Authorization': 'Bearer ' + authData.token, 'TokenExpiresOn': authData.TokenExpiresOn, 'Accept': 'application/json' },
            queueLimit: 1,
            removeAfterUpload: true
        });


      
    }]);
angular.module('sbAdminApp').directive('ngFileModel', ['$parse', function ($parse) {
    return {
        restrict: 'A',
        link: function (scope, element, attrs) {
            var model = $parse(attrs.ngFileModel);
            var isMultiple = attrs.multiple;
            var modelSetter = model.assign;
            element.bind('change', function () {
                var values = [];
              
               
                angular.forEach(element[0].files, function (item) {
                    var value = {
                        // File Name 
                        name: item.name,
                        //File Size 
                        size: item.size,
                        //File URL to view                         
                        url: URL.createObjectURL(item),
                        // File Input Value 
                        _file: item,
                        
                    };
           
                    values.push(value);
                });
                scope.$apply(function () {
                    if (isMultiple) {
                        modelSetter(scope, values);
                    } else {
                        modelSetter(scope, values[0]);
                    }
                });
            });
        }
    };
}]);