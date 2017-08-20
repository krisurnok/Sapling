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
            vm.photoUploader.uploadAll()
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

        vm.photoUploader = $scope.photoUploader = new FileUploader({
            url: '/api/Upload/Upload/',
            ////headers: { 'Authorization': 'Bearer ' + authData.token, 'TokenExpiresOn': authData.TokenExpiresOn, 'Accept': 'application/json' },
            queueLimit: 1,
            removeAfterUpload: true
        });

        vm.photoUploader.onWhenAddingFileFailed = function (item /*{File|FileLikeObject}*/, filter, options) {
            console.info('onWhenAddingFileFailed', item, filter, options);
        };
        vm.photoUploader.onAfterAddingFile = function (fileItem) {
            console.info('onAfterAddingFile', fileItem);
        };
        vm.photoUploader.onAfterAddingAll = function (addedFileItems) {
            console.info('onAfterAddingAll', addedFileItems);
        };
        vm.photoUploader.onBeforeUploadItem = function (item) {
            console.info('onBeforeUploadItem', item);
        };
        vm.photoUploader.onProgressItem = function (fileItem, progress) {
            console.info('onProgressItem', fileItem, progress);
        };
        vm.photoUploader.onProgressAll = function (progress) {
            console.info('onProgressAll', progress);
        };
        vm.photoUploader.onSuccessItem = function (fileItem, response, status, headers) {
            console.info('onSuccessItem', fileItem, response, status, headers);
        };
        vm.photoUploader.onErrorItem = function (fileItem, response, status, headers) {
            console.info('onErrorItem', fileItem, response, status, headers);
        };
        vm.photoUploader.onCancelItem = function (fileItem, response, status, headers) {
            console.info('onCancelItem', fileItem, response, status, headers);
        };
        vm.photoUploader.onCompleteItem = function (fileItem, response, status, headers) {
            console.info('onCompleteItem', fileItem, response, status, headers);
        };
        vm.photoUploader.onCompleteAll = function () {
            console.info('onCompleteAll');
        };
      
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