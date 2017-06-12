/**
 * Created by hurdissej on 12/05/2017.
 */
(function(){
    angular
        .module('acuDrinks')
        .factory('optionService', ['$http' , optionService]);

    function optionService($http){
        return{
        getAllOptions: getAllOptions
    };

    function getAllOptions() {
        return  $http({
                method: 'get',
                url: '/api/Options',
                cache: true
            }).then(function (result) {
                return result.data;
            })

        }
    }
}());