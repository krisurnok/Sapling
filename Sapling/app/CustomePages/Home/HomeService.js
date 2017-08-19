angular.module('sbAdminApp')
    .factory('HomeService', ['$http', function ($http) {
        return {
            GetSaplings: function (saplingViewModal) {
                return $http({
                    method: 'get',
                    url: '/api/Home/GetSaplings?latitude=' + saplingViewModal.Position[0] + '&longitude=' + saplingViewModal.Position[1] + '&isAll=' + saplingViewModal.isAll                   
                });
            },
            SaveSapling: function (saplingsSaveDetails) {
                return $http({
                    method: 'post',
                    url: '/api/Home/SaveSapling',
                    data: saplingsSaveDetails,
                });
            },
            GetSaplingById: function (id) {
                return $http({
                    method: 'get',
                    url: '/api/Home/GetSaplings?Id='+id
                });
            },
        };
    }]);