angular.module('sbAdminApp')
    .factory('PlantTreeService', ['$http', function ($http) {
        return {

            SaveSapling: function (saplingsSaveDetails) {
                return $http({
                    method: 'post',
                    url: '/api/Home/SaveSapling',
                    data: saplingsSaveDetails,
                });
            },

            Upload: function (files) {
                debugger;
                var data = new FormData();
                data.append("file", files);
                return $http({
                    method: 'post',
                    url: '/api/Upload/Upload',
                    data: data,
                    headers: { 'Content-Type': 'multipart/form-data' }
                });
            }
        };
    }]);