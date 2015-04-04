'use strict';
//heart of pizzahut app

var storeApp = angular.module('PizzaStore', []).
    config(['$routeProvider', function($routeProvider) {
    $routeProvider.
        when('/store', {
        templateUrl: 'partials/store.htm',
        controller: storeController 
        }).
        when('/pizza/:pizzaId', {
        templateUrl: 'partials/pizza.htm',
        controller: storeController
        }).
        when('/cart', {
        templateUrl: 'partials/shoppingCart.htm',
        controller: storeController
        }).
        otherwise({
        redirectTo: '/store'
        });
}]);



// create a data service that provides a store and a shopping cart that
// will be shared by all views (instead of creating fresh ones for each view).
storeApp.factory("DataService", function () {

    // create store
    var myStore = new store();

    // create shopping cart
    var myCart = new shoppingCart("PizzaStore");

   

    // return data object with store and cart
    return {
        store: myStore,
        cart: myCart
    };
});


storeApp.filter('startFrom', function () {
    return function(input, start) {
        start = +start; //parse to int
        return input.slice(start);
    }
});


storeApp.filter('slice', function () {
    return function (arr, start, end) {
        start = +start;
        end = +end;
        return arr.slice(start, end);
    };
});