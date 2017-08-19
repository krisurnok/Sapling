angular.module('sbAdminApp')
    .factory('HomeService', ['$http', function ($http) {
        return {
            GetSaplings: function (saplingViewModal) {
                return $http({
                    method: 'get',
                    url: '/api/Home/GetSaplings?latitude=' + saplingViewModal.Position[0] + '&longitude=' + saplingViewModal.Position[1] + '&isAll=' + saplingViewModal.isAll,
                    data: saplingViewModal,
                    headers: {
                        'Content-Type': 'application/json; charset=utf-8'
                    }
                });
            }
        };
    }]);