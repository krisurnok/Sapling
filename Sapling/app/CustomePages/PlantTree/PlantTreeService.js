angular.module('sbAdminApp')
    .factory('PlantTreeService', ['$http', function ($http) {
        return {

            SaveSapling: function (saplingsSaveDetails) {
                return $http({
                    method: 'post',
                    url: '/api/Home/SaveSapling',
                    data: saplingsSaveDetails,
                });
            }
        };
    }]);