angular.module('sbAdminApp')
    .factory('HomeService', ['$http', function ($http) {
        return {
            GetSaplings: function (saplingViewModal) {
                return $http({
                    method: 'post',
                    url: '/api/Home/GetSaplings',
                    data: saplingViewModal
                });
            }
        };
    }]);