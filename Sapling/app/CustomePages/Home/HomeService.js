angular.module('sbAdminApp')
    .factory('HomeService', ['$http', function ($http) {
        return {
            GetSaplings: function (saplingViewModal) {                
                return $http({
                    method: 'get',
                    url: '/api/Home/GetSaplings?latitude=' + saplingViewModal.Position[0] + '&longitude=' + saplingViewModal.Position[1] + '&isAll=true'                   
                });
            },         
            GetSaplingById: function (id) {
                return $http({
                    method: 'get',
                    url: '/api/Home/GetSaplingById/' + id
                });
            },
        };
    }]);