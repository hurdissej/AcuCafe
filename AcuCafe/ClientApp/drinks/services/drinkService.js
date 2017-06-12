/**
 * Created by elliot.hurdiss on 10/05/2017.
 */

(function(){
    angular
        .module('acuDrinks')
        .factory('drinkService', ['$http', drinkService]);

    function drinkService($http){
        return {
            getAllDrinks: getAllDrinks
        };

        function getAllDrinks(){

            return $http({
                method: 'get',
                url: '/api/Drinks',
                cache: true
            }).then(function (result) {
                console.log(result.data);
                return result.data;
            });

        }

    }

}());