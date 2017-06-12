(function() {
    'use strict';
    angular.module('acuCafe')
        .config(['$routeProvider', config]);

    function config($routeProvider) {
        $routeProvider
            .when('/', {
                templateUrl: '../../ClientApp/drinks/templates/Menu.html',
                controller: 'drinkController',
                controllerAs: 'vm'
            })
            .otherwise('/');
    };
}())